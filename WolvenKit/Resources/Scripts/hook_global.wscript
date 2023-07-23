// @version 1.0

import * as Logger from 'Logger.wscript';
import * as FileValidation from 'Wolvenkit_FileValidation.wscript';
import * as TypeHelper from 'TypeHelper.wscript';
import Settings from 'hook_settings.wscript';
import {hasUppercasePaths} from "Wolvenkit_FileValidation.wscript";

/**
 * If this is set to "true" and file validation runs into any errors, then YOUR FILES WILL NO LONGER SAVE.
 * ONLY ENABLE THIS IF YOU KNOW WHAT YOU'RE DOING!
 */
const isWolvenkitDeveloper = false;

globalThis.onSave = function (ext, file) {
    if (!Settings.Enabled) {
        return {
            success: true,
            file: file
        }
    }
    const fileContent = TypeHelper.JsonParse(file);

    let success = true;
    try {
        switch (ext) {
        case "anims":
            FileValidation.validateAnimationFile(fileContent["Data"]["RootChunk"], Settings.Anims);
            break;
        case "app":
            if (fileContent["Data"]["RootChunk"].appearances.length > 0) {
                FileValidation.validateAppFile(fileContent["Data"]["RootChunk"], Settings.App);
            }
            break;
        case "csv":
            FileValidation.validateCsvFile(fileContent["Data"]["RootChunk"], Settings.Csv);
            break;
        case "ent":
            FileValidation.validateEntFile(fileContent["Data"]["RootChunk"], Settings.Ent);
            break;
        case "mesh":
            FileValidation.validateMeshFile(fileContent["Data"]["RootChunk"], Settings.Mesh);
            break;
        case "mi":
            FileValidation.validateMiFile(fileContent["Data"]["RootChunk"], Settings.Mi);
            break;
        case "workspot":
            FileValidation.validateWorkspotFile(fileContent["Data"]["RootChunk"], Settings.Workspot);
            file = TypeHelper.JsonStringify(fileContent);
            break;
        }
    } catch (err) {
        if (isWolvenkitDeveloper) {
            throw err;
        }
        Logger.Warning(`Could not verify the file you just saved due to an error in Wolvenkit.`);
        Logger.Info('You can ignore this warning or help us fix the problem: get in touch on Discord or create a ticket under https://github.com/WolvenKit/Wolvenkit/issues');
        Logger.Info('Please include the necessary files.')
    }
    
    if (FileValidation.hasUppercasePaths) {
        Logger.Error(`You have uppercase characters in your file paths. File validation will not work.`);
        Logger.Info('If you are using this as a hack to disable the feature, consider doing it via Scripts Manager (Tools):');
        Logger.Info('Switch to "Hook", double-click on "hook_settings" under "User" and set "Enabled" in line 4 to "false".');
        
    }

    return {
        success: success,
        file: file
    }
}

globalThis.onExport = function (path, settings) {
    const json = TypeHelper.JsonParse(settings);
    return {
        settings: TypeHelper.JsonStringify(json)
    }
}

globalThis.onPreImport = function (path, settings) {
    const json = TypeHelper.JsonParse(settings);
    // Logger.Info(json);
    return {
        settings: TypeHelper.JsonStringify(json)
    }
}

// Not yet implemented
globalThis.onPostImport = function (path, settings) {
    Logger.Info(settings);
    return {
        success: true
    }
}
