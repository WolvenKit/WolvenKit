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
