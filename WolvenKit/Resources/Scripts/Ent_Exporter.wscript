// Exports file and all referenced files (recursively)
// @author Simarilius
// @version 1.0
import * as Logger from 'Logger.wscript';
import * as TypeHelper from 'TypeHelper.wscript';

//list of ent files (paths need double slashes)
var ents = ['base\\quest\\main_quests\\prologue\\q001\\entities\\q001_maxtac_rifle.ent']

// sets of files that are parsed for processing
const parsedFiles = new Set()
const projectSet = new Set()
const exportSet = new Set()
const jsonSet = new Set()

// loop over every entity in `ents`
for (var ent in ents) {
    Logger.Info(ents[ent])
    ParseFile(ents[ent])
}

// save all our files to the project and export JSONs
for (const fileName of projectSet) {
    var file = wkit.GetFileFromBase(fileName)
    wkit.SaveToProject(fileName, file)

    if (jsonSet.has(fileName)) {
        var path = ""
        if (file.Extension === ".ent") {
            path = wkit.ChangeExtension(file.Name, ".ent.json")
        }
        if (file.Extension === ".app") {
            path = wkit.ChangeExtension(file.Name, ".app.json")
        }
        if (path.length > 0) {
            var json = wkit.GameFileToJson(file)
            wkit.SaveToRaw(path, json)
        }
    }
}

// export all of our files with the default export settings
wkit.ExportFiles([...exportSet])


// begin helper functions
function* GetPaths(jsonData) {
    for (let [key, value] of Object.entries(jsonData || {})) {
        if (value instanceof TypeHelper.ResourcePath && !value.isEmpty()) {
            yield value.value;
        }

        if (typeof value === "object") {
            yield* GetPaths(value)
        }
    }
}

// Parse a CR2W file
function ParseFile(fileName) {
    // check if we've already worked with this file and that it's actually a string
    if (parsedFiles.has(fileName) || typeof fileName !== "string") {
        return
    }
    parsedFiles.add(fileName)

    // try to get the file
    var file = wkit.GetFileFromBase(fileName)
    if (file === null) {
        Logger.Error(fileName + " could not be found")
        return
    }
    
    // handle the file types we want
    if (file.Extension === ".mesh") {
        projectSet.add(fileName)
        exportSet.add(fileName)
    }
    if (file.Extension === ".ent") {
        projectSet.add(fileName)
        jsonSet.add(fileName)
    }
    if (file.Extension === ".app") {
        projectSet.add(fileName)
        jsonSet.add(fileName)
    }

    // now check if there are referenced files and parse them
    var json = JSON.parse(wkit.GameFileToJson(file))
    for (let path of GetPaths(json["Data"]["RootChunk"])) {
        ParseFile(path)
    }
}