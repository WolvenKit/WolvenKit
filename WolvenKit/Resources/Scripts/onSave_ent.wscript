import * as FileValidation from 'Wolvenkit/Wolvenkit_FileValidation.wscript';
import * as Logger from 'Wolvenkit/Logger.wscript';

/* ******************************************************
*      _                         _   _
*   __| |_  __ _ _ _  __ _ ___  | |_| |_  ___ ___ ___
*  / _| ' \/ _` | ' \/ _` / -_) |  _| ' \/ -_|_-</ -_)
*  \__|_||_\__,_|_||_\__, \___|  \__|_||_\___/__/\___|
*                    |___/
** ***************************************************** */

/*
 * Set this to "false" to disable recursive verification of linked .app files and meshes
 * (e.g. if this is taking too long for your liking)
 */
const validateRecursively = true;

/*
 * Set this to "false" to disable warnings about unresolved depot paths
 * e.g. "component: unknown resource in depot path"
 */
const showUnresolvedDepotPathWarnings = true;

/* 
 * ******************************************************
 */

function main(ent) {
	FileValidation.validateEntFile(ent/*, showUnresolvedDepotPathWarnings*/, validateRecursively);
	return true;
}


try {
    const fileContent = JSON.parse(file);
    success = main(fileContent["Data"]["RootChunk"]);
} catch (err) {
    Logger.Warning("failed to validate file");
    success = true;
}