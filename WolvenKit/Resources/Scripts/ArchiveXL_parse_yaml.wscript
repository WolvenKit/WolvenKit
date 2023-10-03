import * as Logger from 'Logger.wscript';
import * as yaml from './libraries/yaml.wscript';
import {Success} from "Logger.wscript";

const fileContentByPath = {}

const fileExtensions = ['xl', 'yaml', 'tweak']
export function collectFileContent() {
    const files = [];
    for (let filePath of wkit.GetProjectFiles('resources')) {
        const fileExtension = filePath.split(".").pop() || ''
        if (!fileExtensions.includes(fileExtension)) return;
        const raw = wkit.LoadGameFileFromProject(filePath, 'json')
        
        const yamlContent = yaml.load(raw);
        Logger.Success(`${filePath}: `);
        Logger.Success(yamlContent);
        fileContentByPath[filePath] = yamlContent;
    }   
}

collectFileContent();