---
tags: [modules]
---
# Shared Modules

Back to [[INDEX]]. VB `Module`s are global: their public members are called from any form without qualification, which is why the AST graph does not draw these call edges (see [[Graphify-Workflow#Known graph gaps]]).

## dbconn
File `dbconn.vb`. Globals: `con` (SQLiteConnection), `da`, `dr`, `dt` (mostly unused).

| Member | SQL / effect | Called from |
|---|---|---|
| `InsertData(model, sc, crcis, cism, adf, fvi)` | INSERT INTO model | create_model |
| `InsertLine(line)` | INSERT INTO LINE | — (unused) |
| `deleteModel(model)` | DELETE FROM MODEL (string-concatenated) | create_model |
| `deleteLine(text)` | DELETE FROM LINE WHERE line='test' (ignores arg) | — (unused) |
| `getLine()` | first row of LINE | barcode_scan, create_line |
| `Insertbarcode(shift, model, sc, crcis, cism, adf, name, line)` | dup check on SC/CISM/ADF, INSERT INTO barcodes | barcode_scan.process_adf |
| `InsertbarcodeFVI(shift, model, fvi, name, line)` | dup check, INSERT INTO barcodes_fvi | barcode_scan.txt_fvi_KeyDown |
| `InsertbarcodeADF(shift, model, adf, name, line)` | dup check, INSERT INTO barcodes_adf | — (unused) |
| `EnsureDatabase()` | create db file, missing tables/columns, seed LINE/input_set/judgement | Mainframe_Load |
| `NowTime()` | current time as `HH:mm:ss` (const `TimeFormat`) | all three Insertbarcode* |
| `UpgradeTimeFormat()` | pads legacy `HH:mm` timein rows to `HH:mm:00` in barcodes / barcodes_fvi / barcodes_adf | Mainframe_Load |
| `reload(sql, grid)` | fill DataTable, bind grid; errors → `show_error` | barcode_scan, create_model, viewrecords |
| `cmb_display(sql, combo)` | fill ComboBox items | barcode_scan |

Tables: [[Database-Schema]].

## frameModules
`display_inMain(form)` — clears `Mainframe.Panel1` and embeds the form. `display_inSub(form)` — embeds into `subframe.Panel1` (does not clear). See [[Architecture]].

## SnackbarModule
`show_error(text, sound)` — shows a borderless top-most bar 90px from the top of the primary screen for 3 s, plays `errorsound` (1) or `duplicate` (2) from `My.Resources`, or nothing (0). Currently only `reload` calls it (sound 0); the duplicate/insert paths use `MessageBox` instead.

## exportExcel
`exporttoExcel(grid)` — copies visible grid columns/rows into a DataTable, asks for a path with `SaveFileDialog`, writes `Sheet1` with ClosedXML. Used by create_model and viewrecords.
