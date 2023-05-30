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
 * Set this to "true" to enable recursive verification in app files
 * (e.g. to check the appearance names against meshes)
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

function main(app) {
	if (app.appearances.length === 0) {
		return true;
	}
	FileValidation.validateAppFile(app, validateRecursively, showUnresolvedDepotPathWarnings);
	return true;
}

try {
	const fileContent = JSON.parse(file);
	success = main(fileContent["Data"]["RootChunk"]);
} catch (err) {
	Logger.Warning("failed to validate file");
	success = true;
}