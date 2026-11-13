---
tags: [build]
---
# Build and Deploy

Back to [[INDEX]].

## Build

- Open `Barcode Monitoring/Barcode Monitoring.sln` in Visual Studio (2019+), restore NuGet packages (`packages.config` → `packages/`, git-ignored), build.
- Command line: `msbuild "Barcode Monitoring\Barcode Monitoring.sln" /t:Restore;Build /p:Configuration=Release` (needs `nuget restore` first for packages.config projects).
- Target: .NET Framework 4.7.2, `WinExe`, root namespace `Barcode_Monitoring`. Icon: `INVENTORY (5).ico`.
- There are no automated tests in the repo.

## Runtime requirements

- `database.db` in the same folder as the exe. If it is missing, empty, or old, `EnsureDatabase()` creates/upgrades it on start (see [[Database-Schema#Auto-create / upgrade (`EnsureDatabase`)]]). The folder must be writable.
- System.Data.SQLite native interop (`SQLite.Interop.dll`, x86/x64 folders) copied by the `Stub.System.Data.SQLite.Core.NetFramework` package.
- On a new DB, set the line (Settings → Line) and register models (Settings → Model) before scanning.

## Config

- `App.config` registers EF6 providers (SqlServer, SQLite) and assembly binding redirects; EF itself is not used.
- `My.Settings` has no settings defined.
