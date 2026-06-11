## 8.18.1 — 2026-06-08

**New Contributor**
* @gistya made their first contribution in https://github.com/WolvenKit/WolvenKit/pull/2937

**App**

* *Removed*: WKit will no longer try to update dynamic paths (breaking them in the process), and instead warn about them. by @manavortex
* *Fixed*: Fixed 'create item codes from yaml' by @manavortex
* *Fixed*: Fixed material loading in preview window with 'Generate Materials' button action by @Ametis81
* *Fixed*: Better error message if project fails to load because .cpmodproj is broken by @manavortex
* *Fixed*: When generating a radio, the folder in resources will now be created by @manavortex
* *Fixed*: 'Copy materials from other mesh' now reliably works for multiselect by @manavortex
* *Fixed*: Improved performance when adding thousands of game files to a mod by @gistya
* *Fixed*: Increased performance of JSON imports. by @gistya


---

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
