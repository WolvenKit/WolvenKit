const Settings = {
	Anims: {
		// Set this to "true" to have the script print all animation names to console
		printAnimationNames: false,
		
		// Set this to "false" to disable check for duplicate anims
		checkForDuplicates: true,
		
		// ???
		targetAnimNames: []
	},
	App: {
		// Set this to "false" to disable recursive verification of app files
		validateRecursively: true
	},
	Ent: {
		// Set this to "false" to disable recursive verification of root entity files
		validateRecursively: true
	},
	Workspot: {
		// Set this to "false" to stop this script from fixing the index order for you.
		fixIndexOrder: true,
		
		// Set this to "false" to suppress the warning "Items from .anim files not found in .workspot:"
		showUnusedAnimsInFiles: true,
		
		// Set this to "false" to suppress the warning "Items from .workspot not found in .anim files:"
		showUndefinedWorkspotAnims: true,
		
		// Set this to "false" to suppress the info about "idle animation name "xxxx" not found in […]""
		checkIdleAnimNames: true,
		
		// Set this to "false" to suppress the info about "id already used by…" (Why would you want that? It breaks things!)
		checkIdDuplication: true,
		
		// Set this to "false" to suppress the warning "File … not found in game or project files"
		checkFilepaths: true,
		
		// Set this to "false" to suppress the warning "finalAnimSet x: animation "abc" not found in…"
		checkLoadingHandles: true
	}
}

export default Settings;