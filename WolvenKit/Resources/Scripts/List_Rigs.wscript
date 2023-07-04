// List all the Rigs called up by an ent file
// @author Simarilius
// @version 1.0
import * as Logger from 'Logger.wscript';
import * as TypeHelper from 'TypeHelper.wscript';

function* GetPaths(jsonData) {
    for (let [key, value] of Object.entries(jsonData || {})) {
        if (value instanceof TypeHelper.ResourcePath && !value.isEmpty()) {
            yield value.value;
        }

        if (typeof value === "object") {
            yield* GetPaths(value);
        }
    }
}

function ExtractFile(fileName) {
    if (typeof (fileName) === 'bigint') {
        fileName = fileName.toString();
    }

    if (typeof (fileName) !== 'string') {
        Logger.Error('Unknown path type');
        return;
    }

    var file = wkit.GetFileFromBase(fileName);
    if (file === null) {
        Logger.Error(fileName + " could not be found");
        return;
    }

    if (file.Extension === ".rig") {
        logger.Info(fileName);
    }

    var json = TypeHelper.JsonParse(wkit.GameFileToJson(file));
    for (let path of GetPaths(json["Data"]["RootChunk"])) {
        ExtractFile(path);
    }
}

ExtractFile("base\\characters\\entities\\main_npc\\evelyn.ent");
