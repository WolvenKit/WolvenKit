## 8.19.0 — 2026-07-03

**App**

* *Added*: entAnimatedComponent: rig and animgraph now have dropdown support. by @manavortex
* *Added*: .mesh import can now add bones to meshes correctly by @Doctor Presto
* *Added*: Added a graph editor for .behavior files with basic tree editing actions. by @misterchedda
* *Fixed*: .ent preview fix (index out of bounds) by @Ametis81
* *Fixed*: Archive file path being incorrectly read from modlist.txt by @manavortex
* *Fixed*: .mesh export now correctly preserves bone rotations by caclulating them from boneRigMatrices. Import now recalculates boneRigMatrices, bonePositions and boneVertexEpsilons based on the data in the glb. by @Doctor Presto
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

* *Added*: .mesh import can now add bones to meshes correctly by @Doctor Presto
* *Fixed*: Archive file path being incorrectly read from modlist.txt by @manavortex
* *Fixed*: .mesh export now correctly preserves bone rotations by caclulating them from boneRigMatrices. Import now recalculates boneRigMatrices, bonePositions and boneVertexEpsilons based on the data in the glb. by @Doctor Presto
* *Changed*: Export / Import masks at their native resolution (low and high res masks with no pixel shift / offset due to scaling) by @Ametis81

**Nuget Packages**

* *Added*: .mesh import can now add bones to meshes correctly by @Doctor Presto
* *Fixed*: Archive file path being incorrectly read from modlist.txt by @manavortex
* *Fixed*: .mesh export now correctly preserves bone rotations by caclulating them from boneRigMatrices. Import now recalculates boneRigMatrices, bonePositions and boneVertexEpsilons based on the data in the glb. by @Doctor Presto
* *Changed*: Export / Import masks at their native resolution (low and high res masks with no pixel shift / offset due to scaling) by @Ametis81
