// @version 1.0

import * as Logger from 'Logger.wscript';
import * as FileValidation from 'Wolvenkit_FileValidation.wscript';
import * as TypeHelper from 'TypeHelper.wscript';
import Settings from 'hook_settings.wscript';

globalThis.onSave = function (ext, file) {
    const fileContent = TypeHelper.JsonParse(file);

    let success = true;
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
    case "workspot":
        FileValidation.validateWorkspotFile(fileContent["Data"]["RootChunk"], Settings.Workspot);
        file = TypeHelper.JsonStringify(fileContent);
        break;
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
