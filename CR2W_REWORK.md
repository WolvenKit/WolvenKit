# Reworking cr2w editing & vizualization
Just to clarify : a cr2w file has a chunklist and a propertylist.
![image](https://user-images.githubusercontent.com/16599683/93666537-4eea7400-fa7f-11ea-86b1-b513e924e44a.png)

The **main goal** is :
- to remove as much as possible editing from the chunklist, and to move it to the property list :
forcing people to **think objects and not serialization**.
- to have by default solid cr2w modification rules to guide the users, and have the engine accept those edits.

## Property operations :

_Cannot_ add unknown variables to native classes.

_Cannot_ add unknown variables to scripted classes from wkit, but new scripted classes can be compiled by wkit with the added properties discovered and made usable.

_Can only_ modify properties in arrays :

| - 	| Modifying properties in arrays 	| Commit/PR 	| Note 	|
|:-:	|:-:	|-	|-	|
|  	| reindexing - moving up/down 	|  	|  	|
|  	| referrers updates on creation / deletion 	|  	|  	|
|  	| drag and drop 	|  	| ![propdrag](https://user-images.githubusercontent.com/16599683/93667126-b4406400-fa83-11ea-8135-00f57388332b.png) 	|
|  	| clear variable function 	|  	|  	|
| :white_check_mark: 	| inter-cr2w file operations (spec ops) 	|  	| ?  	|

### FCD
- [ ] auto-generation

## Property viz :
| - 	| Prop viz 	| Commit/PR 	| Note 	|
|:-:	|:-:	|-	|-	|
| :white_check_mark: 	| Show all properties / show only serialized props  	|  	|  	|
| :white_check_mark: 	| Prop color picker  	|  	|  	|
|  	| Native and scripted classes/props in different colors  	|  	|  	|

## Chunk operations :

| - 	| Chunk ops 	| Commit/PR 	| Note 	|
|-	|-	|-	|-	|
|  	| Cannot modify chunks by default 	|  	|  	|
|  	| A hidden setting triggers "entering crazy-advanced-user-mode", where no chunk edit is forbidden 	|  	|  	|
| :white_check_mark: 	| Maintain a children list per chunk 	|  	|  	|
| :white_check_mark: 	| Cute auto-chunk create and delete (based on property edits) 	|  	|  	|
|  	| Chunk reindexing API - maintain a consistent chunk hierarchy & index 	|  	|  	|

## Chunk vizualization :
| - 	| Chunk viz 	| Commit/PR 	| Note 	|
|-	|-	|-	|-	|
| :white_check_mark: 	| display chunks sequential, with a virtual parent chunk  	| #210 	|  lacks a unit test to assert all cr2ws are one-root DAGs with this	|
|  	| have a pure chunk index column 	|  	|  	|

## Navigation and dependencies :

| - 	| Following references (CPtr, CHandle, CSoft) 	| Commit/PR 	| Note 	|
|:-:	|:-:	|-	|-	|
| :white_check_mark: 	| Move from a chunk ref to the chunk 	|  b192ff5e0e29276a9debc36ebf7d4348039e9898	|  Lacks frmChunkList update so far	|
|  	| Move from a file ref to the file 	|  | Could use the modexplorer "add file dependencies"? 	|
