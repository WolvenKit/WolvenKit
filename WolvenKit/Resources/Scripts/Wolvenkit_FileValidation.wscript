import * as Logger from 'Logger.wscript';
import * as TypeHelper from 'TypeHelper.wscript';
import {CName} from "TypeHelper.wscript";

/*
 *     .___                      __           .__                                     __  .__    .__           _____.__.__
 *   __| _/____     ____   _____/  |_    ____ |  |__ _____    ____    ____   ____   _/  |_|  |__ |__| ______ _/ ____\__|  |   ____
 *  / __ |/  _ \   /    \ /  _ \   __\ _/ ___\|  |  \\__  \  /    \  / ___\_/ __ \  \   __\  |  \|  |/  ___/ \   __\|  |  | _/ __ \
 * / /_/ (  <_> ) |   |  (  <_> )  |   \  \___|   Y  \/ __ \|   |  \/ /_/  >  ___/   |  | |   Y  \  |\___ \   |  |  |  |  |_\  ___/
 * \____ |\____/  |___|  /\____/|__|    \___  >___|  (____  /___|  /\___  / \___  >  |__| |___|  /__/____  >  |__|  |__|____/\___  >
 *      \/             \/                   \/     \/     \/     \//_____/      \/             \/        \/                      \/
 *
 * It will be overwritten by Wolvenkit whenever there is a new version and you will LOSE YOUR CHANGES.
 * If you want your custom version, create a copy of this file, remove
 * the Wolvenkit_ prefix from the path, and edit the importing files.
 */

/**
 * Workaround for CName heisenbug that happened on my machine. It might happen on your machine as well!
 * Best leave it in for now.
 */
function stringifyPotentialCName(cnameOrString, _info) {
    if (!cnameOrString) return undefined;
    if (typeof cnameOrString === 'string') {
        return cnameOrString;
    }
    if (typeof cnameOrString === 'bigint') {
        return `${cnameOrString}`;
    }
    const ret = !!cnameOrString.$value ? cnameOrString.$value : cnameOrString.value;
    if (ret?.indexOf && ret.indexOf(" ") >= 0) {
        const info = _info ? `${_info}: '${ret}' ` : `'${ret}' `;
        if (ret.trim() !== ret) {
            Logger.Error(`${info}has trailing or leading spaces! Make sure to remove them, or your item won't load!`);    
        } else {
            Logger.Warning(`${info}includes spaces. Please use _ instead.`);            
        }
    }
    return ret;
}

/**
 * For ArchiveXL path validation: does the string contain the same number of { and }?
 * Will set flag to allow checking for root entity
 * 
 * @param inputString depot path to check
 */
function checkCurlyBraces(inputString) {
   if (!inputString.includes('{') || inputString.includes('}')) {
       return true;
   }
    isUsingSubstitution = true;
   
    let openBraceCount = 0;
    let closeBraceCount = 0;

    for (let i = 0; i < inputString.length; i++) {
        if (inputString[i] === '{') {
            openBraceCount++;
        } else if (inputString[i] === '}') {
            closeBraceCount++;
        }
    }

    return openBraceCount === closeBraceCount;
}

function hasUppercase(str) {
    if (!str || !/[A-Z]/.test(str)) return false;
    hasUppercasePaths = true;
    return true;
}

function isNumericHash(str) {
    return !!str && /^\d+$/.test(str);
}

/**
 * @param _depotPath the depot path to analyse
 * @param _info info string for the user
 * @param allowEmpty suppress warning if depot path is unset (partsOverrides will target player entity)
 */
function checkDepotPath(_depotPath, _info, allowEmpty = false) {
    // Don't validate if uppercase file names are present
    if (hasUppercasePaths) {
        return false;
    }
    const info = _info ? `${_info}: ` : '';
    
    // if (!_info) {         throw new Error();     }
    
    const depotPath = stringifyPotentialCName(_depotPath) || '';
    if (!depotPath) {
        if (allowEmpty) {
            return true;
        }
        Logger.Warning(`${info}DepotPath not set`);
        return false;
    }
    
    // check if the path has uppercase characters
    if (hasUppercase(depotPath)) {        
        return false;
    }

    // Check if the file is a numeric hash
    if (isNumericHash(depotPath)) {
        Logger.Warning(`${info}No depot path set, only hash given`);
        return false;
    }
    
    if (depotPath.startsWith(ARCHIVE_XL_VARIANT_INDICATOR) && !(depotPath.includes("{"))) {
        Logger.Error(`${info}${depotPath} starts with an * but doesn't contain substitution. This will crash your game!`);
        return false;
    }
    // check if the path is using substitutions
    if (!checkCurlyBraces(depotPath)) {
        Logger.Warning(`${info}${depotPath}'s { and } count doesn't match. Did you make a typo?`);
    }

    // ArchiveXL 1.5 variant magic requires checking this in a loop
    const componentMeshPaths = getArchiveXlMeshPaths(stringifyPotentialCName(depotPath));
    let ret = true;
    
    componentMeshPaths.forEach((resolvedMeshPath) => {
        if (pathToCurrentFile === resolvedMeshPath) {
            Logger.Error(`${info}Depot path ${resolvedMeshPath} references itself. This _will_ crash the game!`);
            ret = false;
            return;
        }
        // all fine
        if (wkit.FileExists(resolvedMeshPath)) {
            return;
        }        
        // File does not exist
        if (shouldHaveSubstitution(resolvedMeshPath)) {
            if (!resolvedMeshPath.startsWith(ARCHIVE_XL_VARIANT_INDICATOR)) {
                Logger.Warning(`${info}${resolvedMeshPath}: Not starting with *, substitution disabled`);
            } else if (!checkCurlyBraces(resolvedMeshPath)) {
                Logger.Warning(`${info}${resolvedMeshPath}: Number of { not matching number of }`);
            } else {
                Logger.Info(`${info}${resolvedMeshPath}: substitution couldn't be resolved. It's either invalid or not yet supported in Wolvenkit.`);                
            }
        } else {
            Logger.Warning(`${info}${resolvedMeshPath} not found in project or game files`);                
        }
        ret = false;
    })
    return ret;
}

const validMaterialFileExtensions = [ '.mi', '.mt', '.remt' ];
function validateShaderTemplate(depotPath, _info) {
    if (!checkDepotPath(depotPath, _info)) {
        return;
    }
    
    // shouldn't be falsy, checkDepotPath should take care of that, but better safe than sorry
    const basePathString = stringifyPotentialCName(depotPath) || '';
    
    const extensionParts = basePathString.match(/[^.]+$/);
    
    if (!extensionParts || validMaterialFileExtensions.includes(extensionParts[0])) {
        Logger.Warning(`${_info ? `${_info}: ` : ''}Invalid base material: ${basePathString}`);
    }
}
export let hasUppercasePaths = false;

export let isDataChangedForWriting = false;

/** Is the root entity using a dynamic appearance? */
let isDynamicAppearance = false;

/** Are path substitutions used in the .app or the mesh entity?  */
let isUsingSubstitution = false;

function shouldHaveSubstitution(str, ignoreAsterisk=false) {
    if (!str || typeof str === "bigint") return false; 
    return (!ignoreAsterisk && str.trim().startsWith(ARCHIVE_XL_VARIANT_INDICATOR)) 
        || str.includes('{') || str.includes('}');
}

/**
 * Matches placeholders such as 
 * ----------------
 * ================
 */
const PLACEHOLDER_NAME_REGEX = /^[^A-Za-z0-9]*$/;

/** Warn about self-referencing resources */
let pathToCurrentFile = '';

export function setPathToCurrentFile(path) {
    pathToCurrentFile = path;
}

function resetInternalFlagsAndCaches() {
    isDataChangedForWriting = false;
    alreadyVerifiedAppFiles.length = 0;
    hasUppercasePaths = false;
    isDynamicAppearance = false;
    isUsingSubstitution = false;
    
    // ent file
    hasEmptyAppearanceName =false;
}

//#region animFile

/*
 * ===============================================================================================================
 *  anim file
 * ===============================================================================================================
 */

/* ****************************************************** */

// map: numeric anim index to name. Necessary for duplication error messages.
const animNamesByIndex = {};

// all known animation names (without duplicates)
const animNames = [];

let animAnimSettings = {};

function animFile_CheckForDuplicateNames() {
    const map = new Map();
    animNames.forEach(a => map.set(a, (map.get(a) || 0) + 1));
    const duplicateNames = animNames.filter(a => map.get(a) > 1);

    if (duplicateNames.length === 0) {
        return;
    }

    Logger.Info(`Duplicate animations found (you can ignore these):`);
    duplicateNames.forEach((animName) => {
        const usedIndices = Object.keys(animNamesByIndex)
            .filter((key) => animNamesByIndex[key] === animName)
            .map((idx) => `${idx}`.padStart(2, '0'));
        Logger.Info(`        [ ${usedIndices.join(', ')} ]: ${animName}`);
    });
}

export function validateAnimationFile(animAnimSet, _animAnimSettings) {
    if (!_animAnimSettings?.Enabled) {
        return;
    }
    
    animAnimSettings = _animAnimSettings;
    resetInternalFlagsAndCaches();

    if (animAnimSet["Data"] && animAnimSet["Data"]["RootChunk"]) {
        validateAnimationFile(animAnimSet["Data"]["RootChunk"], animAnimSettings);
        return;
    }

    // collect names
    for (let index = 0; index < animAnimSet.animations.length; index++) {
        const animName = stringifyPotentialCName(animAnimSet.animations[index].Data.animation.Data.name);
        animNames.push(animName);
        // have a key-value map for error messages
        animNamesByIndex[index] = animName;
    }

    if (animAnimSettings.checkForDuplicates) {
        animFile_CheckForDuplicateNames();
    }

    if (animAnimSettings.printAnimationNames) {
        Logger.Info(`Animations in current file:\n\t${animNames.join('\n\t')}`);
    }
}

//#endregion

//#region appFile

// map: { 'path/to/file.mesh': ['default', 'red', 'black'] };
const appearanceNamesByMeshFile = {};

// map: { 'path/to/file.mesh', [ 'not_found1', 'not_found2' ] }
let invalidVariantAndSubstitutions = {};

// map: { 'appearance_in_app_file', [ 'error description 1', 'error description 2' ] }
let appearanceErrorMessages = {};

/*
 * appearance collection: gather data and print them in one block rather than spamming when they're found
 */
// map: { 'path/to/file.mesh', [ 'not_found1', 'not_found2' ] }
let meshAppearancesNotFound = {};

// map: { 'path/to/file.mesh', [ 'component_with_broken_appearance1', 'component_with_broken_appearance2' ] }
let meshAppearancesNotFoundByComponent = {};
/*
 * /appearance collection
 */

function printInvalidAppearanceWarningIfFound() {
    const warningKeys = Object.keys(meshAppearancesNotFoundByComponent) || [];
    if (warningKeys.length) { 
        Logger.Warning('Mesh appearances not found. Here\'s a list:');        
    }
    warningKeys.forEach((meshPath) => {
        const componentNames = meshAppearancesNotFoundByComponent[meshPath] || [];
        const appearanceNames = meshAppearancesNotFound[meshPath] || [];

        const definedAppearances = component_collectAppearancesFromMesh(meshPath).join(', ')
        Logger.Warning(`${meshPath} with the appearances [ ${definedAppearances} }`);
        
        // print as table
        Logger.Warning(`  ${'Source'.padEnd(50, ' ')} | Appearance`);
        // print table entries
        for (let i = componentNames.length; i > 0; i -= 1) {
            const calledFrom = componentNames.pop();
            const appearanceName = appearanceNames.pop();
            Logger.Warning(`  ${calledFrom.padEnd(50, ' ')} | ${appearanceName}`);
        }
    })
    
    const appearanceErrors = Object.keys(appearanceErrorMessages) || [];
    if (!appearanceErrors.length) { 
        return;
    }    
    Logger.Warning('Mesh appearances have errors. Here\'s a list:');
    appearanceErrors.forEach((key) => {
        const allErrors = (appearanceErrorMessages[key] || []);
        const foundErrors = allErrors.filter(function(item, pos, self) {
            return self.indexOf(item) === pos;
        });
        foundErrors.forEach((err) => Logger.Warning(err));
    })
}

function printSubstitutionWarningsIfFound() {
    const warningKeys = Object.keys(invalidVariantAndSubstitutions) || [];
    if (!warningKeys.length) {
        return;
    }
    
    Logger.Info('Some of your components seem to include ArchiveXL dynamic variants, but they may have errors:');    
    warningKeys.forEach((warningSource) => {
        const warnings = (invalidVariantAndSubstitutions[warningSource] || []).filter(function(item, pos, self) {
            return self.indexOf(item) === pos;
        });
        if (warnings.length) {
            const output = warnings.length <= 1 ? `${warnings}` : `\n  ${warnings.join(',\n ')}`
            Logger.Warning(`${warningSource}: ${output}`);
        }
    });
    
}


// map: { 'myComponent4711': 'path/to/file.mesh' };
let meshesByComponentName = {};

// map: { 'base/mana/mesh_entity.ent': ['path/to/file.mesh', 'path_to_other_file.mesh'] };
let meshesByEntityPath = {};

let isInvalidVariantComponent = false;


/* map: {
 *	'path/to/file.mesh':  'myComponent4711',
 *	'path/to/file2.mesh': 'myComponent4711',
 * };
 */
const componentNameCollisions = {};

// [ myComponent4711, black_shirt ]
const overriddenComponents = [];

const componentOverrideCollisions = [];

/**
 * List of mesh paths from .app appearance's components. 
 * Will be used to check against meshesByEntityPath[entityDepotPath] for duplications.
 */
const meshPathsFromComponents = [];

/**
 * For ent files: Don't run file validation twice
 */
const alreadyVerifiedAppFiles = [];

let appFileSettings = {};

function component_collectAppearancesFromMesh(componentMeshPath) {
    if (!componentMeshPath || /^\d+$/.test(componentMeshPath) || !wkit.FileExists(componentMeshPath)) return;
    if (undefined === appearanceNamesByMeshFile[componentMeshPath] ) {
        try {
            const fileContent = wkit.LoadGameFileFromProject(componentMeshPath, 'json');            
            const mesh = TypeHelper.JsonParse(fileContent);
            if (!mesh || !mesh.Data || !mesh.Data.RootChunk || !mesh.Data.RootChunk.appearances) {
                return;
            }
            appearanceNamesByMeshFile[componentMeshPath] = mesh.Data.RootChunk.appearances
                .map((appearance) => stringifyPotentialCName(appearance.Data.name));              
        } catch (err) {
            Logger.Warning(`Couldn't parse ${componentMeshPath}`);
            appearanceNamesByMeshFile[componentMeshPath] = null;
        }
    }
    return appearanceNamesByMeshFile[componentMeshPath] || [];
}

function appFile_collectComponentsFromEntPath(entityDepotPath, validateRecursively, info) {
    if (!wkit.FileExists(entityDepotPath)) {
        Logger.Warn(`Trying to check on partsValue '${entityDepotPath}', but it doesn't exist in game or project files`);
        return;
    }

    // We're collecting all mesh paths. If we have never touched this file before, the entry will be nil.
    if (undefined !== meshesByEntityPath[entityDepotPath]) {
        return;
    }
    
    const meshesInEntityFile = [];
    if (validateRecursively) {        
        const fileContent = wkit.LoadGameFileFromProject(entityDepotPath, 'json');
        
        // fileExists has been checked in validatePartsOverride
        const entity = TypeHelper.JsonParse(fileContent);
        const components = entity && entity.Data && entity.Data.RootChunk ? entity.Data.RootChunk.components || [] : [];
        isInvalidVariantComponent = false;
        for (let i = 0; i < components.length; i++) {
            const component = components[i];
            entFile_appFile_validateComponent(component, i, validateRecursively, `${info}.components[${i}]`);
            const meshPath = component.mesh ? stringifyPotentialCName(component.mesh.DepotPath) : '';
            if (meshPath && !meshesInEntityFile.includes(meshPath)) {
                meshesInEntityFile.push(meshPath);
            }
        } 
    }
    
    meshesByEntityPath[entityDepotPath] = meshesInEntityFile;

}

function appearanceNotFound(meshPath, meshAppearanceName, calledFrom) {
    meshAppearancesNotFound[meshPath] ||= [];
    meshAppearancesNotFound[meshPath].push(meshAppearanceName);
    
    meshAppearancesNotFoundByComponent[meshPath] ||= [];
    meshAppearancesNotFoundByComponent[meshPath].push(calledFrom);
}

function resetAppearanceNotFoundLookup() {
    
}

function appFile_validatePartsOverride(override, index, appearanceName) {
    
    let info = `${appearanceName}.partsOverride[${index}]`;    
    const depotPath = stringifyPotentialCName(override.partResource.DepotPath, info);

    if (!checkDepotPath(depotPath, info, true)) {
        return;
    }
    
    if (depotPath && !depotPath.endsWith(".ent")) {
        Logger.Error(`${info}: ${depotPath} does not point to an entity file! This can crash your game!`);
        return;
    }

    if (isDynamicAppearance && depotPath && shouldHaveSubstitution(depotPath)) {
        Logger.Warning(`${info}: Substitution in depot path not supported.`);
    }
    
    const appFilePath = pathToCurrentFile;
    pathToCurrentFile = depotPath;

    for (let i = 0; i < override.componentsOverrides.length; i++) {
        const componentOverride = override.componentsOverrides[i];
        const componentName = componentOverride.componentName.value || '';
        overriddenComponents.push(componentName);

        const meshPath = componentName && meshesByComponentName[componentName] ? meshesByComponentName[componentName] : '';
        if (meshPath && !checkDepotPath(meshPath, info)) {
            const appearanceNames = component_collectAppearancesFromMesh(meshPath);
            const meshAppearanceName = stringifyPotentialCName(componentOverride.meshAppearance);
            if (meshAppearanceName.startsWith(ARCHIVE_XL_VARIANT_INDICATOR)) {
                Logger.Info(`skipping dynamic appearance ${info} - not implemented yet`);
            } else if ((appearanceNames || []).length > 1 && !appearanceNames.includes(meshAppearanceName) && !componentOverrideCollisions.includes(meshAppearanceName)
            ) {
                appearanceNotFound(meshPath, meshAppearanceName, info);
            }
        }
    }
    
    // restore app file path 
    pathToCurrentFile = appFilePath;
    
}
function appFile_validatePartsValue(partsValueEntityDepotPath, index, appearanceName, validateRecursively) {    
    const info = `${appearanceName}.partsValues[${index}]`;
    
    if (!checkDepotPath(partsValueEntityDepotPath, info)) {
        return;
    }

    // save current file path, then change it to nested file  
    const appFilePath = pathToCurrentFile;
    pathToCurrentFile = partsValueEntityDepotPath;
    appFile_collectComponentsFromEntPath(partsValueEntityDepotPath, validateRecursively, `${info}`);
    pathToCurrentFile = appFilePath;
}

function appFile_validateAppearance(appearance, index, validateRecursively, validateComponentCollision) {
    // Don't validate if uppercase file names are present
    if (hasUppercasePaths) {
        return;
    }
    
    let appearanceName = stringifyPotentialCName(appearance.Data ? appearance.Data.name : '');

    if (appearanceName.length === 0 || /^[^A-Za-z0-9]+$/.test(appearanceName)) return;
    const appearanceErrors = [];
    
    if (!appearanceName) {
        appearanceName = `appearances[${index}]`;
        appearanceErrorMessages[appearanceName].push(`appearance definition #${index} has no name yet`);
    }
    
    appearanceErrorMessages[appearanceName] ||= [];

    // check override
    if (appFileSettings.checkCookPaths && appearance.Data.cookedDataPathOverride) {        
        const potentialCookedOverride = stringifyPotentialCName(appearance.Data.cookedDataPathOverride.DepotPath) || '';        
        
        if (potentialCookedOverride && potentialCookedOverride !== "0") {
            if (/[A-Z]/.test(potentialCookedOverride)) {
                hasUppercasePaths = true;
                return;
            }
            appearanceErrorMessages[appearanceName].push(`Cooked data override found. Consider deleting it.`);
        }
    }

    if (alreadyDefinedAppearanceNames.includes(appearanceName)) {
        appearanceErrorMessages[appearanceName].push(`An appearance with the name ${appearanceName} is already defined in .app file`);
    } else {
        alreadyDefinedAppearanceNames.push(appearanceName);
    }

    // we'll collect all mesh paths that are linked in entity paths
    meshPathsFromComponents.length = 0;
    
    // might be null
    const components = appearance.Data.components || [];    
    
    if (isDynamicAppearance && components.length) {
        appearanceErrorMessages[appearanceName].push(`.app ${appearanceName} is loaded as dynamic, but it has components outside of a mesh entity. They will be IGNORED.`)
    } else {
        for (let i = 0; i < components.length; i++) {
            const component = components[i];
            if (appFileSettings?.validateRecursively || validateRecursively) {
                entFile_appFile_validateComponent(component, i, validateRecursively, `app.${appearanceName}`);
            }
            if (component.mesh) {
                const meshDepotPath = stringifyPotentialCName(component.mesh.DepotPath);
                meshPathsFromComponents.push(meshDepotPath);
            }
        }        
    }

    const meshPathsFromEntityFiles = [];
    
    // check these before the overrides, because we're parsing the linked files
    for (let i = 0; i < appearance.Data.partsValues.length; i++) {
        const partsValue = appearance.Data.partsValues[i];
        const depotPath = stringifyPotentialCName(partsValue.resource.DepotPath);
        appFile_validatePartsValue(depotPath, i, appearanceName, validateRecursively);
        (meshesByEntityPath[depotPath] || []).forEach((path) => meshPathsFromEntityFiles.push(path));
        if (isDynamicAppearance && depotPath && shouldHaveSubstitution(depotPath)) {
            Logger.Warning(`${appearanceName}.partsValues[${i}]: Substitution in depot path not supported.`);
        }
    }

    if (validateComponentCollision) {
        Object.values(componentNameCollisions)
            .filter((name) => overriddenComponents.includes(name))
            .filter((name) => !componentOverrideCollisions.includes(name))
            .forEach((name) => componentOverrideCollisions.push(name));

        if ((componentOverrideCollisions?.length || 0) > 0) {
            Logger.Info("Inside partsValues, validation found components of the same name pointing at different meshes.");
            Logger.Info("Ignore this if the files below are pointing at gendered/camera variants. Found the following meshes/component names:");
            Object.keys(componentNameCollisions).forEach((meshPath) => {
                Logger.Warning(`${componentNameCollisions[meshPath]}: ${meshPath}`);
            });
        }
    }

    const allComponentNames = components.map((component) => stringifyPotentialCName(component.name));
    const numAmmComponents = allComponentNames.filter((name) => !!name && name.startsWith('amm_prop_slot')).length;
    if (numAmmComponents > 0 && numAmmComponents < 4 && !allComponentNames.includes('amm_prop_slot1')) {
        Logger.Info(`app[${appearanceName}] Is this an AMM prop appearance? Only components with the names "amm_prop_slot1" - "amm_prop_slot4" will support scaling.`);
    }

    // Dynamic appearances will ignore the components in the mesh. We'll use 'isUsingSubstitution' as indicator,
    // since those only work for dynamic appearances, and the app file doesn't know if it's dynamic otherwise. 
    if (!isDynamicAppearance && !isUsingSubstitution) {
        const duplicateMeshes = meshPathsFromComponents
            .filter((path, i, array) => !!path && array.indexOf(path) === i) // only unique
            .filter((path) => meshPathsFromEntityFiles.includes(path))

        if (duplicateMeshes.length > 0) {
            Logger.Warning(`${appearanceName}: You are adding meshes via partsValues (entity file) AND components. To avoid visual glitches and broken appearances, use only one!`);
            duplicateMeshes.forEach((path) => {
                Logger.Warning(`\t\t${path}`);
            })
        }
    }
    
    for (let i = 0; i < appearance.Data.partsOverrides.length; i++) {
        appFile_validatePartsOverride(appearance.Data.partsOverrides[i], i, appearanceName);
    }
    
    if (!appearanceErrorMessages[appearanceName]?.length) {
        delete appearanceErrorMessages[appearanceName];
    }
}

export function validateAppFile(app, _appFileSettings) {
    // invalid app file - not found
    if (!app || !_appFileSettings.Enabled) {
        return;
    }
    
    appFileSettings = _appFileSettings;

    resetInternalFlagsAndCaches();

    _validateAppFile(app, _appFileSettings?.validateRecursively, false);

}

function _validateAppFile(app, validateRecursively, calledFromEntFileValidation) {
    // invalid app file - not found
    if (!app) {
        return;
    }

    // empty array with name collisions
    componentOverrideCollisions.length = 0;
    alreadyDefinedAppearanceNames.length = 0;

    meshesByComponentName = {};

    const validateCollisions = calledFromEntFileValidation 
        ? entSettings.checkComponentNameDuplication
        : appFileSettings.checkComponentNameDuplication;
    
    if (app["Data"] && app["Data"]["RootChunk"]) {
        return _validateAppFile(app["Data"]["RootChunk"], validateRecursively, calledFromEntFileValidation);
    }  
    
    invalidVariantAndSubstitutions = {};
    
    meshAppearancesNotFound = {};
    meshAppearancesNotFoundByComponent = {};
    
    appearanceErrorMessages = {};

    for (let i = 0; i < app.appearances.length; i++) {
        const appearance = app.appearances[i];
        appFile_validateAppearance(appearance, i, validateRecursively, validateCollisions);
    }

    if (appFileSettings.checkCookPaths && app.commonCookData && stringifyPotentialCName(app.commonCookData.DepotPath)) {
        Logger.Warning('CommonCookData found in app file\'s root. Consider deleting it.');
    }

    printInvalidAppearanceWarningIfFound();
}

//#endregion

const ARCHIVE_XL_VARIANT_INDICATOR = '*';

// TODO read ArchiveXL stuff from yaml

/**
 * A list of yaml file paths with an array of all variants
 * [ key: string ]: { 0: [], 1: [], 2: [] }
 */
const yamlFilesAndVariants = {};
function getVariantsFromYaml() {
    const variants = [];
}

function getArchiveXLVariantComponentNames() {
    
}

const archiveXLVarsAndValues = {
    '{gender}': ['m', 'w'],
    '{camera}': ['fpp', 'tpp'],
    '{legs_state}': ['lifted', 'flat', 'high_heels', 'flat_shoes'],
}


function getArchiveXlMeshPaths(depotPath) {
    if (!depotPath || typeof depotPath === "bigint") {
        return [];
    }
    if (!depotPath.startsWith(ARCHIVE_XL_VARIANT_INDICATOR)) {
        return [depotPath];
    }
    
    let paths = [];    
    if (!shouldHaveSubstitution(depotPath) || !checkCurlyBraces(depotPath)) {
        paths.push(depotPath);
    } else {
        Object.keys(archiveXLVarsAndValues).forEach((variantFlag) => {
            if (depotPath.includes(variantFlag)) {
                archiveXLVarsAndValues[variantFlag].forEach((variantReplacement) => {
                    paths.push(depotPath.replace(variantFlag, variantReplacement));
                });
            }
        });
    }
    
    // If nothing was substituted: We're done here
    if (!paths.length) {
        paths.push(depotPath.replace('*', ''));
    }
    
    let ret = [];
    paths.forEach((path) => {
        const resolvedPaths = getArchiveXlMeshPaths(path);
        ret = [...ret, ...resolvedPaths];        
    })
    
    // If nothing was substituted: We're done here
    return ret.map((path) => path.replace('*', ''));
}

//#region entFile
let entSettings = {};

/**
 * Will be used as a dynamic variant check
 */
let hasEmptyAppearanceName = false;

// for warnings
const CURLY_BRACES_WARNING = 'different number of { and }, check for typos';

//  for warnings
const MISSING_PREFIX_WARNING = 'not starting with *, substitution disabled';

const WITH_MESH = 'withMesh';
// For different component types, check DepotPath property
function entFile_appFile_validateComponent(component, _index, validateRecursively, info) {
    const componentName = stringifyPotentialCName(component.name) ?? '';
    let type = component.$type || '';
        
    // entGarmentSkinnedMeshComponent - entSkinnedMeshComponent - entMeshComponent
    if (component && component.mesh && component.mesh.DepotPath) {
        type = WITH_MESH;
    }


    // flag for mesh validation, in case this is called recursively from app file
    let hasMesh = false;
    switch (type) {
        case WITH_MESH:
            const canBeEmpty = componentName !== 'amm_prop_slot1' && componentName?.startsWith('amm_prop_slot');
            checkDepotPath(component.mesh.DepotPath, `${info}.${componentName}`, canBeEmpty);
            hasMesh = true;
            break;
        case 'workWorkspotResourceComponent':
            checkDepotPath(component.workspotResource.DepotPath, `${info}.${componentName}`);
            break;
        default:
            break;
    }

    if (!validateRecursively || !hasMesh || hasUppercasePaths) {
        // Logger.Error(`${componentMeshPath}: not validating mesh`);
        return;
    }
    
    const meshDepotPath = stringifyPotentialCName(component.mesh.DepotPath);
    const componentMeshPaths = getArchiveXlMeshPaths(meshDepotPath);
        
    componentMeshPaths.forEach((componentMeshPath) => {
        
        // check for component name uniqueness
        if (meshesByComponentName[componentName] && meshesByComponentName[componentName] !== componentMeshPath) {
            componentNameCollisions[componentMeshPath] = componentName;
            componentNameCollisions[meshesByComponentName[componentName]] = componentName;
        }
        
        meshesByComponentName[componentName] = componentMeshPath;
    
        if (/^\d+$/.test(componentMeshPath)) {
            return;
        }
        if (/[A-Z]/.test(componentMeshPath)) {
            hasUppercasePaths = true;
            return;
        }

        // ArchiveXL: Check for invalid component substitution
        
        const meshAppearanceName = stringifyPotentialCName(component.meshAppearance);
        const nameHasSubstitution = meshAppearanceName && meshAppearanceName.includes("{") || meshAppearanceName.includes("}")
        const pathHasSubstitution = componentMeshPath && componentMeshPath.includes("{") || componentMeshPath.includes("}")
        
        const localErrors = [];
        isUsingSubstitution = isUsingSubstitution || nameHasSubstitution || pathHasSubstitution;
        
        if (nameHasSubstitution && !checkCurlyBraces(meshAppearanceName)) {
            localErrors.push(CURLY_BRACES_WARNING);            
        } 
        if (nameHasSubstitution && !meshAppearanceName.startsWith(ARCHIVE_XL_VARIANT_INDICATOR)) {
            localErrors.push(MISSING_PREFIX_WARNING);            
        } 
        if (localErrors.length) {
            invalidVariantAndSubstitutions[info] ||= [];
            invalidVariantAndSubstitutions[info].push(`meshAppearance: ${meshAppearanceName}: ${localErrors.join(', ')}`);
            localErrors.length = 0;
        }
                
        if (pathHasSubstitution && !checkCurlyBraces(componentMeshPath)) {
            localErrors.push(CURLY_BRACES_WARNING);            
        } 
        if (pathHasSubstitution && !componentMeshPath.startsWith(ARCHIVE_XL_VARIANT_INDICATOR)) {
            localErrors.push(MISSING_PREFIX_WARNING);            
        } 
        if (localErrors.length) {
            invalidVariantAndSubstitutions[info] ||= [];
            invalidVariantAndSubstitutions[info].push(`DepotPath: ${componentMeshPath}: ${localErrors.join(', ')}`);
            localErrors.length = 0;
        }
        
        const meshAppearances = component_collectAppearancesFromMesh(componentMeshPath);
        if (!meshAppearances) { // for debugging
            // Logger.Error(`failed to collect appearances from ${componentMeshPath}`);
            return;
        }
        if (meshAppearanceName.startsWith(ARCHIVE_XL_VARIANT_INDICATOR)) {
            // TODO: ArchiveXL variant checking
        } else if (meshAppearances && meshAppearances.length > 0 && !meshAppearances.includes(meshAppearanceName)) {
            appearanceNotFound(componentMeshPath, meshAppearanceName, `ent component[${_index}] (${componentName})`);            
        }
    })
}

// Map: app file depot path name to defined appearances
const appearanceNamesByAppFile = {};

function getAppearanceNamesInAppFile(_depotPath) {
    const depotPath = stringifyPotentialCName(_depotPath);
    if (/[A-Z]/.test(depotPath)) {
        hasUppercasePaths = true;
        return;
    }
    if (!depotPath.endsWith('.app') || !wkit.FileExists(depotPath)) {
        appearanceNamesByAppFile[depotPath] = [];
    }
    if (!appearanceNamesByAppFile[depotPath]) {
        const fileContent = wkit.LoadGameFileFromProject(depotPath, 'json');
        const appFile = TypeHelper.JsonParse(fileContent);
        if (null !== appFile) {
            const appNames = (appFile.Data.RootChunk.appearances || [])
                .map((app, index) => stringifyPotentialCName(app.Data.name, `${depotPath}: appearances[${index}].name`))
                .filter((name) => !PLACEHOLDER_NAME_REGEX.test(name));
            appearanceNamesByAppFile[depotPath] = appNames;
        }
    }
    return appearanceNamesByAppFile[depotPath];
}

// check for name duplications
const alreadyDefinedAppearanceNames = [];

/**
 * @param appearance the appearance object
 * @param index numeric index (for debugging)
 * @param isRootEntity should we recursively validate the linked files?
 */
function entFile_validateAppearance(appearance, index, isRootEntity) {
    const appearanceName = (stringifyPotentialCName(appearance.name) || '');
    let appearanceNameInAppFile = (stringifyPotentialCName(appearance.appearanceName) || '').trim()
    if (!appearanceNameInAppFile || appearanceNameInAppFile === 'None') {
        appearanceNameInAppFile = appearanceName;
        hasEmptyAppearanceName = true;
    }
    
    // ignore separator appearances such as
    // =============================
    // -----------------------------
    if (appearanceName.length === 0 || PLACEHOLDER_NAME_REGEX.test(appearanceName)) {
        return;
    }

    const info = `.ent appearances.${appearanceName}`;

    if (isDynamicAppearance && appearanceName.includes('&')) {
        Logger.Error(`${info}: dynamic appearances can't support suffixes in the root entity!`);
    }
    
    if (!!appearanceName && alreadyDefinedAppearanceNames.includes(`ent_${appearanceName}`)) {
        Logger.Warning(`.ent file: An appearance with the name ${appearanceName} is already defined`);
    } else {
        alreadyDefinedAppearanceNames.push(`ent_${appearanceName}`);        
    }
    
    const appFilePath = stringifyPotentialCName(appearance.appearanceResource.DepotPath);
    if (!checkDepotPath(appFilePath, info)) {
        return;
    }
    
    if (!appFilePath.endsWith('app')) {
        Logger.Warning(`${info}: appearanceResource '${appFilePath}' does not appear to be an .app file`);
        return;
    }
    
    if (!entSettings.validateRecursively) {
        return;
    }
    
    const entFilePath = pathToCurrentFile;
    pathToCurrentFile = appFilePath; 
    
    const namesInAppFile = getAppearanceNamesInAppFile(appFilePath, appearanceName) || [];
    
    if (!namesInAppFile.includes(appearanceNameInAppFile)) {
        Logger.Warning(`appearance[${index}]: Can't find appearance ${appearanceNameInAppFile} in .app file ${appFilePath} (only defines [ ${namesInAppFile.join(', ')} ])`);
    }

    if (alreadyVerifiedAppFiles.includes(appFilePath) || hasUppercasePaths) {
        return;
    }

    alreadyVerifiedAppFiles.push(appFilePath);

    if (isRootEntity) {
        const fileContent = wkit.LoadGameFileFromProject(appFilePath, 'json');
        const appFile = TypeHelper.JsonParse(fileContent);
        if (null === appFile) {
            Logger.Warning(`File ${appFilePath} is supposed to exist, but couldn't be parsed.`);
        } else {
            _validateAppFile(appFile, entSettings.validateRecursively, true);
        }
    }

    pathToCurrentFile = entFilePath;
}

function validateAppearanceNameSuffixes(appearanceName, entAppearanceNames) {
    if (!appearanceName || !appearanceName.includes('&')) {
        return;
    }    
    if (appearanceName.includes('FPP') && !entAppearanceNames.includes(appearanceName.replace('FPP', 'TPP'))) {
        Logger.Warning(`${appearanceName}: You have not defined a third person appearance.`)
        Logger.Warning(`To avoid display bugs, add the tag "EmptyAppearance:TPP" or define "${appearanceName.replace('FPP', 'TPP')}" and point it to an empty appearance in the .app file.`);
    }
    if (appearanceName.includes('TPP') && !entAppearanceNames.includes(appearanceName.replace('TPP', 'FPP'))) {
        Logger.Warning(`${appearanceName}: You have not defined a first person appearance.`);
        Logger.Warning(`To avoid display bugs, add the tag "EmptyAppearance:FPP" or define "${appearanceName.replace('TPP', 'FPP')}" and point it to an empty appearance in the .app file.`);
    }
    if (appearanceName.includes('Male') && !entAppearanceNames.includes(appearanceName.replace('Male', 'Female'))) {
        Logger.Warning(`${appearanceName}: You have not defined a female variant.`);
        Logger.Warning(`To avoid display bugs, add the tag "EmptyAppearance:Female" or define "${appearanceName.replace('Male', 'Female')}" and point it to an empty appearance in the .app file.`);
    }
    if (appearanceName.includes('Female') && !entAppearanceNames.includes(appearanceName.replace('Female', 'Male'))) {
        Logger.Warning(`${appearanceName}: You have not defined a male variant.`);
        Logger.Warning(`To avoid display bugs, add the tag "EmptyAppearance:Female" or define "${appearanceName.replace('Female', 'Male')}" and point it to an empty appearance in the .app file.`);
    }
}

/**
 *
 * @param {*} ent The entity file as read from WKit
 * @param {*} _entSettings Settings object
 */
export function validateEntFile(ent, _entSettings) {
    if (!_entSettings?.Enabled) return; 
    entSettings = _entSettings;
    resetInternalFlagsAndCaches();
    
    if (ent["Data"] && ent["Data"]["RootChunk"]) {
        return validateEntFile(ent["Data"]["RootChunk"]);
    }

    const allComponentNames = [];
    const duplicateComponentNames = [];

    invalidVariantAndSubstitutions = {};
    meshAppearancesNotFound = {};
    meshAppearancesNotFoundByComponent = {};

    // Collect tags
    const visualTagList = (ent.visualTagsSchema?.Data?.visualTags?.tags || []).map((tag) => stringifyPotentialCName(tag));
    
    // we're using a dynamic appearance and need to consider that
    if (visualTagList.includes('DynamicAppearance')) {
        isDynamicAppearance = true
    }

    for (let i = 0; i < (ent.components?.length || 0); i++) {
        const component = ent.components[i];
        const componentName = stringifyPotentialCName(component.name) || `${i}`;
        entFile_appFile_validateComponent(component, i, _entSettings.validateRecursively, `ent.components.${componentName}`);
        (allComponentNames.includes(componentName) ? duplicateComponentNames : allComponentNames).push(componentName);
    }

    const numAmmComponents = allComponentNames.filter((name) => !!name && name.startsWith('amm_prop_slot')).length;
    if (numAmmComponents > 0 && numAmmComponents < 4 && !allComponentNames.includes('amm_prop_slot1')) {
        Logger.Info('Is this an AMM prop appearance? Only components with the names "amm_prop_slot1" - "amm_prop_slot4" will support scaling.');
    }

    if (entSettings.validateRecursively) {
        printInvalidAppearanceWarningIfFound();
        printSubstitutionWarningsIfFound();
    }

    if (_entSettings.checkComponentNameDuplication && duplicateComponentNames.length > 0) {
        Logger.Warning(`The following components are defined more than once: [ ${duplicateComponentNames.join(', ')} ]`)
    }

    if (_entSettings.checkForCrashyDependencies) {
        if ((ent.inplaceResources?.length || 0) > 0) {
            Logger.Error(`Your entity file defines inplaceResources. These might cause crashes due to asynchronous loading.`)    
        }        
    }
    if (_entSettings.checkForResolvedDependencies) {
        if ((ent.resolvedDependencies?.length || 0) > 0) {
            Logger.Info(`Your entity file defines resolvedDependencies, consider deleting them.`)
        }
    }

    // will be set to false in app file validation
    const _isDataChangedForWriting = isDataChangedForWriting;

    alreadyDefinedAppearanceNames.length = 0;
    alreadyVerifiedAppFiles.length = 0;

    hasEmptyAppearanceName = false;

    // prevent exceptions in borked entities
    if (!ent.appearances) {
        Logger.Error('.ent file: "appearances" doesn\'t exist. There\'s a good chance that this file won\'t work.');
        ent.appearances = [];
    }
    const entAppearanceNames = [];

    // if there is just one appearance and the root name ends in an underscore, assume as dynamic
    isDynamicAppearance ||= ent.appearances.length === 1 && stringifyPotentialCName(ent.appearances[0].name).endsWith('_');

    const _pathToCurrentFile = pathToCurrentFile;

    for (let i = 0; i < ent.appearances.length; i++) {
        const appearance = ent.appearances[i];
        entFile_validateAppearance(appearance, i, !entSettings.skipRootEntityCheck);
        entAppearanceNames.push((stringifyPotentialCName(appearance.name) || ''));
        pathToCurrentFile = _pathToCurrentFile;
    }
    // now validate names
    for (let i = 0; i < ent.appearances.length; i++) {
        const appearance = ent.appearances[i];
        validateAppearanceNameSuffixes(stringifyPotentialCName(appearance.name) || '', entAppearanceNames);
    }
    

    for (let i = 0; i < ent.inplaceResources.length; i++) {
        checkDepotPath(ent.inplaceResources[i].DepotPath, `inplaceResources[${i}]`);
    }
    for (let i = 0; i < ent.resolvedDependencies.length; i++) {
        checkDepotPath(ent.resolvedDependencies[i].DepotPath, `resolvedDependencies[${i}]`);
    }
    
    if (entSettings.checkDynamicAppearanceTag && (hasEmptyAppearanceName || isUsingSubstitution) && ent.appearances?.length) {
        const visualTagList = ent.visualTagsSchema?.Data?.visualTags?.tags || [];
        // Do we have a visual tag 'DynamicAppearance'?
        if (!visualTagList.map((tag) => stringifyPotentialCName(tag)).includes('DynamicAppearance')) {
            Logger.Info('If you are using dynamic appearances, you need to add the DynamicAppearance visualTag to the root entity.'
            + ' If you don\'t know what that means, check if your appearance names are empty or "None".' + 
                ' If everything is fine, ignore this warning.');            
        }
    }

    isDataChangedForWriting = _isDataChangedForWriting;
}

//#endregion


//#region meshFile
/*
 * ===============================================================================================================
 *  mesh file
 * ===============================================================================================================
 */

let meshSettings = {};

// scan materials, save for the next function
let materialNames = {};
let localIndexList = [];

// if checkDuplicateMlSetupFilePaths is used: warn user if duplicates exist in list
let listOfUsedMaterialSetups = {};

/**
 * Shared for .mesh and .mi files: will validate an entry of the values array of a material definition
 * 
 * @param key Key of array, e.g. BaseColor, Normal, MultilayerSetup
 * @param materialValue The material value definition contained within
 * @param info String for debugging, e.g. name of material and index of value
 * @param validateRecursively If set to true, file validation will try to follow the .mi chain
 */
function validateMaterialKeyValuePair(key, materialValue, info, validateRecursively) {    
    if (key === "$type" || hasUppercasePaths) {
        return;
    } 
    
    const materialDepotPath = stringifyPotentialCName(materialValue.DepotPath);

    if (hasUppercase(materialDepotPath) || isNumericHash(materialDepotPath)) {
        return;
    }    
    
    if (validateRecursively && materialDepotPath.endsWith('.mi') && !materialDepotPath.startsWith('base')) {
        const miFileContent = TypeHelper.JsonParse(wkit.LoadGameFileFromProject(materialDepotPath, 'json'));
        _validateMiFile(miFileContent);
    }
    
    switch (key) {
        case "MultilayerSetup":
            if (!materialDepotPath.endsWith(".mlsetup")) {
                Logger.Error(`${info}${materialDepotPath} doesn't end in .mlsetup. This will cause crashes.`);
                return;
            }
            if (meshSettings.checkDuplicateMlSetupFilePaths) {
                listOfUsedMaterialSetups[materialDepotPath] ||= [];                 
                 
                if (listOfUsedMaterialSetups[materialDepotPath].length > 0) {
                    Logger.Warning(`${info} uses the same .mlsetup as (a) previous material(s): [ ${
                        listOfUsedMaterialSetups[materialDepotPath].join(", ")
                    } ]`)  
                }
                listOfUsedMaterialSetups[materialDepotPath].push(info);
            }
            break;
        case "MultilayerMask":
            if (!materialDepotPath.endsWith(".mlmask")) {
                Logger.Error(`${info}${materialDepotPath} doesn't end in .mlmask. This will cause crashes.`);
                return;
            }
            break;
        case "BaseColor":
        case "Metalness":
        case "Roughness":
        case "Normal":
        case "GlobalNormal":
            if (!materialDepotPath.endsWith(".xbm")) {
                Logger.Error(`${info}${materialDepotPath} doesn't end in .xbm. This will cause crashes.`);
                return;
            }
            break;
    }

    // Once we've made sure that the file extension is correct, check if the file exists.
    checkDepotPath(materialDepotPath, info);
}

function meshFile_validatePlaceholderMaterial(material, info) {
    if (meshSettings.validatePlaceholderValues && (material.values || []).length) {
        Logger.Warning(`Placeholder ${info} defines values. Consider deleting them.`);
    }

    if (!meshSettings.validatePlaceholderMaterialPaths) return; 
    
    const baseMaterial = stringifyPotentialCName(material.baseMaterial.DepotPath);

    if (!checkDepotPath(baseMaterial, info, true)) {
        Logger.Warning(`Placeholder ${info}: invalid base material. Consider deleting it.`);
    }
}
function meshFile_CheckMaterialProperties(material, materialName) {
    const baseMaterial = stringifyPotentialCName(material.baseMaterial.DepotPath);
    
    if (checkDepotPath(baseMaterial, materialName)) {
        validateShaderTemplate(baseMaterial, materialName);
    }
    
    for (let i = 0; i < material.values.length; i++) {
        let tmp = material.values[i];
        
        const type = tmp["$type"] || tmp["type"];
            
        if (!type.startsWith("rRef:")) {
            continue;
        }

        Object.entries(tmp).forEach(([key, definedMaterial]) => {            
            validateMaterialKeyValuePair(key, definedMaterial, `${materialName}.Values[${i}]`, meshSettings.validateMaterialsRecursively);
        });
    }
}

function checkMeshMaterialIndices(mesh) {

    if (mesh.externalMaterials.length > 0 && mesh.preloadExternalMaterials.length > 0) {
        Logger.Warning("Your mesh is trying to use both externalMaterials and preloadExternalMaterials. To avoid unspecified behaviour, use only one of the lists. Material validation will abort.");
    }

    if (mesh.localMaterialBuffer.materials !== null && mesh.localMaterialBuffer.materials.length > 0
         && mesh.preloadLocalMaterialInstances.length > 0) {
        Logger.Warning("Your mesh is trying to use both localMaterialBuffer.materials and preloadLocalMaterialInstances. To avoid unspecified behaviour, use only one of the lists. Material validation will abort.");
    }

    let sumOfLocal = mesh.localMaterialInstances.length + mesh.preloadLocalMaterialInstances.length;
    if (mesh.localMaterialBuffer.materials !== null) {
        sumOfLocal += mesh.localMaterialBuffer.materials.length;
    }
    let sumOfExternal = mesh.externalMaterials.length + mesh.preloadExternalMaterials.length;

    materialNames = {};
    localIndexList = [];

    for (let i = 0; i < mesh.materialEntries.length; i++) {
        let materialEntry = mesh.materialEntries[i];
        // Put all material names into a list - we'll use it to verify the appearances later
        let name = stringifyPotentialCName(materialEntry.name);
        
        if (name in materialNames && !PLACEHOLDER_NAME_REGEX.test(name)) {
            Logger.Warning(`materialEntries[${i}] (${name}) is already defined in materialEntries[${materialNames[name]}]`);
        } else {
            materialNames[name] = i;
        }

        if (materialEntry.isLocalInstance) {
            if (materialEntry.index >= sumOfLocal) {
                Logger.Warning(`materialEntries[${i}] (${name}) is trying to access a local material with the index ${materialEntry.index}, but there are only ${sumOfLocal} entries. (Array starts counting at 0)`);
            }
            if (localIndexList.includes(materialEntry.index)) {
                Logger.Warning(`materialEntries[${i}] (${name}) is overwriting an already-defined material index: ${materialEntry.index}. Your material assignments might not work as expected.`);
            }
            localIndexList.push(materialEntry.index);
        } else {
            if (materialEntry.index >= sumOfExternal) {
                Logger.Warning(`materialEntries[${i}] (${name}) is trying to access an external material with the index ${materialEntry.index}, but there are only ${sumOfExternal} entries.`);
            }
        }
    }
}

export function validateMeshFile(mesh, _meshSettings) {
    if (!_meshSettings?.Enabled) return;
    if (mesh["Data"] && mesh["Data"]["RootChunk"]) {
        return validateMeshFile(mesh["Data"]["RootChunk"], _meshSettings);
    }
    
    meshSettings = _meshSettings;
    resetInternalFlagsAndCaches();
    
    checkMeshMaterialIndices(mesh);

    if (mesh.localMaterialBuffer.materials !== null) {
        for (let i = 0; i < mesh.localMaterialBuffer.materials.length; i++) {
            let material = mesh.localMaterialBuffer.materials[i];

            let materialName =  `localMaterialBuffer.materials[${i}]`;

            // Add a warning here?
            if (i < mesh.materialEntries.length) {
                materialName = stringifyPotentialCName(mesh.materialEntries[i].name) || materialName;
            }

            if (PLACEHOLDER_NAME_REGEX.test(materialName)) {
                meshFile_validatePlaceholderMaterial(material, `localMaterialBuffer.materials[${i}]`);
            } else {
                if (!/^[a-z]+/.test(materialName)) {
                    Logger.Info(`materials[${i}]: ${materialName} does not begin with a lower case letter. It might not load.`);
                }
                meshFile_CheckMaterialProperties(material, `localMaterialBuffer.${materialName}`);
            }
        }
    }

    for (let i = 0; i < mesh.preloadLocalMaterialInstances.length; i++) {
        let material = mesh.preloadLocalMaterialInstances[i];

        let materialName =  `preloadLocalMaterials[${i}]`;

        // Add a warning here?
        if (i < mesh.materialEntries.length) {
            materialName = stringifyPotentialCName(mesh.materialEntries[i].name) || materialName;
        }

        if (PLACEHOLDER_NAME_REGEX.test(materialName)) {
            meshFile_validatePlaceholderMaterial(material, `preloadLocalMaterials[${i}]`);
        } else {
            meshFile_CheckMaterialProperties(material.Data, `preloadLocalMaterials.${materialName}`);
        }
    }
    

    let numSubMeshes = 0;
    
    // Create RenderResourceBlob if it doesn't exists?
    if (mesh.renderResourceBlob !== "undefined") {
        numSubMeshes = mesh.renderResourceBlob?.Data?.header?.renderChunkInfos?.length;
    }

    for (let i = 0; i < mesh.appearances.length; i++) {
        let invisibleSubmeshes = [];
        let appearance = mesh.appearances[i].Data;
        const appearanceName = stringifyPotentialCName(appearance.name);
        if (numSubMeshes > appearance.chunkMaterials.length) {
            Logger.Warning(`Appearance ${appearanceName} has only ${appearance.chunkMaterials.length} of ${numSubMeshes} submesh appearances assigned. Meshes without appearances will render as invisible.`);
        }

        for (let j = 0; j < appearance.chunkMaterials.length; j++) {
            const chunkMaterialName = stringifyPotentialCName(appearance.chunkMaterials[j]) || ''; 
            if (chunkMaterialName && chunkMaterialName !== "None" && chunkMaterialName !== "none" && !(chunkMaterialName in materialNames)) {
                invisibleSubmeshes.push(`submesh ${j}: ${chunkMaterialName}`);                
            }
        }
        if (invisibleSubmeshes.length) {
            Logger.Warning(`Appearance ${appearanceName}: Invalid material assignments found. The following submeshes will render as invisible:`);
            Logger.Warning(`\t${invisibleSubmeshes.join('\n\t')}`);
        }
    }

    return true;
};

//#endregion


//#region miFile

/*
 * ===============================================================================================================
 *  mi file
 * ===============================================================================================================
 */
    let miSettings = {};
    export function validateMiFile(mi, _miSettings) {
        if (!_miSettings.Enabled) return;
        miSettings = _miSettings;
        resetInternalFlagsAndCaches();
        _validateMiFile(mi, '');
    }
    
    function _validateMiFile(mi, debugInfo) {
        if (mi["Data"] && mi["Data"]["RootChunk"]) {
            return _validateMiFile(mi["Data"]["RootChunk"]);
        }
        
        validateShaderTemplate(mi.baseMaterial.DepotPath, debugInfo);

        const values = mi.values || [];
        for (let i = 0; i < values.length; i++) {
            let tmp = values[i];

            if (!tmp["$type"].startsWith("rRef:")) {
                continue;
            }

            Object.entries(tmp).forEach(([key, definedMaterial]) => {
                validateMaterialKeyValuePair(key, definedMaterial, `Values[${i}]`, miSettings.validateRecursively);
            });
        }
    }
//#endregion

//#region csvFile

/*
 * ===============================================================================================================
 *  csv file
 * ===============================================================================================================
 */

export function validateCsvFile(csvData, csvSettings) {    
    if (!csvSettings.Enabled) return;

    if (csvData["Data"] && csvData["Data"]["RootChunk"]) {
        return validateCsvFile(csvData["Data"]["RootChunk"], csvSettings);
    }

    resetInternalFlagsAndCaches();
    
    // check if we have invalid depot paths (mixing up a json and a csv maybe) 
    let potentiallyInvalidFactoryPaths = []; 
    
    for (let i = 0; i < csvData.compiledData.length; i++) {
        const element = csvData.compiledData[i];
        const potentialName = element.length > 0 ? `${i} ${element[0]}` : `${i}` || `${i}`;
        const potentialPath = element.length > 1 ? element[1] : '' || '';
        // Check if it's a file path
        if (potentialPath) {
            if (!/^(.+)([\/\\])([^\/]+)$/.test(potentialPath)) {
                potentiallyInvalidFactoryPaths.push(`${potentialName}: ${potentialPath}`);                
            } else if (!wkit.FileExists(potentialPath)) {
                Logger.Warning(`${potentialName}: ${potentialPath} seems to be a file path, but can't be found in project or game files`);                
            }
        }
    }
    
    if (csvSettings.warnAboutInvalidDepotPaths && potentiallyInvalidFactoryPaths.length) {
        Logger.Warning(`One or more entries couldn't be resolved to depot paths. Is this a valid factory? The following elements have warnings:`);
        Logger.Info(`\t${potentiallyInvalidFactoryPaths.join(',\n\t')}`);
    }
}

//#endregion


//#region json

export function validateJsonFile(jsonData, jsonSettings) {
    if (jsonData["Data"] && jsonData["Data"]["RootChunk"]) {
        return validateJsonFile(jsonData["Data"]["RootChunk"], jsonSettings);
    }
    
    const duplicatePrimaryKeys = [];
    const secondaryKeys = [];
    const femaleTranslations = [];
    const maleTranslations = [];
    const emptyFemaleVariants = [];    
    

    for (let i = 0; i < jsonData.root.Data.entries.length; i++) {
        const element = jsonData.root.Data.entries[i];
        
        const potentialFemaleVariant = element.length > 0 ? element[0] : '' || '';
        const potentialMaleVariant = element.length > 1 ? element[1] : '' || '';
        const potentialPrimaryKey = element.length > 2 ? element[2] : '' || '';
        const secondaryKey = element.length > 3 ? element[3] : '' || '';

        if (!PLACEHOLDER_NAME_REGEX.test(secondaryKey)) {
            secondaryKeys.push(secondaryKey);
            
            if (potentialMaleVariant && !potentialFemaleVariant) {
                emptyFemaleVariants.push(secondaryKey);
            }
            
            if (jsonSettings.checkDuplicateTranslations) {            
                if (potentialFemaleVariant && femaleTranslations.includes(potentialFemaleVariant)) {
                    Logger.Warning(`entry ${i}: ${potentialFemaleVariant} already defined`);
                } else {
                    femaleTranslations.push(secondaryKey);
                }                
                if (potentialMaleVariant && maleTranslations.includes(potentialMaleVariant)) {
                    Logger.Warning(`entry ${i}: ${potentialMaleVariant} already defined`);
                } else {
                    maleTranslations.push(potentialMaleVariant);
                }
            }
            
            if (potentialPrimaryKey && potentialPrimaryKey !== '0') {
                duplicatePrimaryKeys.push(potentialPrimaryKey);
            }
        }
    }

    if (jsonSettings.checkDuplicateKeys) {
        if (duplicatePrimaryKeys.length) {
            Logger.Warning('You have duplicate primary keys in your file. Entries will overwrite each other, '
                + 'unless you set this value to 0');
        }                
        const duplicateKeys = secondaryKeys
            .filter((path, i, array) => !!path && array.indexOf(path) !== i) // filter out unique keys 
            .filter((path, i, array) => !!path && array.indexOf(path) === i); // filter out duplicates
        
        if (duplicateKeys?.length) {
            Logger.Warning('You have duplicate secondary keys in your file. The following entries will overwrite each other:'
                + duplicateKeys.length === 1 ? `${duplicateKeys}` : `[ ${duplicateKeys.join(", ")} ]`);            
        }
            
    } 
    
    if (jsonSettings.checkEmptyFemaleVariant && emptyFemaleVariants.length > 0) {
        Logger.Warning(`The following entries have no default value (femaleVariant): [ ${emptyFemaleVariants.join(', ')}]`);
        Logger.Info('Ignore this if your item is masc V only and you\'re using itemsFactoryAppearanceSuffix.Camera or dynamic appearances.');
        
    }
} 

//#endregion

//#region workspotFIle

/*
 * ===============================================================================================================
 *  workspot file
 * ===============================================================================================================
 */

let workspotSettings = {};

/* ****************************************************** */

// "Index" numbers must be unique: FileValidation stores already used indices. Can go after file writing has been implemented.
let alreadyUsedIndices = {};

// Animation names grouped by files
let animNamesByFile = {};

// We'll collect all animation names here after collectAnims, so we can check for workspot <==> anims definitions
let allAnimNamesFromAnimFiles = [];

// Map work entry child names to index of parents
let workEntryIndicesByAnimName = {};

// Files to read animation names from, will be set in checkFinalAnimSet
let usedAnimFiles = [];

/**
 * FileValidation collects animations from a file
 * @param {string} filePath - The path to the file
 */
function workspotFile_CollectAnims(filePath) {
    const fileContent = TypeHelper.JsonParse(wkit.LoadGameFileFromProject(filePath, 'json'));
    if (!fileContent) {
        Logger.Warning(`Failed to collect animations from ${filePath}`);
        return;
    }

    const fileName = /[^\\]*$/.exec(filePath)[0];

    const animNames = [];
    const animations = fileContent.Data.RootChunk.animations || [];
    for (let i = 0; i < animations.length; i++) {
        let currentAnimName = stringifyPotentialCName(animations[i].Data.animation.Data.name);
        if (!animNames.includes(currentAnimName)) {
            animNames.push(currentAnimName);
        }
    }

    animNamesByFile[fileName] = animNames

}

/**
 * FileValidation checks the finalAnimaSet (the object assigning an .anims file to a .rig):
 * - Is a .rig file in the expected slot?
 * - Do all paths exist in the fils?
 *
 * @param {number} idx - Numeric index for debug output
 * @param {object} animSet - The object to analyse
 */
function workspotFile_CheckFinalAnimSet(idx, animSet) {
    if (!animSet || !workspotSettings.checkFilepaths) {
        return;
    }

    const rigDepotPathValue = animSet.rig && animSet.rig.DepotPath ? stringifyPotentialCName(animSet.rig.DepotPath) : '';    
    
    if (!rigDepotPathValue || !rigDepotPathValue.endsWith('.rig')) {
        Logger.Error(`finalAnimsets[${idx}]: invalid rig: ${rigDepotPathValue}. This will crash your game!`);
    } else if (!wkit.FileExists(rigDepotPathValue)) {
        Logger.Warning(`finalAnimsets[${idx}]: File "${rigDepotPathValue}" not found in game or project files`);
    }

    if (!animSet.animations) {
		return;
	}

    // Check that all animSets in the .animations are also hooked up in the loadingHandles
    const loadingHandles = animSet.loadingHandles || [];

    const animations = animSet.animations.cinematics || [];
    for (let i = 0; i < animations.length; i++) {
        const nestedAnim = animations[i];
        const filePath = stringifyPotentialCName(nestedAnim.animSet.DepotPath);
        if (filePath && !wkit.FileExists(filePath)) {
            Logger.Warning(`finalAnimSet[${idx}]animations[${i}]: "${filePath}" not found in game or project files`);
        } else if (filePath && !usedAnimFiles.includes(filePath)) {
            usedAnimFiles.push(filePath);
        }
        if (!loadingHandles.find((h) => stringifyPotentialCName(h.DepotPath) === filePath)) {
            Logger.Warning(`finalAnimSet[${idx}]animations[${i}]: "${filePath}" not found in loadingHandles`);
        }
    }
}

/**
 * FileValidation checks the animSet (the object registering the animations):
 * - are the index parameters unique? (disable via checkIdDuplication flag)
 * - is the idle animation name the same as the animation name? (disable via checkIdleAnims flag)
 *
 * @param {number} idx - Numeric index for debug output
 * @param {object} animSet - The object to analyse
 */
function workspotFile_CheckAnimSet(idx, animSet) {
    if (!animSet || !animSet.Data) {
        return;
    }
    let animSetId;

    if (animSet.Data.id) {
        animSetId = animSet.Data.id.id
    }

    const idleName = stringifyPotentialCName(animSet.Data.idleAnim);
    const childItemNames = [];

    // TODO: FileValidation block can go after file writing has been implemented
    if (animSetId) {
        if (workspotSettings.checkIdDuplication && !!alreadyUsedIndices[animSetId]) {
            Logger.Warning(`animSets[${idx}]: id ${animSetId} already used by ${alreadyUsedIndices[animSetId]}`);
        }
        alreadyUsedIndices[animSetId] = `list[${idx}]`;
    }

    if ((animSet.Data.list || []).length === 0) {
		return;
	}

    for (let i = 0; i < animSet.Data.list.length; i++) {
        const childItem = animSet.Data.list[i];
        const childItemName = childItem.Data.animName.value || '';
        workEntryIndicesByAnimName[childItemName] = idx;

        animSetId = childItem.Data.id.id;

        // TODO: FileValidation block can go after file writing has been implemented
        if (workspotSettings.checkIdDuplication && !!alreadyUsedIndices[animSetId]) {
            Logger.Warning(`animSet[${idx}].list[${i}]: id ${animSetId} already used by ${alreadyUsedIndices[animSetId]}`);
        }

        childItemNames.push(stringifyPotentialCName(childItem.Data.animName));
        alreadyUsedIndices[animSetId] = `list[${idx}].list[${i}]`;
    }

    // warn user if name of idle animation doesn't match
    if (workspotSettings.checkIdleAnimNames && !childItemNames.includes(idleName)) {
        Logger.Info(`animSet[${idx}]: idle animation "${idleName}" not matching any of the defined animations [ ${childItemNames.join(",")} ]`);
    }
}
/**
 * Make sure that all indices under workspot's rootentry are numbered in ascending order
 *
 * @param rootEntry Root entry of workspot file.
 * @returns The root entry, all of its IDs in ascending numerical order
 */

function workspotFile_SetIndexOrder(rootEntry) {

    let currentId = rootEntry.Data.id.id;
    let indexChanged = 0;

    for (let i = 0; i < rootEntry.Data.list.length; i++) {
        const animSet = rootEntry.Data.list[i];
        currentId += 1;
        if (animSet.Data.id.id != currentId) {
            indexChanged += 1;
        }

        animSet.Data.id.id = currentId;
        for (let j = 0; j < animSet.Data.list.length; j++) {
            const childItem = animSet.Data.list[j];
            currentId += 1;
            if (childItem.Data.id.id != currentId) {
                indexChanged += 1;
            }
            childItem.Data.id.id = currentId;
        }
    }

    if (indexChanged > 0) {
        Logger.Info(`Fixed up ${indexChanged} indices in your .workspot! Please close and re-open the file!`);
    }

    isDataChangedForWriting = indexChanged > 0;

    return rootEntry;
}

export function validateWorkspotFile(workspot, _workspotSettings) {
    if (workspot["Data"] && workspot["Data"]["RootChunk"]) {
        return validateWorkspotFile(workspot["Data"]["RootChunk"], _workspotSettings);
    }

    workspotSettings = _workspotSettings;
    if (workspotSettings.fixIndexOrder) {
        workspotSettings.checkIdDuplication = false; 
    }
    resetInternalFlagsAndCaches();
    
    const workspotTree = workspot.workspotTree;

    const finalAnimsets = workspotTree.Data.finalAnimsets || [];

    for (let i = 0; i < finalAnimsets.length; i++) {
        workspotFile_CheckFinalAnimSet(i, finalAnimsets[i]);
    }

    for (let i = 0; i < usedAnimFiles.length; i++) {
        if (wkit.FileExists(usedAnimFiles[i])) {
            workspotFile_CollectAnims(usedAnimFiles[i]);
        } else {
            Logger.Warn(`${usedAnimFiles[i]} not found in project or game files`);
        }
    }

    // grab all used animation names - make sure they're unique
    Object.values(animNamesByFile).forEach((names) => {
        allAnimNamesFromAnimFiles = allAnimNamesFromAnimFiles.concat(names);
    })

    allAnimNamesFromAnimFiles = Array.from(new Set(allAnimNamesFromAnimFiles));

    alreadyUsedIndices.length = 0;

    let rootEntry = workspotTree.Data.rootEntry;

    if (workspotSettings.fixIndexOrder) {
        rootEntry = workspotFile_SetIndexOrder(workspotTree.Data.rootEntry);
    }

    if (rootEntry.Data.id) {
        alreadyUsedIndices[rootEntry.Data.id.id] = "rootEntry";
    }

    // Collect names of animations defined in files:
    let workspotAnimSetNames = rootEntry.Data.list
        .map((a) => a.Data.list.map((childItem) => stringifyPotentialCName(childItem.Data.animName)))
        .reduce((acc, val) => acc.concat(val));

    // check for invalid indices. setAnimIds doesn't write back to file yet…?
    for (let i = 0; i < rootEntry.Data.list.length; i++) {
        workspotFile_CheckAnimSet(i, rootEntry.Data.list[i]);
    }

    const unusedAnimNamesFromFiles = allAnimNamesFromAnimFiles.filter((name) => !workspotAnimSetNames.includes(name));

    // Drop all items from the file name table that are defined in the workspot, so we can print the unused ones below
    Object.keys(animNamesByFile).forEach((fileName) => {
        animNamesByFile[fileName] = animNamesByFile[fileName].filter((name) => !workspotAnimSetNames.includes(name));
    });

    if (workspotSettings.showUnusedAnimsInFiles && unusedAnimNamesFromFiles.length > 0) {
        Logger.Info(`Items from .anim files not found in .workspot:`);
        Object.keys(animNamesByFile).forEach((fileName) => {
            const unusedAnimsInFile = animNamesByFile[fileName].filter((val) => unusedAnimNamesFromFiles.find((animName) => animName === val));
            if (unusedAnimsInFile.length > 0) {
                Logger.Info(`${fileName}: [\n\t${unusedAnimsInFile.join(",\n\t")}\t\n]`);
            }
        });
    }
    
    const unusedAnimSetNames = workspotAnimSetNames.filter((name) => !allAnimNamesFromAnimFiles.includes(name));
    if (workspotSettings.showUndefinedWorkspotAnims && unusedAnimSetNames.length > 0) {
        Logger.Info(`Items from .workspot not found in .anim files:`);
        Logger.Info(unusedAnimSetNames.map((name) => `${workEntryIndicesByAnimName[name]}: ${name}`));
    }
    return rootEntry;
}
//#endregion


//#region inkatlas
export function validateInkatlasFile(inkatlas, _inkatlasSettings) {
    if (inkatlas["Data"] && inkatlas["Data"]["RootChunk"]) {
        return validateWorkspotFile(workspot["Data"]["RootChunk"], _inkatlasSettings);
    }
    if (!_inkatlasSettings.Enabled) {
        return;
    }
    
    let depotPath;
    if (_inkatlasSettings.CheckDynamicTexture) {
        depotPath = stringifyPotentialCName(inkatlas.dynamicTexture?.DepotPath);
        checkDepotPath(depotPath, 'inkatlas.dynamicTexture', true);
        depotPath = stringifyPotentialCName(inkatlas.dynamicTextureSlot?.texture?.DepotPath);
        checkDepotPath(depotPath, 'inkatlas.dynamicTextureSlot.texture', true); 
        depotPath = stringifyPotentialCName(inkatlas.texture?.DepotPath);
        checkDepotPath(depotPath, 'inkatlas.dynamicTextureSlot.texture', true);        
    }


    if (_inkatlasSettings.CheckSlots) {
        (inkatlas.slots?.Elements || []).forEach((entry, index) => {
            depotPath = stringifyPotentialCName(entry.texture?.DepotPath);
            checkDepotPath(depotPath, `inkatlas.slots[${index}].texture`, index > 0);
        });
    }
    
}