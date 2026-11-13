---
tags: [workflow, barcode_scan]
---
# Scan Workflow

Back to [[INDEX]]. Code: `Barcode Monitoring/barcode_scan.vb`. Screen details: [[Screens#barcode_scan]].

## On load (`barcode_scan_Load`)

1. Show date, shift (`getshift()`), today's total (`totalToday()`).
2. `lbl_line.Text = getLine()` — reads the single row from table `LINE` ([[Database-Schema#LINE]]).
3. `getSet()` — reads `input_set` and enables/disables the SC, CRCIS, CISM, FVI, ADF text boxes ([[Database-Schema#input_set]]).
4. `Timer1` refreshes date/shift labels.

## Gate

`panel_chk` (the scan boxes) is enabled only when a **model** is selected in `cmb_model` and an operator **name** is typed in `txt_name`. `cmb_model` is filled on click from `MODEL` via `cmb_display`.

## Multi-serial chain (SC → CRCIS → CISM → ADF)

Each box handles **Enter** (scanners send Enter after the code):

| Box | Check | Prefix length | On success |
|---|---|---|---|
| `txt_sc` | `checkcode(text, "SC", 3)` | 3 | `process_sc()` |
| `txt_crcis` | `checkcode(text, "crcis", 2)` | 2 | `process_crcis()` |
| `txt_cism` | `checkcode(text, "cism", 2)` | 2 | `process_cism()` |
| `txt_adf` | `checkcode(text, "adf", 3)` | 3 | `process_adf()` |

- `checkcode` runs `SELECT id FROM MODEL WHERE <column> LIKE '%<first N chars>%' AND MODEL LIKE <selected model>` — i.e. the scanned serial's prefix must match the pattern registered for that model in [[Screens#create_model]]. Failure → `MessageBox "Invalid QR"`.
- `process_sc` → focus CRCIS if enabled, else fall through to `process_crcis` → … → `process_adf`. Disabled boxes are skipped.
- `process_adf` is the commit step: `Insertbarcode(shift, model, SC, CRCIS, CISM, ADF, name, line)` → `reload(reloadsql, datagrid1)` → `totalToday()` → clear boxes → refocus first enabled box.
- `Insertbarcode` ([[Modules#dbconn]]) rejects the row if **any** non-empty SC, CISM or ADF already exists in `barcodes` (CRCIS is not checked), else inserts with `judgement='G'`.

## FVI-only mode

`txt_fvi` is a separate path: `checkcode(text, "fvi", 3)` → `InsertbarcodeFVI` into `barcodes_fvi` (duplicate check on FVI) → reload FVI grid. In [[Screens#set_input]], ticking FVI unticks all other serials, so a station is either "multi-serial" or "FVI-only".

`InsertbarcodeADF` / `barcodes_adf` exist in `dbconn` but **nothing calls them** — ADF is currently saved in the `barcodes` row.

## Shift logic (`getshift`)

- `DS` (day shift) from 07:00 to before 19:00, else `NS`.
- `datein` is the calendar date at scan time, so night-shift scans after midnight land on the next day — see [[Known-Issues]].

## Model text

`cmb_model.Text` is split on `:` and the first part upper-cased is stored as the model.
