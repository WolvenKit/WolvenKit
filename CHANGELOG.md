## 8.19.0 — 2026-07-03

**App**

* *Added*: entAnimatedComponent: rig and animgraph now have dropdown support. by @manavortex
* *Added*: .mesh import can now add bones to meshes correctly by @DoctorPresto
* *Added*: Added a graph editor for .behavior files with basic tree editing actions. by @misterchedda
* *Fixed*: .ent preview fix (index out of bounds) by @Ametis81
* *Fixed*: Archive file path being incorrectly read from modlist.txt by @manavortex
* *Fixed*: .mesh export now correctly preserves bone rotations by caclulating them from boneRigMatrices. Import now recalculates boneRigMatrices, bonePositions and boneVertexEpsilons based on the data in the glb. by @DoctorPresto
* *Fixed*: Fixed the search function for quest and scene editor. The editor will now navigate through matching graph nodes. by @misterchedda
* *Fixed*: Prompt before opening external quest phase resources from phase nodes in the quest phase editor. by @misterchedda
* *Fixed*: 'clear all materials' will now properly refresh the view by @manavortex
* *Fixed*: 'Add items to atelier' will no longer break the atelier by @manavortex
* *Fixed*: Added missing quest graph node details for item, reward, and some condition and journal nodes. by @misterchedda
* *Changed*: Export / Import masks at their native resolution (low and high res masks with no pixel shift / offset due to scaling) by @Ametis81
* *Changed*: Inkatlas generator will now reliably overwrite already-existing files by @manavortex
* *Changed*: copy material from other mesh: will now set default filter if multiple meshes are in the same folder, and select textbox content if saved from previous run by @manavortex
* *Changed*: Project-wide scans will now ignore .tmp file extension by @manavortex

**CLI**

* *Added*: .mesh import can now add bones to meshes correctly by @DoctorPresto
* *Fixed*: Archive file path being incorrectly read from modlist.txt by @manavortex
* *Fixed*: .mesh export now correctly preserves bone rotations by caclulating them from boneRigMatrices. Import now recalculates boneRigMatrices, bonePositions and boneVertexEpsilons based on the data in the glb. by @DoctorPresto
* *Changed*: Export / Import masks at their native resolution (low and high res masks with no pixel shift / offset due to scaling) by @Ametis81

**Nuget Packages**

* *Added*: .mesh import can now add bones to meshes correctly by @DoctorPresto
* *Fixed*: Archive file path being incorrectly read from modlist.txt by @manavortex
* *Fixed*: .mesh export now correctly preserves bone rotations by caclulating them from boneRigMatrices. Import now recalculates boneRigMatrices, bonePositions and boneVertexEpsilons based on the data in the glb. by @DoctorPresto
* *Changed*: Export / Import masks at their native resolution (low and high res masks with no pixel shift / offset due to scaling) by @Ametis81


---

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
