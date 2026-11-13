---
type: community
members: 42
---

# Barcode Scan Workflow

**Members:** 42 nodes

## Members
- [[Bug 10 cmb_display never closes con]] - concept - docs/Known-Issues.md
- [[Bug 3 Stale today queries after midnight]] - concept - docs/Known-Issues.md
- [[Bug 4 Night-shift scans after 0000 get next datein]] - concept - docs/Known-Issues.md
- [[Bug 5 checkcode crash on short input]] - concept - docs/Known-Issues.md
- [[FVI-only scan mode]] - rationale - docs/Scan-Workflow.md
- [[MODEL table]] - concept - docs/Database-Schema.md
- [[Multi-serial scan chain (SC - CRCIS - CISM - ADF)]] - rationale - docs/Scan-Workflow.md
- [[Serial prefix validation against MODEL]] - rationale - docs/Scan-Workflow.md
- [[Shift logic (DS 0700-1900, else NS)]] - rationale - docs/Scan-Workflow.md
- [[Timer1.Tick]] - code
- [[Timer1_Tick()]] - code - Barcode Monitoring/barcode_scan.vb
- [[barcode_scan]] - code - Barcode Monitoring/barcode_scan.vb
- [[barcode_scan_Load()]] - code - Barcode Monitoring/barcode_scan.vb
- [[checkcode()]] - code - Barcode Monitoring/barcode_scan.vb
- [[cleartext()]] - code - Barcode Monitoring/barcode_scan.vb
- [[cmb_display()]] - code - docs/Modules.md
- [[cmb_model.Click]] - code
- [[cmb_model.SelectedIndexChanged]] - code
- [[cmb_model_Click()]] - code - Barcode Monitoring/barcode_scan.vb
- [[cmb_model_SelectedIndexChanged()]] - code - Barcode Monitoring/barcode_scan.vb
- [[getshift()]] - code - Barcode Monitoring/barcode_scan.vb
- [[process_adf()]] - code - Barcode Monitoring/barcode_scan.vb
- [[process_cism()]] - code - Barcode Monitoring/barcode_scan.vb
- [[process_crcis()]] - code - Barcode Monitoring/barcode_scan.vb
- [[process_sc()]] - code - Barcode Monitoring/barcode_scan.vb
- [[reloadadf]] - code - Barcode Monitoring/barcode_scan.vb
- [[reloadfvi]] - code - Barcode Monitoring/barcode_scan.vb
- [[reloadsql]] - code - Barcode Monitoring/barcode_scan.vb
- [[totalToday()]] - code - Barcode Monitoring/barcode_scan.vb
- [[txt_adf.KeyDown]] - code
- [[txt_adf_KeyDown()]] - code - Barcode Monitoring/barcode_scan.vb
- [[txt_cism.KeyDown]] - code
- [[txt_cism_KeyDown()]] - code - Barcode Monitoring/barcode_scan.vb
- [[txt_crcis.KeyDown]] - code
- [[txt_crcis_KeyDown()]] - code - Barcode Monitoring/barcode_scan.vb
- [[txt_fvi.KeyDown]] - code
- [[txt_fvi_KeyDown()]] - code - Barcode Monitoring/barcode_scan.vb
- [[txt_model_KeyDown()]] - code - Barcode Monitoring/barcode_scan.vb
- [[txt_name.TextChanged]] - code
- [[txt_sc.KeyDown]] - code
- [[txt_sc.TextChanged]] - code
- [[txt_sc_TextChanged()]] - code - Barcode Monitoring/barcode_scan.vb

## Live Query (requires Dataview plugin)

```dataview
TABLE source_file, type FROM #community/Barcode_Scan_Workflow
SORT file.name ASC
```

## Connections to other communities
- 11 edges to [[_COMMUNITY_DB Access Layer (dbconn)]]
- 3 edges to [[_COMMUNITY_Input Station Settings]]
- 3 edges to [[_COMMUNITY_Records Review and Judgement]]
- 2 edges to [[_COMMUNITY_Model Registry Logic]]
- 1 edge to [[_COMMUNITY_Obsidian Vault Docs]]

## Top bridge nodes
- [[barcode_scan]] - degree 26, connects to 4 communities
- [[MODEL table]] - degree 7, connects to 3 communities
- [[barcode_scan_Load()]] - degree 6, connects to 3 communities
- [[checkcode()]] - degree 10, connects to 1 community
- [[process_adf()]] - degree 9, connects to 1 community