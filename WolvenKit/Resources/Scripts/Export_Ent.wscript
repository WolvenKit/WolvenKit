// Exports file and all referenced files (recursively)
// @author Simarilius
// @version 1.0
import * as Logger from 'Logger.wscript';
import * as TypeHelper from 'TypeHelper.wscript';

const fileTemplate = '{"Header":{"WKitJsonVersion":"0.0.7","DataType":"CR2W"},"Data":{"Version":195,"BuildVersion":0,"RootChunk":{},"EmbeddedFiles":[]}}';
const jsonExtensions = [".app", ".ent"];
const exportExtensions = [".mesh"];

//list of ent files (paths need double slashes)
var ents = ['base\\quest\\main_quests\\prologue\\q001\\entities\\q001_maxtac_rifle.ent'];

// sets of files that are parsed for processing
const parsedFiles = new Set();
const projectSet = new Set();
const exportSet = new Set();
const jsonSet = new Set();

// loop over every entity in `ents`
for (var ent in ents) {
    Logger.Info(ents[ent]);
    ParseFile(ents[ent], null);
}

// save all our files to the project and export JSONs
for (const fileName of projectSet) {
    var file = wkit.GetFileFromBase(fileName);
    wkit.SaveToProject(fileName, file);

    if (jsonSet.has(fileName)) {
        var path = "";
        if (file.Extension === ".ent") {
            path = wkit.ChangeExtension(file.Name, ".ent.json");
        }
        if (file.Extension === ".app") {
            path = wkit.ChangeExtension(file.Name, ".app.json");
        }
        if (path.length > 0) {
            var json = wkit.GameFileToJson(file);
            wkit.SaveToRaw(path, json);
        }
    }
}

// export all of our files with the default export settings
wkit.ExportFiles([...exportSet]);

// begin helper functions
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

function convertEmbedded(embeddedFile) {
    let data = TypeHelper.JsonParse(fileTemplate);
    data["Data"]["RootChunk"] = embeddedFile["Content"];
    let jsonString = TypeHelper.JsonStringify(data);

    let cr2w = wkit.JsonToCR2W(jsonString);
    wkit.SaveToProject(embeddedFile["FileName"], cr2w);
}

// Parse a CR2W file
function ParseFile(fileName, parentFile) {
    // check if we've already worked with this file and that it's actually a string
    if (parsedFiles.has(fileName)) {
        return;
    }
    parsedFiles.add(fileName);

    let extension = 'unkown';
    if (typeof (fileName) === 'string') {
        extension = "." + fileName.split('.').pop();
    }

    if (extension !== 'unkown') {
        if (parentFile != null && parentFile["Data"]["EmbeddedFiles"].length > 0) {
            for (let embeddedFile of parentFile["Data"]["EmbeddedFiles"]) {
                if (embeddedFile["FileName"] === fileName) {
                    convertEmbedded(embeddedFile);

                    if (jsonExtensions.includes(extension)) {
                        jsonSet.add(fileName);
                    }

                    if (exportExtensions.includes(extension)) {
                        exportSet.add(fileName);
                    }

                    return;
                }
            }
        }
    }

    if (typeof (fileName) === 'bigint') {
        fileName = fileName.toString();
    }

    if (typeof (fileName) !== 'string') {
        Logger.Error('Unknown path type');
        return;
    }

    // try to get the file
    const file = wkit.GetFileFromBase(fileName);
    if (file === null) {
        Logger.Error(fileName + " could not be found");
        return;
    }

    if (jsonExtensions.includes(extension)) {
        projectSet.add(fileName);
        jsonSet.add(fileName);
    }

    if (exportExtensions.includes(extension)) {
        projectSet.add(fileName);
        exportSet.add(fileName);
    }

    // now check if there are referenced files and parse them
    var json = TypeHelper.JsonParse(wkit.GameFileToJson(file));
    for (let path of GetPaths(json["Data"]["RootChunk"])) {
        ParseFile(path, json);
    }
}
