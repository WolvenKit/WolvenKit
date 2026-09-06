## 9.0.0 — 2026-09-06

### Breaking Changes

All WolvenKit releases (App, CLI, and Nuget Packages) have been upgraded to .NET10. The .NET10 runtime can be downloaded from [the official microsoft download page](<https://dotnet.microsoft.com/en-us/download/dotnet/10.0>).

**App**

* *Changed*: Updates WolvenKit to .NET SDK 10 targeting Windows 11. Includes security-related NuGet dependency changes. by @gistya
* *Removed*: Legacy mesh bone rotation import has been removed, old exports pre 8.19.0 will need to be reexported. by @notaspirit
* *Removed*: Removed mod manager by @notaspirit

**CLI**

* *Changed*: Updates WolvenKit to .NET SDK 10 targeting Windows 11. Includes security-related NuGet dependency changes. by @gistya
* *Removed*: Legacy mesh bone rotation import has been removed, old exports pre 8.19.0 will need to be reexported. by @notaspirit

**Nuget Packages**

* *Changed*: Updates WolvenKit to .NET SDK 10 targeting Windows 11. Includes security-related NuGet dependency changes. by @gistya
* *Changed*: WolvenKit.Modkit: ScriptFunctions now depends on RedTypeTemplateService by @notaspirit
* *Removed*: Legacy mesh bone rotation import has been removed, old exports pre 8.19.0 will need to be reexported. by @notaspirit
* *Removed*: Removed previously deprecated file path validaton methods, use FilePathValidationTools or the equivalent StringPathExtnesions methods instead by @notaspirit
* *Removed*: Previously deprecated RedTypeFactory has been removed, use RedTypeManager instead. by @notaspirit

### Non Breaking Changes

**App**

* *Added*: Template Service is now exposed to the WScript environment by @notaspirit
* *Added*: Scene Editor has a new 'Import Dialogue' button and popup in the Dialogue tab. It reads a json from the clipboard or a .json file, to import lines with all their properties, matching each line's speaker and addressee to the scene's actors by name. For use with CET mod Dialogue Browser. by @Akiway
* *Added*: After a successful update of the app using the build in updater the changelog is now shown by @notaspirit
* *Added*: Typing in the filter field of ProjectExplorer now updates automatically when stop typing instead of requiring return to be pressed. by @Ametis81
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
* *Changed*: Better user feedback for 'force LOD level 0' and 'regenerate resolved dependencies'. by @manavortex
* *Changed*: Updated the version of WolvenKit's SyncFusion dependencies to 34.2.2. by @gistya
* *Changed*: CVM: restored forced search initialization on shift+enter by @manavortex
* *Changed*: Archive loading now starts at app launch and finishes much faster, speeding up the time to start working on a project. by @gistya

**CLI**

* *Fixed*: Fixed exporting all sounds from OpusPaks skipping the last pak, leaving some sounds unexported. by @Zhincore
* *Fixed*: Fixed opus export and import writing .wav files to a wrong path when the used directory contains 'opus' in its name. by @Zhincore
* *Fixed*: Build command will will now correctly pack the source archive subfolder instead of the root folder. by @poirierlouis

**Nuget Packages**

* *Added*: Template Service is now exposed to the WScript environment by @notaspirit
* *Fixed*: Fixed exporting all sounds from OpusPaks skipping the last pak, leaving some sounds unexported. by @Zhincore
* *Fixed*: Fixed opus export and import writing .wav files to a wrong path when the used directory contains 'opus' in its name. by @Zhincore
* *Fixed*: ModTools.Build() in ModKit.RED4 will now correctly pack the source archive subfolder instead of the root folder. by @poirierlouis
