import * as Logger from 'Logger.wscript';

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

export let isDataChangedForWriting = false;

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
    animAnimSettings = _animAnimSettings;
    isDataChangedForWriting = false;

    if (animAnimSet["Data"] && animAnimSet["Data"]["RootChunk"]) {
        return validateAnimationFile(animAnimSet["Data"]["RootChunk"], animAnimSettings);
    }

    // collect names
    for (let index = 0; index < animAnimSet.animations.length; index++) {
        const animName = animAnimSet.animations[index].Data.animation.Data.name;
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

// map: { 'myComponent4711': 'path/to/file.mesh' };
let meshesByComponentName = {};

/* map: {
 *	'path/to/file.mesh':  'myComponent4711',
 *	'path/to/file2.mesh': 'myComponent4711',
 * };
 */
const componentNameCollisions = {};

// [ myComponent4711, black_shirt ]
const overriddenComponents = [];

const componentOverrideCollisions = [];

const alreadyVerifiedFileNames = [];

function component_collectAppearancesFromMesh(depotPath) {
    if (!depotPath || !wkit.FileExists(depotPath) || !!appearanceNamesByMeshFile[depotPath]) {
        return;
    }
    const fileContent = wkit.LoadGameFileFromProject(depotPath, 'json');
    try {
        const mesh = JSON.parse(fileContent);
        if (!mesh || !mesh.Data || !mesh.Data.RootChunk || !mesh.Data.RootChunk.appearances) {
            return;
        }
        const appearanceNames = mesh.Data.RootChunk.appearances.map((appearance) => appearance.Data.name);
        appearanceNamesByMeshFile[depotPath] = appearanceNames;
    } catch (err) {
        Logger.Warning(`Couldn't parse ${depotPath}`);
    }
}

function appFile_collectComponentsFromEntPath(depotPath, validateRecursively) {
    if (!wkit.FileExists(depotPath)) {
        Logger.Warn(`Trying to check file path ${depotPath}, but it doesn't exist in game or project files`);
        return;
    }

    if (alreadyVerifiedFileNames.includes(depotPath)) {
        return;
    }

    alreadyVerifiedFileNames.push(depotPath);

    const fileContent = wkit.LoadGameFileFromProject(depotPath, 'json');
    const parts = depotPath.split('\\');
    const meshFileName = parts[parts.length - 1];

    try {
        // fileExists has been checked in validatePartsOverride
        const entity = JSON.parse(fileContent);
        const components = entity && entity.Data && entity.Data.RootChunk ? entity.Data.RootChunk.components || [] : [];
        for (let i = 0; i < components.length; i++) {
            entFile_validateComponent(components[i], i, validateRecursively);
        }
    } catch (err) {
        throw err;
    }
}

function appFile_validatePartsOverride(override, index, appearanceName) {
    const overrideDepotPath = override.partResource.DepotPath;

    if (overrideDepotPath && "0" !== overrideDepotPath) {
        if (!overrideDepotPath.endsWith(".ent")) {
            Logger.Warning(`${appearanceName}.partsOverrides[${index}]: ${overrideDepotPath} is not an entity file!`);
        } else if (!wkit.FileExists(overrideDepotPath)) {
            Logger.Warning(`${appearanceName}.partsOverrides[${index}]: ${overrideDepotPath} not found in project or game files`);
        }
    }

    for (let i = 0; i < override.componentsOverrides.length; i++) {
        const componentOverride = override.componentsOverrides[i];
        const componentName = componentOverride.componentName || '';
        overriddenComponents.push(componentName);

        const meshPath = componentName && meshesByComponentName[componentName] ? meshesByComponentName[componentName] : '';
        if (meshPath) {
            const appearanceNames = appearanceNamesByMeshFile[meshPath] || [];
            if (appearanceNames.length > 1 && !appearanceNames.includes(componentOverride.meshAppearance) && !componentOverrideCollisions.includes(componentOverride.meshAppearance)) {
                Logger.Warning(`${appearanceName}.partsOverrides[${index}]: ${componentOverride.meshAppearance} was not found in ${meshPath}`);
            }
        }
    }
}

function appFile_validatePartsValue(value, index, appearanceName, validateRecursively) {
    // Logger.Info(value);
    const valueDepotPath = value.resource.DepotPath;
    if (!valueDepotPath) {
        Logger.Warning(`${appearanceName}.partsValues[${index}]: No .ent file in depot path`);
        return;
    }
    if (!wkit.FileExists(valueDepotPath)) {
        Logger.Warning(`${appearanceName}.partsValues[${index}]: linked resource ${valueDepotPath} not found in project or game files`);
        return;
    }
    appFile_collectComponentsFromEntPath(valueDepotPath, validateRecursively);
}

function appFile_validateAppearance(appearance, index, validateRecursively) {
    // check override
    if (appearance.Data.cookedDataPathOverride.DepotPath && appearance.Data.cookedDataPathOverride.DepotPath !== "0") {
        Logger.Warning(`appearance definition ${index} has a cooked data override. Consider deleting it.`);
    }

    let appearanceName = appearance.Data.name;

    if (appearanceName.length === 0 || /^[^A-Za-z0-9]+$/.test(appearanceName)) {
        return;
    }

    if (!appearanceName) {
        Logger.Warning(`appearance definition #${index} has no name yet`);
        appearanceName = `appearances[${index}]`;
    }

    if (alreadyDefinedAppearanceNames.includes(appearanceName)) {
        Logger.Warning(`An appearance with the name ${appearanceName} is already defined`);
    }

    // might be null
    const components = appearance.Data.components || [];

    for (let i = 0; i < components.length; i++) {
        entFile_validateComponent(components[i], i, appearanceName, validateRecursively);
    }

    // check these before the overrides, because we're parsing the linked files
    for (let i = 0; i < appearance.Data.partsValues.length; i++) {
        appFile_validatePartsValue(appearance.Data.partsValues[i], i, appearanceName, validateRecursively);
    }

    Object.values(componentNameCollisions)
        .filter((name) => overriddenComponents.includes(name))
        .filter((name) => !componentOverrideCollisions.includes(name))
        .forEach((name) => componentOverrideCollisions.push(name));

    if (componentOverrideCollisions && componentOverrideCollisions.length > 0) {
        Logger.Warning("Inside partsValues, validation found components of the same name pointing at different meshes.");
        Logger.Warning("Name collisions may lead to partsOverrides behaving erratically. FileValidation affects the following meshes/component names:");
        Object.keys(componentNameCollisions).forEach((meshPath) => {
            Logger.Warning(`${componentNameCollisions[meshPath]}: ${meshPath}`);
        });
    }

    for (let i = 0; i < appearance.Data.partsOverrides.length; i++) {
        appFile_validatePartsOverride(appearance.Data.partsOverrides[i], i, appearanceName);
    }
}

export function validateAppFile(app, validateRecursively) {
    // invalid app file - not found
    if (!app) {
        return;
    }

    isDataChangedForWriting = false;

    // empty array with name collisions
    componentOverrideCollisions.length = 0;
    alreadyVerifiedFileNames.length = 0;
    meshesByComponentName = {};

    if (app["Data"] && app["Data"]["RootChunk"]) {
        return validateAppFile(app["Data"]["RootChunk"], validateRecursively);
    }
    for (let i = 0; i < app.appearances.length; i++) {
        appFile_validateAppearance(app.appearances[i], i, validateRecursively);
    }
}

//#endregion


//#region entFile

let entSettings = {};

/**
 * @param depotPath the depot path to analyse
 * @param info info string for the user
 */
function checkDepotPath(depotPath, info) {
    if (!depotPath) {
        Logger.Warning(`${info}: DepotPath not set`);
    }
    if (!wkit.FileExists(depotPath)) {
        Logger.Warning(`${info}: ${depotPath} not found in project or game files`);
    }
}

// For different component types, check DepotPath property
function entFile_validateComponent(component, _index, validateRecursively) {
    // flag for mesh validation, in case this is called recursively from app file
    let hasMesh = false;
    switch (component.$type || '') {
        case 'entGarmentSkinnedMeshComponent':
        case 'entSkinnedMeshComponent':
            checkDepotPath(component.mesh.DepotPath, component.name);
            hasMesh = true;
            break;
        case 'workWorkspotResourceComponent':
            checkDepotPath(component.workspotResource.DepotPath, component.name);
            break;
        default:
            break;
    }

    if (!validateRecursively || !hasMesh) {
        return;
    }

    // check for component name uniqueness
    if (meshesByComponentName[component.name] && meshesByComponentName[component.name] !== component.mesh.DepotPath) {
        componentNameCollisions[component.mesh.DepotPath] = component.name;
        componentNameCollisions[meshesByComponentName[component.name]] = component.name;
    }
    meshesByComponentName[component.name] = component.mesh.DepotPath;
    component_collectAppearancesFromMesh(component.mesh.DepotPath);

}

// Map: app file depot path name to defined appearances
const appearanceNamesByAppFile = {};

function getAppearanceNamesInAppFile(depotPath) {
    if (!wkit.FileExists(depotPath)) {
        return [];
    }
    if (!appearanceNamesByAppFile[depotPath]) {
        const fileContent = wkit.LoadGameFileFromProject(depotPath, 'json');
        const appFile = JSON.parse(fileContent);
        if (null !== appFile) {
            const appNames = appFile.Data.RootChunk.appearances.map((app) => app.Data.name) || [];
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
    // ignore separator appearances such as
    // =============================
    // -----------------------------
    if (appearance.name.length === 0 || /^[^A-Za-z0-9]+$/.test(appearance.name)) {
        return;
    }

    if (alreadyDefinedAppearanceNames.includes(appearance.name)) {
        Logger.Warning(`An appearance with the name ${appearance.name} is already defined`);
    }
    alreadyDefinedAppearanceNames.push(appearance.name);

    const appFilePath = appearance.appearanceResource.DepotPath;

    if (!appFilePath) {
        Logger.Warning(`${appearance.name}: No app file defined`);
        return;
    }

    if (!wkit.FileExists(appFilePath)) {
        Logger.Warning(`${appearance.name}: app file '${appFilePath}' not found in project or game files`);
        return;
    }

    const namesInAppFile = getAppearanceNamesInAppFile(appFilePath, appearance.name) || [];
    if (!namesInAppFile.includes(appearance.appearanceName)) {
        Logger.Warning(`${appearance.name}: Should have appearance ${appearance.appearanceName}, but file ${appFilePath} only defines [${namesInAppFile.join(', ')}]`);
    }

    if (isRootEntity) {
        const fileContent = wkit.LoadGameFileFromProject(appFilePath, 'json');
        const appFile = JSON.parse(fileContent);
        if (null === appFile) {
            Logger.Warning(`File ${appFilePath} is supposed to exist, but couldn't be parsed.`);
        } else {
            validateAppFile(appFile, true);
        }
    }
}

/**
 *
 * @param {*} ent The entity file as read from WKit
 * @param {*} _entSettings Settings object
 */
export function validateEntFile(ent, _entSettings) {
    entSettings = _entSettings;
    isDataChangedForWriting = false;

    if (ent["Data"] && ent["Data"]["RootChunk"]) {
        return validateEntFile(ent["Data"]["RootChunk"]);
    }

    for (let i = 0; i < ent.components.length; i++) {
        const component = ent.components[i];
        entFile_validateComponent(component, i, false);
    }

    // will be set to false in app file validation
    const _isDataChangedForWriting = isDataChangedForWriting;

    for (let i = 0; i < ent.appearances.length; i++) {
        const appearance = ent.appearances[i];
        entFile_validateAppearance(appearance, i, !entSettings.skipRootEntityCheck);
    }

    for (let i = 0; i < ent.inplaceResources.length; i++) {
        checkDepotPath(ent.inplaceResources[i].DepotPath, `inplaceResources[${i}]`);
    }
    for (let i = 0; i < ent.resolvedDependencies.length; i++) {
        checkDepotPath(ent.resolvedDependencies[i].DepotPath, `resolvedDependencies[${i}]`);
    }

    isDataChangedForWriting = _isDataChangedForWriting;
};

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

function meshFile_CheckMaterialProperties(material, materialName) {
    for (let i = 0; i < material.values.length; i++) {
        let tmp = material.values[i];

        if (!tmp["$type"].startsWith("rRef:")) {
            continue;
        }

        Object.entries(tmp).forEach(([key, value]) => {
            if (key === "$type") {
                return;
            }

            switch (key) {
                case "MultilayerSetup":
                    if (!value["DepotPath"].endsWith(".mlsetup")) {
                        Logger.Warning(`${materialName}.values[${i}]: ${value["DepotPath"]} doesn't end in .mlsetup. FileValidation might cause crashes.`);
                    }
                    break;
                case "MultilayerMask":
                    if (!value["DepotPath"].endsWith(".mlmask")) {
                        Logger.Warning(`${materialName}.values[${i}]: ${value["DepotPath"]} doesn't end in .mlmask. FileValidation might cause crashes.`);
                    }
                    break;
                case "BaseColor":
                case "Metalness":
                case "Roughness":
                case "Normal":
                case "GlobalNormal":
                    if (!value["DepotPath"].endsWith(".xbm")) {
                        Logger.Warning(`${materialName}.values[${i}]: ${value["DepotPath"]} doesn't end in .xbm. FileValidation might cause crashes.`);
                    }
                    break;
            }
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
        let name = materialEntry.name.toString() ?? "";
        if (name in materialNames) {
            Logger.Warning(`materialEntries[${i}] (${name}) is already defined in materialEntries[${materialNames[name]}]`);
        } else {
            materialNames[name] = i;
        }

        if (materialEntry.isLocalInstance) {
            if (materialEntry.index >= sumOfLocal) {
                Logger.Warning(`materialEntries[${i}] (${materialEntry.name}) is trying to access a local material with the index ${materialEntry.index}, but there are only ${sumOfLocal} entries. (Array starts counting at 0)`);
            }
            if (localIndexList.includes(materialEntry.index)) {
                Logger.Warning(`materialEntries[${i}] (${materialEntry.name}) is overwriting an already-defined material index: ${materialEntry.index}. Your material assignments might not work as expected.`);
            }
            localIndexList.push(materialEntry.index);
        } else {
            if (materialEntry.index >= sumOfExternal) {
                Logger.Warning(`materialEntries[${i}] (${materialEntry.name}) is trying to access an external material with the index ${materialEntry.index}, but there are only ${sumOfExternal} entries.`);
            }
        }
    }
}

export function validateMeshFile(mesh, _meshSettings) {
    if (mesh["Data"] && mesh["Data"]["RootChunk"]) {
        return validateMeshFile(mesh["Data"]["RootChunk"], meshSettings);
    }

    meshSettings = _meshSettings;
    isDataChangedForWriting = false;

    checkMeshMaterialIndices(mesh);

    if (mesh.localMaterialBuffer.materials !== null) {
        for (let i = 0; i < mesh.localMaterialBuffer.materials.length; i++) {
            let material = mesh.localMaterialBuffer.materials[i];

            let materialName = "unknown";

            // Add a warning here???
            if (i < mesh.materialEntries.length && mesh.materialEntries[i] == "undefined") {
                materialName = mesh.materialEntries[i].name;
            }

            meshFile_CheckMaterialProperties(material, materialName);
        }
    }

    for (let i = 0; i < mesh.preloadLocalMaterialInstances.length; i++) {
        let material = mesh.preloadLocalMaterialInstances[i];

        let materialName = "unknown";

        // Add a warning here???
        if (i < mesh.materialEntries.length && mesh.materialEntries[i] == "undefined") {
            materialName = mesh.materialEntries[i].name;
        }

        meshFile_CheckMaterialProperties(material.Data, materialName);
    }

    let numSubMeshes = 0;
    // Create RenderResourceBlob if it doesn't exists?
    if (mesh.renderResourceBlob !== "undefined") {
        numSubMeshes = mesh.renderResourceBlob.Data.header.renderChunkInfos.length;
    }

    for (let i = 0; i < mesh.appearances.length; i++) {
        let appearance = mesh.appearances[i].Data;

        if (numSubMeshes > appearance.chunkMaterials.length) {
            Logger.Warning(`Appearance ${appearance.name} has only ${appearance.chunkMaterials.length} of ${numSubMeshes} submesh appearances assigned. Meshes without appearances will render as invisible.`);
        }

        for (let j = 0; j < appearance.chunkMaterials.length; j++) {
            if (!(appearance.chunkMaterials[j]in materialNames)) {
                Logger.Warning(`Appearance ${appearance.name}: Chunk material ${appearance.chunkMaterials[j]} doesn't exist, submesh ${j} will render as invisible.`);
            }
        }
    }

    return true;
};

//#endregion


//#region csvFile

/*
 * ===============================================================================================================
 *  csv file
 * ===============================================================================================================
 */

export function validateCsvFile(csvData, csvSettings) {
    // Nothing to do here, abort
    if (!csvSettings.checkProjectResourcePaths) {
        return;
    }

    isDataChangedForWriting = false;

    if (csvData["Data"] && csvData["Data"]["RootChunk"]) {
        return validateCsvFile(csvData["Data"]["RootChunk"], csvSettings);
    }
    for (let i = 0; i < csvData.compiledData.length; i++) {
        const element = csvData.compiledData[i];
        const potentialPath = element.length > 1 ? element[1] : '' || '';
        // Check if it's a file path
        if (potentialPath && /^(.+)(\/|\\)([^\/]+)$/.test(potentialPath) && !wkit.FileExists(potentialPath)) {
            Logger.Warning(`entry ${i}: ${potentialPath} seems to be a file path, but can't be found in project or game files`);
        }
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
    const fileContent = JSON.parse(wkit.LoadGameFileFromProject(filePath, 'json'));
    if (!fileContent) {
        Logger.Warning(`Failed to collect animations from ${filePath}`);
        return;
    }

    const fileName = /[^\\]*$/.exec(filePath)[0];

    animNamesByFile[fileName] = [];
    const animations = fileContent.Data.RootChunk.animations || [];
    for (let i = 0; i < animations.length; i++) {
        let currentAnimName = animations[i].Data.animation.Data.name;
        if (!animNamesByFile[fileName].includes(currentAnimName)) {
            animNamesByFile[fileName].push(currentAnimName);
        }
    }
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
    if (!animSet) {
        return;
    }

    const rig = animSet.rig ? animSet.rig.DepotPath : '';

    if (!rig || !rig.endsWith('.rig')) {
        Logger.Warning(`finalAnimsets[${idx}]: invalid rig "${rig}"`);
    } else if (workspotSettings.checkFilepaths && !wkit.FileExists(rig)) {
        Logger.Warning(`finalAnimsets[${idx}]: File "${rig}" not found in game or project files`);
    }

    if (!animSet.animations) {
		return;
	}

    // Check that all animSets in the .animations are also hooked up in the loadingHandles
    const loadingHandles = animSet.loadingHandles || [];

    const animations = animSet.animations.cinematics || [];
    for (let i = 0; i < animations.length; i++) {
        const nestedAnim = animations[i];
        const file = nestedAnim.animSet.DepotPath;
        if (workspotSettings.checkFilepaths && !wkit.FileExists(file)) {
            Logger.Warning(`finalAnimSet[${idx}]animations[${i}]: "${file}" not found in game or project files`);
        } else if (!usedAnimFiles.includes(file)) {
            usedAnimFiles.push(file);
        }
        if (workspotSettings.checkLoadingHandles && !loadingHandles.find((h) => h.DepotPath === file)) {
            Logger.Warning(`finalAnimSet[${idx}]animations[${i}]: "${file}" not found in loadingHandles`);
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

    const idleName = animSet.Data.idleAnim;
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

        workEntryIndicesByAnimName[childItem.Data.animName] = idx;

        animSetId = childItem.Data.id.id;

        // TODO: FileValidation block can go after file writing has been implemented
        if (workspotSettings.checkIdDuplication && !!alreadyUsedIndices[animSetId]) {
            Logger.Warning(`animSet[${idx}].list[${i}]: id ${animSetId} already used by ${alreadyUsedIndices[animSetId]}`);
        }

        childItemNames.push(childItem.Data.animName);
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

    // fixIndexOrder, showUnusedAnimsInFiles, showUndefinedWorkspotAnims, checkIdleAnimNames, checkIdDuplication, checkFilepaths, checkLoadingHandles
    if (workspot["Data"] && workspot["Data"]["RootChunk"]) {
        return validateWorkspotFileAppFile(workspot["Data"]["RootChunk"], _workspotSettings);
    }

    workspotSettings = _workspotSettings;
    isDataChangedForWriting = false;

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
        .map((a) => a.Data.list.map((childItem) => childItem.Data.animName))
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
