---
type: community
members: 46
---

# DB Access Layer (dbconn)

**Members:** 46 nodes

## Members
- [[AST gap VB Module member calls unresolved]] - rationale - docs/Graphify-Workflow.md
- [[Bug 6 CRCIS not duplicate-checked]] - concept - docs/Known-Issues.md
- [[Bug 7 deleteLine ignores its argument]] - concept - docs/Known-Issues.md
- [[Datetime storage convention (yyyy-MM-dd, HHmmss)]] - rationale - docs/Architecture.md
- [[Guna.UI2.WinForms]] - code
- [[InsertData()]] - code - docs/Modules.md
- [[InsertLine()]] - code - docs/Modules.md
- [[Insertbarcode()]] - code - docs/Modules.md
- [[InsertbarcodeADF()]] - code - docs/Modules.md
- [[InsertbarcodeFVI()]] - code - docs/Modules.md
- [[LINE table]] - concept - docs/Database-Schema.md
- [[Mainframe]] - code - Barcode Monitoring/Mainframe.vb
- [[Mainframe.vb]] - code - Barcode Monitoring/Mainframe.vb
- [[Mainframe_Load()]] - code - Barcode Monitoring/Mainframe.vb
- [[No schema creationmigration (missing DDL)]] - concept - docs/Known-Issues.md
- [[NowTime()]] - code - docs/Modules.md
- [[ShowSnackbar()]] - code - Barcode Monitoring/SnackbarModule.vb
- [[Single global connection, no transactions]] - concept - docs/Known-Issues.md
- [[SnackbarModule]] - code - Barcode Monitoring/SnackbarModule.vb
- [[SnackbarModule.vb]] - code - Barcode Monitoring/SnackbarModule.vb
- [[System.Data.SQLite]] - code
- [[System.Threading]] - code
- [[UpdateLine()]] - code - Barcode Monitoring/create_line.vb
- [[UpgradeTimeFormat()]] - code - docs/Modules.md
- [[barcode_scan.vb]] - code - Barcode Monitoring/barcode_scan.vb
- [[barcodes table]] - concept - docs/Database-Schema.md
- [[barcodes_adf table]] - concept - docs/Database-Schema.md
- [[barcodes_fvi table]] - concept - docs/Database-Schema.md
- [[btn_save.Click]] - code
- [[btn_save_Click()]] - code - Barcode Monitoring/create_line.vb
- [[btn_save_Click()_1]] - code - Barcode Monitoring/create_model.vb
- [[con (SQLiteConnection)]] - code - docs/Modules.md
- [[create_line]] - code - Barcode Monitoring/create_line.vb
- [[create_line.vb]] - code - Barcode Monitoring/create_line.vb
- [[database.db (SQLite)]] - concept - docs/Database-Schema.md
- [[dbconn.vb]] - code - Barcode Monitoring/dbconn.vb
- [[deleteLine()]] - code - docs/Modules.md
- [[display_inMain()]] - code - Barcode Monitoring/frameModules.vb
- [[display_inSub()]] - code - Barcode Monitoring/frameModules.vb
- [[frameModules]] - code - Barcode Monitoring/frameModules.vb
- [[frameModules.vb]] - code - Barcode Monitoring/frameModules.vb
- [[getLine()]] - code - docs/Modules.md
- [[reload()]] - code - docs/Modules.md
- [[set_input.vb]] - code - Barcode Monitoring/set_input.vb
- [[show_error()]] - code - Barcode Monitoring/SnackbarModule.vb
- [[viewrecords.vb]] - code - Barcode Monitoring/viewrecords.vb

## Live Query (requires Dataview plugin)

```dataview
TABLE source_file, type FROM #community/DB_Access_Layer_dbconn
SORT file.name ASC
```

## Connections to other communities
- 11 edges to [[_COMMUNITY_Barcode Scan Workflow]]
- 10 edges to [[_COMMUNITY_Records Review and Judgement]]
- 4 edges to [[_COMMUNITY_Model Registry Logic]]
- 2 edges to [[_COMMUNITY_Input Station Settings]]
- 1 edge to [[_COMMUNITY_Obsidian Vault Docs]]

## Top bridge nodes
- [[dbconn.vb]] - degree 16, connects to 3 communities
- [[database.db (SQLite)]] - degree 9, connects to 3 communities
- [[reload()]] - degree 7, connects to 3 communities
- [[barcodes_fvi table]] - degree 6, connects to 2 communities
- [[barcodes table]] - degree 6, connects to 2 communities