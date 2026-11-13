---
source_file: "Barcode Monitoring/barcode_scan.vb"
type: "code"
community: "Barcode Scan Workflow"
location: "L145"
tags:
  - graphify/code
  - graphify/EXTRACTED
  - community/Barcode_Scan_Workflow
---

# process_adf()

## Connections
- [[Insertbarcode()]] - `calls` [EXTRACTED]
- [[Multi-serial scan chain (SC - CRCIS - CISM - ADF)]] - `references` [EXTRACTED]
- [[barcode_scan]] - `method` [EXTRACTED]
- [[cleartext()]] - `calls` [EXTRACTED]
- [[process_cism()]] - `calls` [EXTRACTED]
- [[process_sc()]] - `calls` [EXTRACTED]
- [[reload()]] - `calls` [EXTRACTED]
- [[totalToday()]] - `calls` [EXTRACTED]
- [[txt_adf_KeyDown()]] - `calls` [EXTRACTED]

#graphify/code #graphify/EXTRACTED #community/Barcode_Scan_Workflow