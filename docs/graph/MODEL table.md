---
source_file: "docs/Database-Schema.md"
type: "concept"
community: "Barcode Scan Workflow"
tags:
  - graphify/concept
  - graphify/EXTRACTED
  - community/Barcode_Scan_Workflow
---

# MODEL table

## Connections
- [[InsertData()]] - `writes` [EXTRACTED]
- [[Serial prefix validation against MODEL]] - `references` [EXTRACTED]
- [[checkcode()]] - `reads` [EXTRACTED]
- [[cmb_display()]] - `reads` [EXTRACTED]
- [[create_model]] - `reads` [EXTRACTED]
- [[database.db (SQLite)]] - `contains` [EXTRACTED]
- [[deleteModel()]] - `writes` [EXTRACTED]

#graphify/concept #graphify/EXTRACTED #community/Barcode_Scan_Workflow