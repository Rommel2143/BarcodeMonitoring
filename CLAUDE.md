# Barcode Monitoring

VB.NET WinForms (.NET Framework 4.7.2) app: operators scan part serials (SC, CRCIS, CISM, ADF, FVI) into a local SQLite `database.db`; records can be judged and exported to Excel. Source is in `Barcode Monitoring/`.

## Every session: graph + vault first

1. **Project context** — read `docs/INDEX.md` (Obsidian vault) and follow its links: `Architecture`, `Scan-Workflow`, `Database-Schema`, `Screens`, `Modules`, `Known-Issues`.
2. **Code/architecture questions** — query the graph before grepping:
   - `graphify query "<question>"` (add `--dfs` to trace one path, `--budget N` for more)
   - `graphify explain "<symbol>"`, `graphify path "A" "B"`, `graphify affected "<symbol>"`
   - Overview: `graphify-out/GRAPH_REPORT.md`
3. **Known gap**: the VB AST extractor does not link form code to global `Module` members (e.g. `Insertbarcode`, `reload`, `getLine` in `dbconn.vb`). For those, use `docs/Modules.md` and `docs/Database-Schema.md`, then grep.

## After changing things

- Code changed → run `graphify update .` (AST only, fast, no LLM).
- Vault notes changed or added → link them from `docs/INDEX.md`, then run `/graphify . --update`.
- Refresh generated notes/viz when the graph changes a lot: `graphify export obsidian --dir docs/graph` and `graphify export html`.
- Record new bugs in `docs/Known-Issues.md`; keep `docs/Database-Schema.md` in sync with any SQL change.
- `docs/graph/` is generated (ignored via `.graphifyignore`) — don't hand-edit it.

## Build

`MSBuild "Barcode Monitoring/Barcode Monitoring.vbproj"` (VS 2022/18 MSBuild; NuGet `packages/` restored locally). No tests exist. `database.db` beside the exe is created/upgraded on startup by `dbconn.EnsureDatabase()`; schema changes go in `SchemaTables` there (add columns, never drop) so old pasted databases keep working.

## Conventions

- Dates are stored as `yyyy-MM-dd`, times as `HH:mm:ss` (`dbconn.NowTime()`). `UpgradeTimeFormat()` pads legacy `HH:mm` rows on startup — keep pasted old databases working.
- Use parameterized SQL (`@param`) in new code; much existing code concatenates strings (see Known-Issues).
- Don't hand-edit `*.Designer.vb` or `.resx` files except through the WinForms designer.
