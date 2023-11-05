// Exports individual files and all referenced files (recursively)
// Can be used to get the embedded files from an object into the project
// @author Simarilius, DZK & Seberoth
// @version 1.0
import * as Logger from 'Logger.wscript';
import * as TypeHelper from 'TypeHelper.wscript';

//list of ent files (paths need double slashes)
let meshes = [
    'base\\worlds\\03_night_city\\sectors\\_global\\terrain\\terrain_aaayaai_cell_16337_16337.mesh'
];

// Set to true to disable warnings about failed meshes
const suppressLogFileOutput = false;

/**
 * Set to true to export all mesh files in project.
 * WARNING: This willt ake a long time and
 * @type {boolean}
 */
const add_from_project = false;

/*
 * ===================================== Change below this line at own risk ========================================
 */

// sets of files that are parsed for processing
const parsedFiles = new Set();
const projectSet = new Set();
const exportSet = new Set();
const jsonSet = new Set();

const fileTemplate = '{"Header":{"WKitJsonVersion":"0.0.7","DataType":"CR2W"},"Data":{"Version":195,"BuildVersion":0,"RootChunk":{},"EmbeddedFiles":[]}}';
const jsonExtensions = [".app", ".ent"];
const exportExtensions = [".mesh"];
const exportEmbeddedExtensions = [".mesh", ".xbm", ".mlmask"];


if (add_from_project) {
    for (let filename of wkit.GetProjectFiles('archive')) {
        // Logger.Success(filename);
        if (filename.split('.').pop() === "mesh") {
            meshes.push(filename);
        }
    }
    // now remove duplicates
    meshes = Array.from(new Set(meshes));
}

// loop over every mesh in `meshes`
for (let mesh in meshes) {
    Logger.Info(`Parsing file ${meshes[mesh]}...`);
    ParseFile(meshes[mesh], null);
}

// save all our files to the project and export JSONs
for (const fileName of projectSet) {
    // Load project version if it exists, otherwise add to the project
    let file;
    if (wkit.FileExistsInProject(fileName)) {
        file = wkit.GetFileFromProject(fileName, OpenAs.GameFile);
    } else {
        file = wkit.GetFileFromBase(fileName);
        wkit.SaveToProject(fileName, file);
    }

    // if the file extension exists and is on the json list, export
    if (!!file?.Extension && jsonSet.has(fileName) && jsonExtensions.includes(file.Extension)) {
        const path = wkit.ChangeExtension(file.Name, `.${file.Extension}.json`);
        const json = wkit.GameFileToJson(file);
        wkit.SaveToRaw(path, json);
    }
}

// export all of our files with the default export settings
wkit.ExportFiles([...exportSet]);

//#region helper_functions
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
        const embeddedFiles = parentFile?.Data?.EmbeddedFiles || [];
        for (let embeddedFile of embeddedFiles) {
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

    let isHash = false;
    if (typeof (fileName) === 'bigint') {
        isHash = true;
        fileName = fileName.toString();
    }

    if (typeof (fileName) !== 'string') {
        Logger.Error('Unknown path type');
        return;
    }

    let file = null;
    // Load from project if it exists, otherwise get the base game file
    if (wkit.FileExistsInProject(fileName)) {
        file = wkit.GetFileFromProject(fileName, OpenAs.GameFile);
    } else {
        file = wkit.GetFileFromBase(fileName);
    }

    // Let the user know if we failed to export the file
    if (file === null && !suppressLogFileOutput) {
        if (!isHash) {
            Logger.Warning(`Skipping invalid export ${fileName}`);
        } else {
            Logger.Info(`Failed to retrieve file from hash: ${fileName}`);
        }
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
    const json = TypeHelper.JsonParse(wkit.GameFileToJson(file));
    for (let path of GetPaths(json["Data"]["RootChunk"])) {
        ParseFile(path, json);
    }
}

//#endregion