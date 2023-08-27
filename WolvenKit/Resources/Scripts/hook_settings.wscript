// @version 1.0

const Settings = {
	Enabled: true,
    Anims: {
        /*
         * Set this to "false" to disable file validation for .anims files.
         */
        Enabled: true,
        /*
         * Set this to "true" to have the script print all animation names to console
         */
        printAnimationNames: false,

        /*
         * Set this to "false" to disable check for duplicate anims
         */
        checkForDuplicates: true,
    },
    App: {
        /*
         * Set this to "false" to disable file validation for .app files.
         */
        Enabled: true,
        /*
         * Set this to "false" to disable recursive verification in app files
         * (e.g. to check the appearance names against meshes)
         */
        validateRecursively: true,
        /*
         * Set this to "false" to disable warnings about duplicate component names,
         * e.g. "] The following components are defined more than once: [ pants_black ]"
         */
        checkComponentNameDuplication: true,
        /*
         * Set this to "false" to disable warnings about inplaceResources potentially crashing your game.
         */
        checkForCrashyDependencies: true,
        /*
         * Set this to "false" to disable warnings about resolvedDependencies. TODO: Can this go?
         */
        checkForResolvedDependencies: true,
        /*
         * Set this to "false" to disable warnings about components with the same name but different meshes.
         * e.g. if you're loading different variants from the same app file depending on a tag.
         */
        checkPotentialOverrideCollisions: false,
        /*
         * Set this to "false" to disable warnings about cook data. 
         * This is the reason why the cookedAppsNulled mod exists.
         */
        checkCookPaths: true,
    },
    Csv: {
        /*
         * Set this to "false" to disable file validation for .csv files.
         */
        Enabled: true, 
        /*
         * Set this to "false" to disable the attempted resolution of resource paths
         * e.g. "component: unknown resource in depot path"
         */
        checkProjectResourcePaths: true,
        /*
         * Set this to "false" to disable warnings if a value looks like it's not a depot path, e.g.
         * "One or more entries couldn't be resolved to depot paths. Is this a valid factory?"
         */
        warnAboutInvalidDepotPaths: true
    },
    Ent: {
        /*
         * Set this to "false" to disable file validation for .ent files.
         */
        Enabled: true,
        /*
         * Set this to "false" to disable recursive verification of linked .app files and meshes
         * (e.g. if this is taking too long for your liking)
         */
        validateRecursively: true,

        /*
         * Set this to "false" to disable warnings about duplicate component names,
         * e.g. "] The following components are defined more than once: [ pants_black ]"
         */
        checkComponentNameDuplication: false,
        
        /*
         * Checks for ArchiveXL >= 1.5's dynamic appearance activator by checking for empty appearance names
         * in the root entity, or the presence of string substitution in nested files.
         */
        checkDynamicAppearanceTag: true,
    },
    Json: {
        /*
         * Set this to "false" to disable file validation for .json files.
         */
        Enabled: true,
        /*
         * Check for primary key duplication and duplicate entries? 
         */
        checkDuplicateKeys: true,
        /*
         * Check for duplicate translation entries (same text) 
         */
        checkDuplicateTranslations: true,        
        /*
         * Warn if default value isn't set? 
         */
        checkEmptyFemaleVariant: true,
    },
    Mesh: {
        /*
         * Set this to "false" to disable file validation for .mesh files.
         */
        Enabled: true,
        /*
         * Should file validation check materials along the daisy chain? (Only outside of /base) 
         */
        validateMaterialsRecursively: true,        
        /*
         * If you're using placeholder materials, should file validation warn you about properties in values[]? 
         */
        validatePlaceholderValues: false,        
        /*
         * If you're using placeholder materials, should file validation check depot paths? 
         * Incorrect depot paths will cause crashes, so you might want to leave this enabled.
         */
        validatePlaceholderMaterialPaths: true,        
        /*
         * Should file validation warn you if two of your materials use the same mlsetup?
         */
        checkDuplicateMlSetupFilePaths: true,        
    },
    Mi: {
        /*
         * Set this to "false" to disable file validation for .mi files.
         */
        Enabled: true,
        /*
         * Should file validation check materials along the daisy chain? (Only outside of /base) 
         */
        validateRecursively: true,
    },
    Workspot: {
        /*
         * Set this to "false" to disable file validation for .workspot files.
         */
        Enabled: true,
        /*
         * Disable reordering of file indices in the workspot. 
         * (This feature requires that you close and reopen your file after saving, which the message will tell you about)
         */
        fixIndexOrder: true,

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
         * Display info about "id already used by…". This will do nothing if you have fixIndexOrder enabled!
         */
        checkIdDuplication: true,

        /*
         * Set this to "false" to suppress checking of nested files in workspot.
         */
        checkFilepaths: true,
    }
};

export default Settings;
