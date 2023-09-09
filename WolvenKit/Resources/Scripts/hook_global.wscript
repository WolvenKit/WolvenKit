// @version 1.0

import * as Logger from 'Logger.wscript';
import * as FileValidation from 'Wolvenkit_FileValidation.wscript';
import * as TypeHelper from 'TypeHelper.wscript';
import Settings from 'hook_settings.wscript';
import {hasUppercasePaths, isDataChangedForWriting} from "Wolvenkit_FileValidation.wscript";

/**
 * If this is set to "true" and file validation runs into any errors, then YOUR FILES WILL NO LONGER SAVE.
 * ONLY ENABLE THIS IF YOU KNOW WHAT YOU'RE DOING!
 */
const isWolvenkitDeveloper = false;

const README_URL = 'https://wiki.redmodding.org/wolvenkit/wolvenkit-app/file-validation';

globalThis.onSave = function (ext, file) {
    if (!Settings.Enabled) {
        return {
            success: true,
            file: file
        }
    }
    const fileContent = TypeHelper.JsonParse(file);
    
    // grab file name from json and inform file validation about it
    const fileName = (fileContent.Header?.ArchiveFileName || '').split('archive\\').pop() || '';
    FileValidation.setPathToCurrentFile(fileName);
    
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
        case "inkatlas":
            FileValidation.validateInkatlasFile(fileContent["Data"]["RootChunk"], Settings.Inkatlas);
            file = TypeHelper.JsonStringify(fileContent);
            break;
        case "json":
            FileValidation.validateJsonFile(fileContent["Data"]["RootChunk"], Settings.Json);
            file = TypeHelper.JsonStringify(fileContent);
            break;
        }        
    } catch (err) {
        if (isWolvenkitDeveloper) {
            throw err;
        }
        Logger.Warning(`Could not verify the file you just saved due to an error in Wolvenkit.`);
        Logger.Info('\tYou can ignore this warning or help us fix the problem: get in touch on Discord or create a ticket under https://github.com/WolvenKit/Wolvenkit/issues');
        Logger.Info('\tPlease include the necessary files from your project\'s source folder.')
        Logger.Info(`\tFor more information, check ${README_URL}#there-was-an-error`)

    }
    if (FileValidation.hasUppercasePaths) {
        Logger.Error(`You have uppercase characters in your file paths. File validation will not work.`);
        Logger.Info(`If you are using this as a hack to disable the feature, see ${README_URL}.`)
    }

    const retSuccess = {
        success: success,
        file: file
    }

    // either we have nothing to write or we aren't supposed to write => abort
    if (!FileValidation.isDataChangedForWriting || Settings.DisableAutofix) return retSuccess;

    // unless it's a workspot, automatically close and re-open it
    if (!fileName.endsWith('workspot') || Settings.Workspot.autoReopenFile) {
        try {
            const filePath = wkit.GetActiveDocument().FilePath;
            Logger.Info(`Filevalidation: Reopening ${filePath} for you…`);
            wkit.GetActiveDocument().Close();
            wkit.OpenDocument(filePath);
        } catch (err) {
            Logger.Error(`Failed! Automatic changes won't be applied until you close and re-open your file!`);
        }
        return retSuccess;
    }

    if (fileName.endsWith('workspot')) {
        // tell the user why it's not auto-closing and -reopening
        Logger.Warning(`File validation has made the following changes:`);
        Logger.Info(`\t- fixed order of workspot indices`);
        Logger.Info(`To disable the feature, set "Workspot.fixIndexOrder" to "false".`);
        Logger.Info(`To disable this warning, set "Workspot.autoReopenFile" to "true".`);
        Logger.Info(`https://wiki.redmodding.org/wolvenkit/wolvenkit-app/file-validation#configuring-file-validation`);
    } else {
        Logger.Info(`File validation has made changes, but we forgot to keep track what it did.`);
        Logger.Info(`Please check the log output above. To make this error go away for good, `);
        Logger.Info(`get in touch via REDmodding Discord or create a ticket: https://github.com/WolvenKit/Wolvenkit/issues`);
    }

    Logger.Info(`You need to close and re-open ${filePath}, or file validation won't know about the automatic changes.`);
    return retSuccess;


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
