---
tags: [architecture]
---
# Architecture

Back to [[INDEX]].

## Shape

A single-project WinForms app with no layering beyond "forms" and "global modules". Every form talks to SQLite directly or through the shared module [[Modules#dbconn|dbconn]], which owns one global `SQLiteConnection` (`con`).

```
My.MyApplication (Application.Designer.vb)
  └─ MainForm = Mainframe
       └─ Mainframe_Load → display_inMain(subframe)        [frameModules]
            └─ subframe (top bar + hamburger menu)
                 ├─ "Barcode Scanning" → display_inSub(barcode_scan)
                 ├─ "View Records"     → display_inSub(viewrecords)
                 └─ "Settings" submenu
                      ├─ "Model"     → create_model.Show()   (separate window)
                      ├─ "Line"      → create_line.Show()    (separate window)
                      └─ "Set Input" → set_input.Show()      (separate window)
```

- `display_inMain` / `display_inSub` (in `frameModules.vb`) set `TopLevel = False` and add the form into `Mainframe.Panel1` / `subframe.Panel1`. Forms are the VB **default instances** (e.g. `barcode_scan` used as an object), so each screen is effectively a singleton.
- Settings screens (`create_model`, `create_line`, `set_input`) open as normal floating windows.

## Layers

| Layer | Files | Notes |
|---|---|---|
| Shell / navigation | `Mainframe.vb`, `subframe.vb`, `frameModules.vb` | See [[Screens#Mainframe]] and [[Screens#subframe]] |
| Screens | `barcode_scan.vb`, `viewrecords.vb`, `create_model.vb`, `create_line.vb`, `set_input.vb` | Logic lives in code-behind; `*.Designer.vb` is generated layout |
| Data access | `dbconn.vb` (+ inline SQL in forms) | See [[Database-Schema]] |
| Feedback | `SnackbarModule.vb`, `Resources/*.wav` | Toast bar + error/duplicate sounds |
| Export | `exportExcel.vb` | DataGridView → `.xlsx` via ClosedXML |

## Tech stack

- .NET Framework 4.7.2, VB.NET, WinForms (`OutputType=WinExe`).
- NuGet (`packages.config`): Guna.UI2.WinForms, System.Data.SQLite (+EF6/Linq — EF is configured in `App.config` but **not used** in code), ClosedXML, DocumentFormat.OpenXml.
- Embedded resources: `duplicate.wav`, `errorsound.wav` via `My.Resources`.

## Cross-cutting conventions

- Every DB helper does `con.Close(); con.Open()` … `Finally con.Close()` on the shared connection.
- Errors are shown with `MessageBox.Show` (or `show_error` snackbar in `reload`).
- Dates stored as text `yyyy-MM-dd`, times as `HH:mm:ss` (`dbconn.NowTime()`, invariant culture). Older databases used `HH:mm`; `UpgradeTimeFormat()` runs in `Mainframe_Load` and pads those rows with `:00`, so a pasted old `database.db` is upgraded on first start.

Related: [[Scan-Workflow]], [[Modules]], [[Known-Issues]].
