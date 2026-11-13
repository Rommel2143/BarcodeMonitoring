---
tags: [issues, review]
---
# Known Issues

Back to [[INDEX]]. Found by reading the code on 2026-11-06; none are fixed yet. File:line refs are to `Barcode Monitoring/`.

## Bugs

1. **Judgement saves go to the wrong table** — `viewrecords.rad` is only set in `Guna2RadioButton2_CheckedChanged`, which has no `Handles` clause, so `rad` is always 0 and `SaveJudgementChanges` always updates `barcodes`, even when FVI records are shown (`viewrecords.vb`).
2. **set_input loads ADF into the FVI box** — `chk_fvi.Checked = Convert.ToBoolean(dr("ADF"))` overwrites FVI; `chk_adf` is never loaded (`set_input.vb` getSet).
3. **Stale "today" queries** — `reloadsql`/`reloadfvi`/`reloadadf` in `barcode_scan.vb` embed the date when the form is created; after midnight the grid keeps showing the previous day.
4. **Night-shift date** — NS scans after 00:00 get the next calendar `datein`, splitting one shift across two dates.
5. **`checkcode` crash on short input** — `text.Substring(0, number)` throws when the scanned text is shorter than 2–3 chars (caught, but shows an exception message).
6. **CRCIS not duplicate-checked** in `Insertbarcode`.
7. **`deleteLine` ignores its argument** (`WHERE line = 'test'`). Unused today.
8. `viewrecords.adf()` searches `FVI LIKE …` on `barcodes_adf` (wrong column); `adf()` is unreachable anyway.
9. `others()` search repeats `SC LIKE` and omits `ADF`; searches use `LIKE 'text'` with no wildcards (exact match).
10. `cmb_display` never closes `con`.
11. Judgement change detection compares to `Cell.Tag`, which is never initialised, so every row is re-saved.

## Security / robustness

- **SQL injection** via string concatenation: `deleteModel`, `create_line.UpdateLine`, `viewrecords` search/date queries, `checkcode` column name (internal only).
- Single global connection shared by all forms; no transactions.
- ~~No schema creation/migration~~ — fixed 2026-11-06 by `EnsureDatabase()`.
- EF6 packages referenced but unused (bloat).

Related: [[Database-Schema]], [[Scan-Workflow]].
