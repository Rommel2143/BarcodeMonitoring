---
source_file: "docs/Database-Schema.md"
type: "concept"
community: "DB Access Layer (dbconn)"
tags:
  - graphify/concept
  - graphify/EXTRACTED
  - community/DB_Access_Layer_dbconn
---

# barcodes_fvi table

## Connections
- [[InsertbarcodeFVI()]] - `writes` [EXTRACTED]
- [[UpdateJudgementInDatabase()]] - `writes` [INFERRED]
- [[UpgradeTimeFormat()]] - `writes` [EXTRACTED]
- [[database.db (SQLite)]] - `contains` [EXTRACTED]
- [[fvi()]] - `reads` [EXTRACTED]
- [[reloadfvi]] - `reads` [INFERRED]

#graphify/concept #graphify/EXTRACTED #community/DB_Access_Layer_dbconn