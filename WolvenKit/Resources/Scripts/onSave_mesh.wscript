import * as Logger from 'Logger.wscript';

function CheckMaterialProperties(material, materialName) {
	for (var i = 0; i < material.values.length; i++) {
		var tmp = material.values[i];
		
		if (!tmp["$type"].startsWith("rRef:")) {
			continue;
		}
		
		Object.entries(tmp).forEach(([key, value]) => {
			if (key === "$type") {
				return;
			}
			
			switch(key) {
				case "MultilayerSetup":
			    	if (!value["DepotPath"].endsWith(".mlsetup")) {
			    		Logger.Warning(`${materialName}.values[${i}]: ${value["DepotPath"]} doesn't end in .mlsetup. This might cause crashes.`);
			    	}
			    	break;
				case "MultilayerMask":
			    	if (!value["DepotPath"].endsWith(".mlmask")) {
			    		Logger.Warning(`${materialName}.values[${i}]: ${value["DepotPath"]} doesn't end in .mlmask. This might cause crashes.`);
			    	}
			    	break;
			    case "BaseColor":
			    case "Metalness":
			    case "Roughness":
			    case "Normal":
			    case "GlobalNormal":
			    	if (!value["DepotPath"].endsWith(".xbm")) {
			    		Logger.Warning(`${materialName}.values[${i}]: ${value["DepotPath"]} doesn't end in .xbm. This might cause crashes.`);
			    	}
			    	break;
			}
		});
	}
}

function main(mesh) {
	if (mesh.externalMaterials.length > 0 && mesh.preloadExternalMaterials.length > 0) {
		Logger.Warning("Your mesh is trying to use both externalMaterials and preloadExternalMaterials. To avoid unspecified behaviour, use only one of the lists.");
	}
	
	if (mesh.localMaterialBuffer.materials !== null && mesh.localMaterialBuffer.materials.length > 0 && mesh.preloadLocalMaterialInstances.length > 0) {
		Logger.Warning("Your mesh is trying to use both localMaterialBuffer.materials and preloadLocalMaterialInstances. To avoid unspecified behaviour, use only one of the lists.");
	}
	
	var sumOfLocal = mesh.localMaterialInstances.length + mesh.preloadLocalMaterialInstances.length;
    if (mesh.localMaterialBuffer.materials !== null)
    {
        sumOfLocal += mesh.localMaterialBuffer.materials.length;
    }
    var sumOfExternal = mesh.externalMaterials.length + mesh.preloadExternalMaterials.length;
    
    var materialNames = {};
    var localIndexList = [];
    
    for(var i = 0; i < mesh.materialEntries.length; i++) {
    	var materialEntry = mesh.materialEntries[i];
    	
    	// Put all material names into a list - we'll use it to verify the appearances later
    	var name = materialEntry.name.toString() ?? "";
    	if (name in materialNames) {
    		Logger.Warning(`materialEntries[${i}] (${name}) is already defined in materialEntries[${materialNames[name]}]`);
    	} else {
    		materialNames[name] = i;
    	}
    	
    	if (materialEntry.isLocalInstance) {
    		if (materialEntry.index >= sumOfLocal)
            {
                Logger.Warning(`materialEntries[${i}] (${materialEntry.name}) is trying to access a local material with the index ${materialEntry.index}, but there are only ${sumOfLocal} entries.`);
            }
            
            if (localIndexList.includes(materialEntry.index))
            {
                Logger.Warning(`materialEntries[${i}] (${materialEntry.name}) is overwriting an already-defined material index: ${materialEntry.index}. Your material assignments might not work as expected.`);
            }
            localIndexList.push(materialEntry.index);
    	} else {
    		if (materialEntry.index >= sumOfExternal)
            {
                Logger.Warning(`materialEntries[${i}] (${materialEntry.name}) is trying to access an external material with the index ${materialEntry.index}, but there are only ${sumOfExternal} entries.`);
            }
    	}
    }
    
    if (mesh.localMaterialBuffer.materials !== null)
    {
        for (var i = 0; i < mesh.localMaterialBuffer.materials.length; i++)
        {
            var material = mesh.localMaterialBuffer.materials[i];

            var materialName = "unknown";

            // Add a warning here???
            if (i < mesh.materialEntries.length && mesh.materialEntries[i] == "undefined")
            {
                materialName = mesh.materialEntries[i].name;
            }

            CheckMaterialProperties(material, materialName);
        }
    }
    
    for (var i = 0; i < mesh.preloadLocalMaterialInstances.length; i++)
    {
        var material = mesh.preloadLocalMaterialInstances[i];

        var materialName = "unknown";

        // Add a warning here???
        if (i < mesh.materialEntries.length && mesh.materialEntries[i] == "undefined")
        {
            materialName = mesh.materialEntries[i].name;
        }

        CheckMaterialProperties(material.Data, materialName);
    }
    
    var numSubMeshes = 0;
    // Create RenderResourceBlob if it doesn't exists?
    if (mesh.renderResourceBlob !== "undefined")
    {
        numSubMeshes = mesh.renderResourceBlob.Data.header.renderChunkInfos.length;
    }
    
    for (var i = 0; i < mesh.appearances.length; i++) {
    	var appearance = mesh.appearances[i].Data;
    	
    	if (numSubMeshes > appearance.chunkMaterials.length) {
    		Logger.Warning(`Appearance ${appearance.name} has only ${appearance.chunkMaterials.length} of ${numSubMeshes} submesh appearances assigned. Meshes without appearances will render as invisible.`);
    	}
    	
    	for (var j = 0; j < appearance.chunkMaterials.length; j++) {
    		if (!(appearance.chunkMaterials[i] in materialNames)) {
    			Logger.Warning(`Appearance ${appearance.name}: Chunk material ${appearance.chunkMaterials[j]} doesn't exist, submesh will render as invisible.`);
    		}
    	}
    }

	return true;
};

success = main(JSON.parse(file)["Data"]["RootChunk"]);