// @version 1.0
// @author manavortex

import * as Logger from 'Wolvenkit/Logger.wscript';
import * as FileValidation from 'Wolvenkit/Wolvenkit_FileValidation.wscript';

/* ******************************************************
*      _                         _   _
*   __| |_  __ _ _ _  __ _ ___  | |_| |_  ___ ___ ___
*  / _| ' \/ _` | ' \/ _` / -_) |  _| ' \/ -_|_-</ -_)
*  \__|_||_\__,_|_||_\__, \___|  \__|_||_\___/__/\___|
*                    |___/
** ***************************************************** */

/*
 * Set this to "false" to stop this script from fixing the index order for you.
 */
const fixIndexOrder = true;

/*
 * Set this to "false" to suppress the warning "Items from .anim files not found in .workspot:"
 */
const showUnusedAnimsInFiles = true;

/*
 * Set this to "false" to suppress the warning "Items from .workspot not found in .anim files:"
 */
const showUndefinedWorkspotAnims = true;

/*
* Set this to "false" to suppress the info about "idle animation name "xxxx" not found in […]""
 */
const checkIdleAnimNames = true;

/*
 * Set this to "false" to suppress the info about "id already used by…" (Why would you want that? It breaks things!)
 */
const checkIdDuplication = true;

/*
 * Set this to "false" to suppress the warning "File … not found in game or project files"
 */
const checkFilepaths = true;

/*
 * Set this to "false" to suppress the warning "finalAnimSet x: animation "abc" not found in…"
 */
const checkLoadingHandles = true;


function main(workspot) {
  FileValidation.validateWorkspotFile(workspot, fixIndexOrder, showUnusedAnimsInFiles, showUndefinedWorkspotAnims, checkIdleAnimNames, checkIdDuplication, checkFilepaths, checkLoadingHandles);
	return true;
};


try {
  const fileContent = JSON.parse(file);
  success = main(fileContent["Data"]["RootChunk"]);
  try {
    file = JSON.stringify(fileContent);
  } catch (err) {
    Logger.Warning("Failed to write file");
  }
} catch (err) {
    Logger.Warning("failed to validate file");
    Logger.Warning(err);
    success = true;
}