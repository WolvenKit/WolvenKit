## 8.18.0 — 2026-05-04

**App**

* *Added*: Import and export flow is now also available in the right click menu by @notaspirit
* *Added*: Sleeves and hair substitution for ArchiveXL by @manavortex
* *Fixed*: AMM prop generation now correctly reads mesh appearances by @manavortex
* *Fixed*: Delete unused materials now uses correct index by @manavortex
* *Fixed*: ArchiveXL item generator will now successfully handle component name uniqueness - various robustness fixes by @manavortex
* *Fixed*: Nested quest phase nodes no longer lose internal socket connections after paste/duplicate operations by @misterchedda
* *Changed*: Filepath handling has been adjusted to handle os and archive paths according to their respective specs. Archive paths are now stricter and os paths looser than the previous combined implementation. by @notaspirit

**CLI**

* *Added*: Sleeves and hair substitution for ArchiveXL by @manavortex
* *Changed*: Filepath handling has been adjusted to handle os and archive paths according to their respective specs. Archive paths are now stricter and os paths looser than the previous combined implementation. by @notaspirit

**Nuget Packages**

* *Deprecated*: SanitizePath in FileHelper, ToFilePath, ToFileName, IsSaneFilePath, and SanitizeFilePath in StringPathExtensions are now deprecated. Use new archive or os path methods in StringPathExtensions and in FilePathValidation tools instead. by @notaspirit
* *Added*: Sleeves and hair substitution for ArchiveXL by @manavortex
* *Changed*: Filepath handling has been adjusted to handle os and archive paths according to their respective specs. Archive paths are now stricter and os paths looser than the previous combined implementation. by @notaspirit
