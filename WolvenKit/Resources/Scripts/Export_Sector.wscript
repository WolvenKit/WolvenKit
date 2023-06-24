// Exports file and all referenced files (recursively)
// @author Simarilius
// @version 1.0
import * as Logger from 'Logger.wscript';
import * as TypeHelper from 'TypeHelper.wscript';

//list of sector files (paths need double slashes)
//var sectors=['base\\worlds\\03_night_city\\_compiled\\default\\interior_-20_-16_0_1.streamingsector']
var sectors = ['interior_-29_58_1_0.streamingsector'];

// if you dont want to process any sectors already in the project set this to false
var add_from_project = false;

const sectorPathInFiles = 'base\\worlds\\03_night_city\\_compiled\\default';
for (var i = 0; i < sectors.length; i += 1) {
    let sectorPath = sectors[i];
    if (!sectorPath.includes("\\")) {
        sectorPath = `${sectorPathInFiles}\\${sectorPath}`;
    }
    if (!sectorPath.endsWith('.streamingsector')) {
        sectorPath = `${sectorPath}.streamingsector`;
    }
    sectors[i] = sectorPath;
}

if (add_from_project) {
    for (var filename of wkit.GetProjectFiles('archive')) {
        //Logger.Info(filename);
        var ext = filename.split('.').pop();
        if (ext === "streamingsector") {
            sectors.push(filename);
        }
    }
}

// sets of files that are parsed for processing
const parsedFiles = new Set();
const projectSet = new Set();
const exportSet = new Set();
const jsonSet = new Set();

// loop over every sector in `sectors`
for (var sect in sectors) {
    Logger.Info(sectors[sect]);
    ParseFile(sectors[sect]);
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
        if (file.Extension === ".streamingsector") {
            path = wkit.ChangeExtension(file.Name, ".streamingsector.json");
        }
        if (file.Extension === ".app") {
            path = wkit.ChangeExtension(file.Name, ".app.json");
        }
        if (file.Extension === ".mi") {
            path = wkit.ChangeExtension(file.Name, ".mi.json");
        }
        if (file.Extension === ".mt") {
            path = wkit.ChangeExtension(file.Name, ".mt.json");
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
function  * GetPaths(jsonData) {
    for (let [key, value] of Object.entries(jsonData || {})) {
        if (value instanceof TypeHelper.ResourcePath && !value.isEmpty()) {
            yield value.value;
        }

        if (typeof value === "object") {
            yield * GetPaths(value);
        }
    }
}

// Parse a CR2W file
function ParseFile(fileName) {
    // check if we've already worked with this file and that it's actually a string
    if (parsedFiles.has(fileName) || typeof fileName !== "string") {
        return;
    }
    parsedFiles.add(fileName);

    // try to get the file
    var file = wkit.GetFileFromBase(fileName);
    if (file === null) {
        Logger.Error(fileName + " could not be found");
        return;
    }

    // handle the file types we want
    if (file.Extension === ".mesh") {
        projectSet.add(fileName);
        exportSet.add(fileName);
    }
    if (file.Extension === ".ent") {
        projectSet.add(fileName);
        jsonSet.add(fileName);
    }
    if (file.Extension === ".app") {
        projectSet.add(fileName);
        jsonSet.add(fileName);
    }
    if (file.Extension === ".streamingsector") {
        projectSet.add(fileName);
        jsonSet.add(fileName);
    }
    if (file.Extension === ".mi") {
        projectSet.add(fileName);
        jsonSet.add(fileName);
    }
    if (file.Extension === ".mt") {
        projectSet.add(fileName);
        jsonSet.add(fileName);
    }
    if (file.Extension === ".xbm") {
        projectSet.add(fileName);
        exportSet.add(fileName);
    }

    // now check if there are referenced files and parse them
    if (file.Extension === ".app" || file.Extension === ".ent" || file.Extension === ".mesh" || file.Extension === ".streamingsector" || file.Extension === ".mi" || file.Extension === ".mt") {
        var json = TypeHelper.JsonParse(wkit.GameFileToJson(file));
        for (let path of GetPaths(json["Data"]["RootChunk"])) {
            ParseFile(path);
        }
    }
}
