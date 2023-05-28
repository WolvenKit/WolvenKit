// @version 1.0
// @author manavortex

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
 * Set this to "true" to disable recursive verification of root entity files
 * (e.g. if you have a great many of them)
 */
const skipRootEntityCheck = false;

function main(ent) {
	FileValidation.validateEntFile(ent, skipRootEntityCheck);
	return true;
};

try {
    const fileContent = JSON.parse(file);
    success = main(fileContent["Data"]["RootChunk"]);
} catch (err) {
    Logger.Warning("failed to validate file");
    success = true;
}