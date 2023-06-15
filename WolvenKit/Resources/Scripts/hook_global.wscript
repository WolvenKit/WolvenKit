// @version 1.0

import * as Logger from 'Logger.wscript';
import * as FileValidation from 'Wolvenkit_FileValidation.wscript';
import Settings from 'hook_settings.wscript';

globalThis.onSave = function(ext, file) {
	const fileContent = JSON.parse(file);
	
	let success = true;
	switch(ext) {
		case "anims":
			FileValidation.validateAnimationFile(
				fileContent["Data"]["RootChunk"], 
				Settings.Anims.checkForDuplicates,
				Settings.Anims.printAnimationNames,
				Settings.Anims.targetAnimNames);
			break;
		case "app":
			if (fileContent["Data"]["RootChunk"].appearances.length > 0) {
				FileValidation.validateAppFile(
					fileContent["Data"]["RootChunk"], 
					Settings.App.validateRecursively);
			}
			break;
		case "csv":
			FileValidation.validateCsvFile(fileContent["Data"]["RootChunk"]);
			break;
		case "ent":
			FileValidation.validateEntFile(
				fileContent["Data"]["RootChunk"],
				Settings.Ent.validateRecursively);
			break;
		case "mesh":
			FileValidation.validateMeshFile(fileContent["Data"]["RootChunk"]);
			break;
		case "workspot":
			FileValidation.validateWorkspotFile(
				fileContent["Data"]["RootChunk"], 
				Settings.Workspot.fixIndexOrder,
				Settings.Workspot.showUnusedAnimsInFiles,
				Settings.Workspot.showUndefinedWorkspotAnims,
				Settings.Workspot.checkIdleAnimNames,
				Settings.Workspot.checkIdDuplication,
				Settings.Workspot.checkFilepaths,
				Settings.Workspot.checkLoadingHandles);
			file = JSON.stringify(fileContent);
			break;
	}

	return { success: success, file: file }
}

globalThis.onExport = function(path, settings) {
	const json = JSON.parse(settings);
	// Logger.Info(json);
	return { settings: JSON.stringify(json) }
}

globalThis.onPreImport = function(path, settings) {
	const json = JSON.parse(settings);
	// Logger.Info(json);
	return { settings: JSON.stringify(json) }
}

// Not yet implemented
globalThis.onPostImport = function(path, settings) {
	Logger.Info(settings);
	return { success: true }
}