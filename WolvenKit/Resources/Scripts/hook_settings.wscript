// @version 1.0

const Settings = {
	Anims: {
		/*
		 * Set this to "true" to have the script print all animation names to console
		 */
		printAnimationNames: false,
		
		/*
		 * Set this to "false" to disable check for duplicate anims
		 */
		checkForDuplicates: true,
		
		// ???
		targetAnimNames: []
	},
	App: {
		/*
		 * Set this to "true" to enable recursive verification in app files
		 * (e.g. to check the appearance names against meshes)
		 */
		validateRecursively: true,

		/*
		 * Set this to "false" to disable warnings about unresolved depot paths
		 * e.g. "component: unknown resource in depot path"
		 */
		showUnresolvedDepotPathWarnings: true
	},
	Csv: {
		/*
		 * Set this to "false" to disable the attempted resolution of resource paths
		 * e.g. "component: unknown resource in depot path"
		 */
		checkProjectResourcePaths: true
	},
	Ent: {
		/*
		 * Set this to "false" to disable recursive verification of linked .app files and meshes
		 * (e.g. if this is taking too long for your liking)
		 */
		validateRecursively: true,

		/*
		 * Set this to "false" to disable warnings about unresolved depot paths
		 * e.g. "component: unknown resource in depot path"
		 */
		showUnresolvedDepotPathWarnings: true
	},
	Mesh: {},
	Workspot: {
		/*
		 * Set this to "false" to stop this script from fixing the index order for you.
		 * currently deactivated because JS truncates uint64 and fucks up everything for everyone 
		 */
		fixIndexOrder: false,
		
		/*
		 * Set this to "false" to suppress the warning "Items from .anim files not found in .workspot:"
		 */
		showUnusedAnimsInFiles: true,
		
		/*
		 * Set this to "false" to suppress the warning "Items from .workspot not found in .anim files:"
		 */
		showUndefinedWorkspotAnims: true,
		
		/*
		 * Set this to "false" to suppress the info about "idle animation name "xxxx" not found in […]""
		 */
		checkIdleAnimNames: true,
		
		/*
		 * Set this to "false" to suppress the info about "id already used by…" (Why would you want that? It breaks things!)
		 */
		checkIdDuplication: true,
		
		/*
		 * Set this to "false" to suppress the warning "File … not found in game or project files"
		 */
		checkFilepaths: true,
		
		/*
		 * Set this to "false" to suppress the warning "finalAnimSet x: animation "abc" not found in…"
		 */
		checkLoadingHandles: true
	}
}

export default Settings;