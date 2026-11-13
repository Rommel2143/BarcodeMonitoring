---
tags: [ui, forms]
---
# Screens

Back to [[INDEX]]. Each form = `<name>.vb` (logic) + `<name>.Designer.vb` (generated layout) + `<name>.resx`. All use Guna.UI2 controls.

## Mainframe
Startup form. `Mainframe_Load` → `display_inMain(subframe)`. Holds `Panel1` and `message_box`.

## subframe
Top bar with `btn_menu` (opens `btnmenu_strip` context menu) and `btn_profile`. Menu items:
- **Barcode Scanning** → `display_inSub(barcode_scan)`
- **View Records** → `display_inSub(viewrecords)`
- **Settings** → **Model** (`create_model`), **Line** (`create_line`), **Set Input** (`set_input`) — opened as floating windows.

## barcode_scan
Operator scan screen. Controls: `cmb_model`, `txt_name`, `panel_chk` with `txt_sc`, `txt_crcis`, `txt_cism`, `txt_adf`, `txt_fvi`; labels `lbl_date`, `lbl_shift`, `lbl_line`, `lbl_total`; `datagrid1` (today's scans); `Timer1`.
Full flow: [[Scan-Workflow]].

## viewrecords
Review screen. Date range `dtpicker1`–`dtpicker2`, `txt_search`, radio `rad_sc` ("SC, CRCIS, CISM, ADF") / `rad_fvi` ("FVI"), **View Data** (`Guna2Button2`), **Export** (`Guna2Button1` → `exporttoExcel`), **Save Changes** (`btnsavechanges`).
- `others()` queries `barcodes`, `fvi()` queries `barcodes_fvi`, `adf()` (unused) queries `barcodes_adf`.
- `SetupJudgementComboBox()` replaces the `judgement` column with a combo filled from table `judgement`.
- `SaveJudgementChanges()` loops rows and calls `UpdateJudgementInDatabase(id, judgement, remarks, table)`; table chosen by field `rad` — see bug in [[Known-Issues]].

## create_model
Register models and their serial prefix patterns. Save → `InsertData` → reload grid. Double-click a row → confirm → `deleteModel`. Export button → `exporttoExcel`.

## create_line
Shows current line; Save → `UpdateLine(new)` which updates `LINE` and **exits the application** so the new line is picked up on restart.

## set_input
Checkboxes `chk_sc`, `chk_cr`, `chk_cism`, `chk_adf`, `chk_fvi`. FVI is mutually exclusive with the rest. **Set** → `UPDATE input_set` → `barcode_scan.getSet()` → close.

Related: [[Architecture]], [[Database-Schema]].
