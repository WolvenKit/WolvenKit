## 9.0.0 — 2026-09-06

**App**

* *Removed*: Legacy mesh bone rotation import has been removed, old exports pre 8.19.0 will need to be reexported. by @notaspirit
* *Removed*: Removed mod manager by @notaspirit
* *Added*: Template Service is now exposed to the WScript environment by @notaspirit
* *Added*: Scene Editor has a new 'Import Dialogue' button and popup in the Dialogue tab. It reads a json from the clipboard or a .json file, to import lines with all their properties, matching each line's speaker and addressee to the scene's actors by name. For use with CET mod Dialogue Browser. by @Akiway
* *Added*: After a successful update of the app using the build in updater the changelog is now shown by @notaspirit
* *Fixed*: Fixed an exception when trying to recalculate components on something that didn't have any. by @manavortex
* *Fixed*: Fixed an issue where very large projects would freeze the app on loading. Vastly improved project loading speeds. by @gistya
* *Fixed*: Fixed an issue where drag-and-drop would fail to work when dragging a single unselected file. Now the file with become selected by the action before you drop it. by @gistya
* *Fixed*: Fixed an issue where items added to the Project Explorer tree would not appear in proper order until project reload. Now, items will sort instantly, and files will always be displayed below folders for ease of navigation (this was always the intended behavior). by @gistya
* *Fixed*: Fixed tab filters not working in Project Explorer flat tree mode ('archive', 'raw', 'resources'). by @gistya
* *Fixed*: Project Explorer will now show Loading... pane earlier in the process for smoother UX, and during long batch operations when the tree should not be interacted with. by @gistya
* *Fixed*: Fixed numerous bugs with drag-and-drop within WolvenKit's ProjectExplorer file tree. by @gistya
* *Fixed*: Fixed exporting all sounds from OpusPaks skipping the last pak, leaving some sounds unexported. by @Zhincore
* *Fixed*: Fixed opus export and import writing .wav files to a wrong path when the used directory contains 'opus' in its name. by @Zhincore
* *Fixed*: Fixed an issue where the app could create a new copy of a file when saving if the underlying file had been moved before the document had unsaved changes. Added warning logs for situations where a document is moved while it has unsaved changes, clarifying some existing behavior. by @gistya
* *Changed*: Updates WolvenKit to .NET SDK 10 targeting Windows 11. Includes security-related NuGet dependency changes. by @gistya
* *Changed*: Better user feedback for 'force LOD level 0' and 'regenerate resolved dependencies'. by @manavortex
* *Changed*: Updated the version of WolvenKit's SyncFusion dependencies to 34.2.2. by @gistya
* *Changed*: CVM: restored forced search initialization on shift+enter by @manavortex
* *Changed*: Archive loading now starts at app launch and finishes much faster, speeding up the time to start working on a project. by @gistya
* *Feature*: Typing in the filter field of ProjectExplorer now updates automatically when stop typing instead of requiring return to be pressed. by @Ametis81

**CLI**

* *Removed*: Legacy mesh bone rotation import has been removed, old exports pre 8.19.0 will need to be reexported. by @notaspirit
* *Fixed*: Fixed exporting all sounds from OpusPaks skipping the last pak, leaving some sounds unexported. by @Zhincore
* *Fixed*: Fixed opus export and import writing .wav files to a wrong path when the used directory contains 'opus' in its name. by @Zhincore
* *Fixed*: Build command will will now correctly pack the source archive subfolder instead of the root folder. by @poirierlouis
* *Changed*: Updates WolvenKit to .NET SDK 10 targeting Windows 11. Includes security-related NuGet dependency changes. by @gistya

**Nuget Packages**

* *Removed*: Removed previously deprecated file path validaton methods, use FilePathValidationTools or the equivalent StringPathExtnesions methods instead by @notaspirit
* *Removed*: Previously deprecated RedTypeFactory has been removed, use RedTypeManager instead. by @notaspirit
* *Removed*: Legacy mesh bone rotation import has been removed, old exports pre 8.19.0 will need to be reexported. by @notaspirit
* *Added*: Template Service is now exposed to the WScript environment by @notaspirit
* *Fixed*: Fixed exporting all sounds from OpusPaks skipping the last pak, leaving some sounds unexported. by @Zhincore
* *Fixed*: Fixed opus export and import writing .wav files to a wrong path when the used directory contains 'opus' in its name. by @Zhincore
* *Fixed*: ModTools.Build() in ModKit.RED4 will now correctly pack the source archive subfolder instead of the root folder. by @poirierlouis
* *Changed*: Updates WolvenKit to .NET SDK 10 targeting Windows 11. Includes security-related NuGet dependency changes. by @gistya
* *Breaking*: WolvenKit.Modkit: ScriptFunctions now depends on RedTypeTemplateService by @notaspirit


---

## 8.20.0 — 2026-08-06

**App**

* *Added*: Implemented 'flatten mi chain' feature: pull all properties into the current material, then set baseMaterial to root of chain by @manavortex
* *Added*: added option to expand mesh appearances (ArchiveXL undymanify) by @manavortex
* *Added*: A templater is now available which fixes insensible default values for some created types,
 and enables the use of custom templates improving reusability. by @notaspirit
* *Added*: Added comment boxes to quest and scene editors by @misterchedda
* *Added*: Quest and scene graphs now use a searchable action palette for graph actions, categorized node creation, and template selection by @misterchedda
* *Added*: Mesh preview now includes a disclaimer about the possibility of incorrect materials during preview. by @notaspirit
* *Fixed*: Populate className and fileEntryIndex automatically from journal's realPath dropdown by @misterchedda
* *Fixed*: Recalculating sockets on questScene nodes now generates INT and RET socket pairs from scene interruption scenario names and preserves existing Prefetch sockets by @misterchedda
* *Fixed*: UseWorkspot nodes now generate function appropriate sockets in questphase and scene graphs by @misterchedda
* *Fixed*: Add actor button in scene editor will now recalculate all instances of the player's scnActorId and scnPerformerId automatically by @misterchedda
* *Fixed*: Arrange Items preserves node placement within comment boxes, and nested comments can be selected correctly by @misterchedda
* *Fixed*: Scene section durations are no longer adjusted automatically when selecting sections or moving timeline events, and can now be changed explicitly using the timeline marker or Extend to event end action by @misterchedda
* *Fixed*: Fixed an exception when trying to display a root entity preview with dynamic substitution. by @manavortex
* *Fixed*: Improved long-session quest and scene graph performance by cleaning up graph resources when they are no longer in use by @misterchedda
* *Fixed*: Fixed incorrect handling of visibility tag by generated ArchiveXL items. by @manavortex
* *Fixed*: Fixed an issue where mousewheel scrolling would not work with the cursor inside the pinned projects area. Now you can see more pinned projects and scroll all projects independently of the rest of the welcome screen. by @gistya
* *Fixed*: Fixed an issue where previously open documents would not reopen for projects that use the default layout. by @gistya
* *Changed*: Re-named 'add files' to 'generate files' by @manavortex
* *Changed*: Removed obsolete checkbox from prop generator by @manavortex
* *Changed*: Updated wiki link in prop generator by @manavortex
* *Changed*: Improved quest phase graph loading performance by avoiding eager loading of external phase resources by @misterchedda
* *Changed*: Improved quest and scene graph document closing performance by @misterchedda
* *Changed*: More node graph details for Combat, MovePuppet, VoicesetManager. Output node also correctly shows its type now by @misterchedda
* *Changed*: EventManager and InteractiveObjectManager graph nodes now show additional node details by @misterchedda
* *Change*: parametersBuffer will no longer be hidden if it's not empty by @manavortex
* *Change*: partsMasks will now be hidden if it's empty by @manavortex

**Nuget Packages**

* *Deprecated*: All functionality of ModKit.RED4.RedTypeFactory has been moved to RED4.Types.RedTypeManager. by @notaspirit
* *Added*: A templater is now available which fixes insensible default values for some created types,
 and enables the use of custom templates improving reusability. by @notaspirit


---

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
