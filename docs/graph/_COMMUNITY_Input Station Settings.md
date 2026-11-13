---
type: community
members: 18
---

# Input Station Settings

**Members:** 18 nodes

## Members
- [[Bug 2 set_input loads ADF into FVI box]] - concept - docs/Known-Issues.md
- [[Guna2CheckBox1_CheckedChanged()]] - code - Barcode Monitoring/set_input.vb
- [[Guna2Panel1.Paint]] - code
- [[Guna2Panel1_Paint()]] - code - Barcode Monitoring/set_input.vb
- [[chk_adf.CheckedChanged]] - code
- [[chk_adf_CheckedChanged()]] - code - Barcode Monitoring/set_input.vb
- [[chk_cism.CheckedChanged]] - code
- [[chk_cism_CheckedChanged()]] - code - Barcode Monitoring/set_input.vb
- [[chk_cr.CheckedChanged]] - code
- [[chk_cr_CheckedChanged()]] - code - Barcode Monitoring/set_input.vb
- [[chk_fvi.CheckedChanged]] - code
- [[chk_sc.CheckedChanged]] - code
- [[chk_sc_CheckedChanged()]] - code - Barcode Monitoring/set_input.vb
- [[getSet()]] - code - Barcode Monitoring/barcode_scan.vb
- [[getSet()_1]] - code - Barcode Monitoring/set_input.vb
- [[input_set table]] - concept - docs/Database-Schema.md
- [[set_input_1]] - code - Barcode Monitoring/set_input.vb
- [[set_input_Load()]] - code - Barcode Monitoring/set_input.vb

## Live Query (requires Dataview plugin)

```dataview
TABLE source_file, type FROM #community/Input_Station_Settings
SORT file.name ASC
```

## Connections to other communities
- 3 edges to [[_COMMUNITY_Barcode Scan Workflow]]
- 2 edges to [[_COMMUNITY_DB Access Layer (dbconn)]]
- 1 edge to [[_COMMUNITY_Records Review and Judgement]]
- 1 edge to [[_COMMUNITY_Model Registry Logic]]

## Top bridge nodes
- [[set_input_1]] - degree 13, connects to 3 communities
- [[getSet()]] - degree 4, connects to 1 community
- [[input_set table]] - degree 4, connects to 1 community
- [[set_input_Load()]] - degree 3, connects to 1 community