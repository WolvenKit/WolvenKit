// Entity export script FOR VEHICLES dont use if you dont need all the anims and rig.
// @author Simarilius & DZK
// @version 1.0
// Exports ent files and all referenced files (recursively)
import * as Logger from 'Logger.wscript';
import * as TypeHelper from 'TypeHelper.wscript';

// Rather than a manual list does it for all ents in the project. 

var ents=[]

// sets of files that are parsed for processing
const parsedFiles = new Set()
const projectSet = new Set()
const exportSet = new Set()
const jsonSet = new Set()
const rigs = new Map()

for (var filename of wkit.GetProjectFiles('archive')) {
    //Logger.Info(filename)
    var ext=filename.split('.').pop();
    if (ext === "ent") {
        ents.push(filename)
    }
    if (ext === "anims") {
        exportSet.add(filename)
    }
}


// Set these to true if you want proxys/shadow meshes
var include_proxys=false
var include_shadows=false
var include_fx=false

// loop over every entity in `ents` and find rigs
for (var ent in ents) {
    Logger.Info('Finding rigs in '+ ents[ent])
    FindEntRigs(ents[ent])
    FindEntAnims(ents[ent])
    Logger.Info('')
    for (const [key, value] of rigs) 
    {
  	Logger.Info(`${key} = ${value}`);
  	if (value.includes("base_rig")!=true){
  	    projectSet.add(value)
            jsonSet.add(value)
  	}
	}
    Logger.Info('')
}

// now find the mesh files
for (var ent in ents) {
    Logger.Info(ents[ent])
    ParseFile(ents[ent])
}

// save all our files to the project and export JSONs
for (const fileName of projectSet) {
    // skip shadows if the variable is set
	if ((include_shadows==false) && (fileName.includes("shadow"))){
		continue
    }
	// skip proxies if the variable is set
	if ((include_proxys==false) && (fileName.includes("proxy"))){
		continue
    }
	// skip fx bodies if the variable is set
	if ((include_fx==false) && (fileName.includes("fx"))){
		continue
    }
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
        if (file.Extension === ".rig") {
            path = wkit.ChangeExtension(file.Name, ".rig.json")
        }
        if (file.Extension === ".mesh") {
            path = wkit.ChangeExtension(file.Name, ".mesh.json")
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
	var ext=fileName.split('.').pop();
	if (ext==='mesh' || ext==='app' || ext==='ent' || ext==='anims') {
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
            // meshes need json'ing too for the bits with 
            jsonSet.add(fileName)
        }
        if (file.Extension === ".ent") {
            projectSet.add(fileName)
            jsonSet.add(fileName)
        }
        if (file.Extension === ".app") {
            projectSet.add(fileName)
            jsonSet.add(fileName)
        }
        if (file.Extension === ".anims") {
            projectSet.add(fileName)
            exportSet.add(fileName)
        }
        if (file.Extension === ".rig") {
            projectSet.add(fileName)
            jsonSet.add(fileName)
        }

        // now check if there are referenced files and parse them
        if (file.Extension === ".app" || file.Extension === ".ent" || file.Extension === ".mesh" || file.Extension === ".anims"){
	        var json = JSON.parse(wkit.GameFileToJson(file))
	        for (let path of GetPaths(json["Data"]["RootChunk"])) {
	            ParseFile(path)
	    	}
        }
    }
}

// Parse a ent file for rigs
function FindEntRigs(fileName) {
	var file = wkit.GetFileFromBase(fileName)
	var json = JSON.parse(wkit.GameFileToJson(file))
	//find the rigs in the base ent components (normally root and deformations)
	for (let comp of json["Data"]["RootChunk"]["components"]) {
		if (!("rig" in comp)==0)
		{
		//Logger.Info(comp["name"])
		//Logger.Info(comp["rig"]["DepotPath"])
		rigs.set(comp["name"],comp["rig"]["DepotPath"])
		}
	}
	// find any rigs referenced in the appearances (head and dangle)
	for (let app of json["Data"]["RootChunk"]["appearances"])
	{
		var appfileName=app["appearanceResource"]["DepotPath"]
		//Logger.Info(appfileName)
		var appfile = wkit.GetFileFromBase(appfileName)
		var appjson = JSON.parse(wkit.GameFileToJson(appfile))
		for (let appApp of appjson["Data"]["RootChunk"]["appearances"])
		{
				for (let appcomp of appApp["Data"]["components"]) 
				{
					if (!("rig" in appcomp)==0)
					{
					//Logger.Info(appcomp["name"])
					//Logger.Info(appcomp["rig"]["DepotPath"])
					rigs.set(appcomp["name"],appcomp["rig"]["DepotPath"])
					}
				}	
		}			
	}
}

// Parse a ent file for rigs
function FindEntAnims(fileName) {
	var file = wkit.GetFileFromBase(fileName)
	var json = JSON.parse(wkit.GameFileToJson(file))
	//find the anims in the ent resolved dependencies
	for (let dep of json["Data"]["RootChunk"]["resolvedDependencies"]) {
		Logger.Info(dep["DepotPath"])
		projectSet.add(dep["DepotPath"])
		exportSet.add(dep["DepotPath"])
	}
}

function get_filename(str) {
    return str.split('\\').pop().split('/').pop();
}