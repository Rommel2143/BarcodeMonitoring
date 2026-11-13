---
type: community
members: 27
---

# Records Review and Judgement

**Members:** 27 nodes

## Members
- [[Bug 11 Judgement change detection uses uninitialised Cell.Tag]] - concept - docs/Known-Issues.md
- [[Bug 1 Judgement saves go to wrong table (rad always 0)]] - concept - docs/Known-Issues.md
- [[Bug 8 viewrecords.adf() searches FVI column on barcodes_adf]] - concept - docs/Known-Issues.md
- [[Bug 9 others() repeats SC, omits ADF; LIKE without wildcards]] - concept - docs/Known-Issues.md
- [[Forms as VB default instances (singleton screens)]] - rationale - docs/Architecture.md
- [[Guna2Button2.Click]] - code
- [[Guna2Button2_Click()]] - code - Barcode Monitoring/set_input.vb
- [[Guna2Button2_Click()_1]] - code - Barcode Monitoring/viewrecords.vb
- [[Guna2RadioButton1_CheckedChanged()]] - code - Barcode Monitoring/viewrecords.vb
- [[Guna2RadioButton2_CheckedChanged()]] - code - Barcode Monitoring/viewrecords.vb
- [[Guna2RadioButton3_CheckedChanged()]] - code - Barcode Monitoring/viewrecords.vb
- [[InitializeSaveButton()]] - code - Barcode Monitoring/viewrecords.vb
- [[SQL injection via string concatenation]] - concept - docs/Known-Issues.md
- [[SaveJudgementChanges()]] - code - Barcode Monitoring/viewrecords.vb
- [[SetupJudgementComboBox()]] - code - Barcode Monitoring/viewrecords.vb
- [[UpdateJudgementInDatabase()]] - code - Barcode Monitoring/viewrecords.vb
- [[adf()]] - code - Barcode Monitoring/viewrecords.vb
- [[btnSaveChanges_Click()]] - code - Barcode Monitoring/viewrecords.vb
- [[btnsavechanges.Click]] - code
- [[deleteModel()]] - code - docs/Modules.md
- [[fvi()]] - code - Barcode Monitoring/viewrecords.vb
- [[judgement table]] - concept - docs/Database-Schema.md
- [[others()]] - code - Barcode Monitoring/viewrecords.vb
- [[rad]] - code - Barcode Monitoring/viewrecords.vb
- [[rad_fvi.CheckedChanged]] - code
- [[rad_sc.CheckedChanged]] - code
- [[viewrecords]] - code - Barcode Monitoring/viewrecords.vb

## Live Query (requires Dataview plugin)

```dataview
TABLE source_file, type FROM #community/Records_Review_and_Judgement
SORT file.name ASC
```

## Connections to other communities
- 10 edges to [[_COMMUNITY_DB Access Layer (dbconn)]]
- 3 edges to [[_COMMUNITY_Barcode Scan Workflow]]
- 3 edges to [[_COMMUNITY_Model Registry Logic]]
- 1 edge to [[_COMMUNITY_Input Station Settings]]

## Top bridge nodes
- [[deleteModel()]] - degree 4, connects to 3 communities
- [[viewrecords]] - degree 18, connects to 2 communities
- [[SQL injection via string concatenation]] - degree 5, connects to 2 communities
- [[others()]] - degree 6, connects to 1 community
- [[fvi()]] - degree 5, connects to 1 community