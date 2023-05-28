// @version 1.0

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
 * Set this to "true" to have the script print all animation names to console
 */
const printAnimationNames = false;

/*
 * Set this to "false" to disable check for duplicate anims
 */
const checkForDuplicates = true;

/*
 * Set this to "false" to disable check for duplicate anims
 */
const targetAnimNames = [];



function main(animAnimSet) {
    FileValidation.validateAnimationFile(animAnimSet, checkForDuplicates, printAnimationNames, targetAnimNames);
    return true;
}


try {
    const fileContent = JSON.parse(file);
    success = main(fileContent["Data"]["RootChunk"]);
} catch (err) {
    Logger.Warning("failed to validate file");
    success = true;
}