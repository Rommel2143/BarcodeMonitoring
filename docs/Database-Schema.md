---
tags: [database, sqlite]
---
# Database Schema

Back to [[INDEX]]. Connection: `dbconn.con` = `Data Source=<exe folder>\database.db;Version=3;`. The `.db` file is not in the repo; the DDL lives in `dbconn.SchemaTables` (copied from the production database).

## Auto-create / upgrade (`EnsureDatabase`)
Runs first in `Mainframe_Load`. In one transaction it:
1. Creates `database.db` if missing (SQLite makes the file on open) and runs `CREATE TABLE IF NOT EXISTS` for every table below.
2. For existing tables, adds any missing column with `ALTER TABLE … ADD COLUMN` (for old DBs without e.g. `input_set.FVI/ADF` or `barcodes_adf`).
3. Seeds empty tables only: `LINE` = "Please Change LINE first !", `input_set` = (1,1,1,0,1), `judgement` = the 19 production defects (G, SCRATCH, MISSING, …).
4. Replaces NULL `input_set` flags with 0.
Existing rows are never changed, so pasting an old `database.db` is safe. Then `UpgradeTimeFormat()` runs (see Time format below).

## MODEL
Columns: `id`, `model` (unique — duplicate insert raises SQLite constraint error), `sc`, `crcis`, `cism`, `adf`, `fvi`.
Each serial column holds the **prefix pattern** expected for that model.
- Write: `InsertData`, `deleteModel` ([[Modules#dbconn]]) from [[Screens#create_model]].
- Read: `checkcode` and `cmb_display` in [[Scan-Workflow]]; grid in create_model.

## LINE
Columns: `line`. Expected to hold exactly one row (this PC's production line).
- Read: `getLine()` (returns first row or "LINE NOT REGISTERED! Please call IT").
- Write: `create_line.UpdateLine` (then the app exits). `InsertLine`, `deleteLine` exist but are unused.

## input_set
Columns: `SC`, `CRCIS`, `CISM`, `FVI`, `ADF` (0/1). Single row: which serial boxes are active at this station.
- Read: `barcode_scan.getSet`, `set_input.getSet`.
- Write: `set_input` "Set" button (`UPDATE input_set SET …` — no WHERE, assumes one row).

## barcodes
Columns: `id`, `datein`, `shift`, `model`, `SC`, `CRCIS`, `CISM`, `ADF`, `Name`, `line`, `timein`, `judgement`, `remarks`.
- Write: `Insertbarcode` (judgement `'G'`, remarks `''`); `UpdateJudgementInDatabase` from [[Screens#viewrecords]].
- Read: today's grid in barcode_scan, range search in viewrecords.

## barcodes_fvi
Columns: `id`, `datein`, `shift`, `model`, `FVI`, `Name`, `line`, `timein`, `judgement`, `remarks`.
- Write: `InsertbarcodeFVI`. Read: FVI mode of barcode_scan and viewrecords.

## barcodes_adf
Columns: `id`, `datein`, `shift`, `model`, `adf`, `Name`, `line`, `timein`, `judgement`, `remarks`.
- Write: `InsertbarcodeADF` (**never called**). Read: `viewrecords.adf()` (**never called**).

## Time format (`timein`)
`barcodes`, `barcodes_fvi`, `barcodes_adf` store `timein` as text `HH:mm:ss` (since 2026-11-06; before that `HH:mm`). On every start `UpgradeTimeFormat()` pads `HH:mm` rows to `HH:mm:00`. It is safe to re-run and skips tables that don't exist.

## judgement
Columns: `judge`. Lookup list for the Judgement combo column in viewrecords.

Related: [[Known-Issues]] (SQL injection, missing DDL).
