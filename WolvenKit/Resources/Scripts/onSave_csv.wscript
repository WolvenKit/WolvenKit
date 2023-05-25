import * as FileValidation from 'Wolvenkit/Wolvenkit_FileValidation.wscript';
import * as Logger from 'Wolvenkit/Logger.wscript';

function main(csvData) {
	FileValidation.validateCsvFile(csvData);
	return true;
};


try {
	const fileContent = JSON.parse(file);
    success = main(fileContent["Data"]["RootChunk"]);
} catch (err) {
    Logger.Warning("failed to validate file");
    success = true;
}