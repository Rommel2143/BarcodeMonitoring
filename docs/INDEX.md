---
tags: [index, barcode-monitoring]
---
# Barcode Monitoring — Vault Index

Start here. This vault documents **Barcode Monitoring**, a Windows desktop app (VB.NET WinForms, .NET Framework 4.7.2) that production-line operators use to scan part serial barcodes, store them in a local SQLite database, catch duplicates and wrong-model parts, and later review, judge and export the records.

## Map of content

| Note | What it covers |
|---|---|
| [[Architecture]] | Layers, startup sequence, form hosting, tech stack |
| [[Scan-Workflow]] | Step-by-step scan → validate → insert flow, shift logic |
| [[Database-Schema]] | SQLite tables and which code reads/writes each |
| [[Screens]] | Every form: purpose, controls, handlers |
| [[Modules]] | Shared modules: `dbconn`, `frameModules`, `SnackbarModule`, `exportExcel` |
| [[Build-and-Deploy]] | Packages, build, runtime files (`database.db`, sounds) |
| [[Known-Issues]] | Bugs and risks found in code review |
| [[Graphify-Workflow]] | How to query and refresh the knowledge graph |
| [[graph/graph.canvas\|Graph canvas]] | Auto-generated graphify notes (one per code symbol) in `docs/graph/` |

## Quick facts

- Solution: `Barcode Monitoring/Barcode Monitoring.sln` → one project, `Barcode Monitoring.vbproj` (WinExe).
- Startup form: `Mainframe` (set in `My Project/Application.Designer.vb`), which hosts `subframe`, which hosts screens.
- Database: `database.db` next to the exe (`Application.StartupPath`), **not in the repo**.
- UI kit: Guna.UI2.WinForms 2.0.4.7. Excel: ClosedXML 0.105. DB: System.Data.SQLite 1.0.119.
- Serial types scanned: **SC, CRCIS ("CR CIS"), CISM, ADF, FVI**. What each acronym stands for is not stated in code — fill in here when known.

## Knowledge graph

- `graphify-out/GRAPH_REPORT.md` — communities, god nodes, gaps.
- `graphify-out/graph.html` — interactive graph (open in a browser).
- `graphify-out/graph.json` — queried by `graphify query|explain|path`.
