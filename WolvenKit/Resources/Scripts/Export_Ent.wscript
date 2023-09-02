// Exports file and all referenced files (recursively)
// @author Simarilius, Dzk & Seberoth
// @version 1.1
import * as Logger from 'Logger.wscript';
import * as TypeHelper from 'TypeHelper.wscript';

const fileTemplate = '{"Header":{"WKitJsonVersion":"0.0.7","DataType":"CR2W"},"Data":{"Version":195,"BuildVersion":0,"RootChunk":{},"EmbeddedFiles":[]}}';
const jsonExtensions = [".app", ".ent"];
const exportExtensions = [".mesh"];
const exportEmbeddedExtensions = [".mesh", ".xbm", ".mlmask"];

//list of ent files (paths need double slashes)
var ents = [];

// if you dont want to process any sectors already in the project set this to false
var add_from_project = true;

// Set these to true if you want proxys/shadow meshes
var include_proxys = false;
var include_shadows = false;
var include_fx = false;


// sets of files that are parsed for processing
const parsedFiles = new Set();
const projectSet = new Set();
const exportSet = new Set();
const jsonSet = new Set();

if (add_from_project) {
    for (var filename of wkit.GetProjectFiles('archive')) {
        //Logger.Info(filename);
        var ext = filename.split('.').pop();
        if (ext === "ent") {
            ents.push(filename);
        }
    }
}

// loop over every entity in `ents`
for (var ent in ents) {
    Logger.Info(ents[ent]);
    ParseFile(ents[ent], null);
}

// save all our files to the project and export JSONs
for (const fileName of projectSet) {
    // skip shadows if the variable is set
    if ((include_shadows == false) && (fileName.includes("shadow"))) {
        continue;
    }
    // skip proxies if the variable is set
    if ((include_proxys == false) && (fileName.includes("proxy"))) {
        continue;
    }
    // skip fx bodies if the variable is set
    if ((include_fx == false) && (fileName.includes("fx"))) {
        continue;
    }

    // Load project vesion if it exists, otherwise add to the project
    if (wkit.FileExistsInProject(fileName)) {
        var file = GetFileFromProject(fileName, OpenAs.GameFile);
    }
    else {
        var file = wkit.GetFileFromBase(fileName);
        wkit.SaveToProject(fileName, file);
    }

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

Logger.Info("Finished Exporting Entities")

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

    let extension = 'unknown';
    if (typeof (fileName) === 'string') {
        extension = "." + fileName.split('.').pop();
    }

    if (extension !== 'unknown') {
        if (parentFile != null && parentFile["Data"]["EmbeddedFiles"].length > 0) {
            for (let embeddedFile of parentFile["Data"]["EmbeddedFiles"]) {
                if (embeddedFile["FileName"] === fileName) {
                    convertEmbedded(embeddedFile);

                    if (jsonExtensions.includes(extension)) {
                        jsonSet.add(fileName);
                    }

                    if (exportEmbeddedExtensions.includes(extension)) {
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

    // Load project vesion if it exists, otherwise get the basegamefile
    if (wkit.FileExistsInProject(fileName)) {
        var file = wkit.GetFileFromProject(fileName, OpenAs.GameFile);
    }
    else {
        var file = wkit.GetFileFromBase(fileName);
    }
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
