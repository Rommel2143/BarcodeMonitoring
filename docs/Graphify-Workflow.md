---
tags: [tooling, graphify]
---
# Graphify Workflow

Back to [[INDEX]]. graphify turns the repo into a knowledge graph in `graphify-out/`. The VB.NET grammar comes from the `vbnet` extra: `uv tool install --upgrade "graphifyy[vbnet]"`.

## Ask the graph first

```bash
graphify query "how does a scan get saved"      # BFS context
graphify query "..." --dfs                       # trace one path
graphify explain "Insertbarcode"                 # node + neighbours
graphify path "barcode_scan" "barcodes"          # shortest path
graphify affected "getLine"                      # what depends on X
graphify god-nodes                               # hubs
```

Then open the vault note named in the answer for the human-written context.

## Keep it fresh

- After code edits: `graphify update .` (AST only, no LLM, seconds).
- After commits: the post-commit hook (`graphify hook install`) rebuilds automatically.
- After editing these vault notes: run `/graphify . --update` in Claude Code so the semantic pass re-reads changed docs.
- Re-export the per-symbol notes: `graphify export obsidian --dir docs/graph` and `graphify export html`.

## Files

| Path | Purpose |
|---|---|
| `graphify-out/graph.json` | the graph |
| `graphify-out/GRAPH_REPORT.md` | communities, god nodes, gaps |
| `graphify-out/graph.html` | interactive view |
| `graphify-out/.graphify_labels.json` | community names |
| `docs/graph/` | generated Obsidian notes (ignored by graphify via `.graphifyignore`) |

## Known graph gaps

- The VB AST extractor does not resolve calls into global `Module` members, and emits no member nodes for `dbconn.vb`. These docs (merged in by the semantic pass) supply those links: see [[Modules#dbconn]] and [[Database-Schema]].
- `*.Designer.vb` files produce many control nodes (labels, panels) — the "UI Layout" communities. Ignore them for logic questions.
- `.wav` files are sound effects, not transcribed.
