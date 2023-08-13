// Entity export script FOR VEHICLES dont use if you dont need all the anims and rig.
// @author Simarilius, DZK & Seberoth
// @version 1.1
// Exports ent files and all referenced files (recursively)
import * as Logger from 'Logger.wscript';
import * as TypeHelper from 'TypeHelper.wscript';

const fileTemplate = '{"Header":{"WKitJsonVersion":"0.0.7","DataType":"CR2W"},"Data":{"Version":195,"BuildVersion":0,"RootChunk":{},"EmbeddedFiles":[]}}';
const jsonExtensions = [".app", ".ent", ".mesh", ".rig"];
const exportExtensions = [".anims", ".mesh"];
const exportEmbeddedExtensions = [".mesh", ".xbm", ".mlmask"];

// Rather than a manual list does it for all ents in the project.
var ents = [];

// if you dont want to process any entities already in the project set this to false
var add_from_project = true;

// sets of files that are parsed for processing
const parsedFiles = new Set();
const projectSet = new Set();
const exportSet = new Set();
const jsonSet = new Set();
const rigs = new Map();

if (add_from_project) {
    for (var filename of wkit.GetProjectFiles('archive')) {
        //Logger.Info(filename)
        var ext = filename.split('.').pop();
        if (ext === "ent") {
            ents.push(filename);
        }
        if (ext === "anims") {
            exportSet.add(filename);
        }
    }
}

// Set these to true if you want proxys/shadow meshes
var include_proxys = false;
var include_shadows = false;
var include_fx = false;

// loop over every entity in `ents` and find rigs
for (var ent in ents) {
    Logger.Info('Finding rigs in ' + ents[ent]);
    FindEntRigs(ents[ent]);
    FindEntAnims(ents[ent]);
    Logger.Info('');
    for (const [key, value] of rigs) {
        Logger.Info(`${key} = ${value}`);
        if (!value.includes("base_rig")) {
            projectSet.add(value);
            jsonSet.add(value);
        }
    }
    Logger.Info('');
}

// now find the mesh files
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
        var file = wkit.GetFileFromProject(fileName, OpenAs.GameFile);
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
        if (file.Extension === ".rig") {
            path = wkit.ChangeExtension(file.Name, ".rig.json");
        }
        if (file.Extension === ".mesh") {
            path = wkit.ChangeExtension(file.Name, ".mesh.json");
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
        if (!(jsonExtensions.includes(extension) || exportExtensions.includes(extension))) {
            return;
        }

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

    extension = file.Extension;

    if (!(jsonExtensions.includes(extension) || exportExtensions.includes(extension))) {
        return;
    }

    projectSet.add(fileName);

    if (jsonExtensions.includes(extension)) {
        jsonSet.add(fileName);
    }

    if (exportExtensions.includes(extension)) {
        exportSet.add(fileName);
    }

    if (extension === ".app" || extension === ".ent" || extension === ".mesh" || extension === ".anims") {
        var json = TypeHelper.JsonParse(wkit.GameFileToJson(file));
        for (let path of GetPaths(json["Data"]["RootChunk"])) {
            ParseFile(path, json);
        }
    }
}

// Parse a ent file for rigs
function FindEntRigs(fileName) {
    if (wkit.FileExistsInProject(fileName)) {
        var file = wkit.GetFileFromProject(fileName, OpenAs.GameFile);
    }
    else {
        var file = wkit.GetFileFromBase(fileName);
    }
    var json = TypeHelper.JsonParse(wkit.GameFileToJson(file));
    //find the rigs in the base ent components (normally root and deformations)
    for (let comp of json["Data"]["RootChunk"]["components"]) {
        if (!("rig" in comp) == 0) {
            //Logger.Info(comp["name"]);
            //Logger.Info(comp["rig"]["DepotPath"]);
            rigs.set(comp["name"].toString(), comp["rig"]["DepotPath"].toString());
        }
    }
    // find any rigs referenced in the appearances (head and dangle)
    for (let app of json["Data"]["RootChunk"]["appearances"]) {
        var appfileName = app["appearanceResource"]["DepotPath"];
        //Logger.Info(appfileName);
        var appfile = wkit.GetFileFromBase(appfileName.toString());
        var appjson = TypeHelper.JsonParse(wkit.GameFileToJson(appfile));
        for (let appApp of appjson["Data"]["RootChunk"]["appearances"]) {
            for (let appcomp of appApp["Data"]["components"]) {
                if (!("rig" in appcomp) == 0) {
                    //Logger.Info(appcomp["name"]);
                    //Logger.Info(appcomp["rig"]["DepotPath"]);
                    rigs.set(appcomp["name"].toString(), appcomp["rig"]["DepotPath"].toString());
                }
            }
        }
    }
}

// Parse a ent file for rigs
function FindEntAnims(fileName) {
    if (wkit.FileExistsInProject(fileName)) {
        var file = wkit.GetFileFromProject(fileName, OpenAs.GameFile);
    }
    else {
        var file = wkit.GetFileFromBase(fileName);
    }
    var json = TypeHelper.JsonParse(wkit.GameFileToJson(file));
    //find the anims in the ent resolved dependencies
    for (let dep of json["Data"]["RootChunk"]["resolvedDependencies"]) {
        Logger.Info(dep["DepotPath"].toString());
        projectSet.add(dep["DepotPath"].toString());
        exportSet.add(dep["DepotPath"].toString());
    }
}

function get_filename(str) {
    return str.split('\\').pop().split('/').pop();
}
