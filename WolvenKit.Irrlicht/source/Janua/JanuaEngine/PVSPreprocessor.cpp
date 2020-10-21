#include "PVSPreprocessor.h"

namespace Janua
{
	PVSPreprocessor::PVSPreprocessor()
	{

	}


	bool PVSPreprocessor::addMeshesFromXmlFile(const string inputPath)
	{
		//Load XML file
		xml_document doc;
		xml_parse_result result = doc.load_file(inputPath.c_str());
		if (!result)
		{
			errorMessages.push_back("Cannot load XML file: " + inputPath);
			errorMessages.push_back(result.description());
			return false;
		}
		xml_node root = doc.child("janua_scene");
		if (root.empty())
		{
			errorMessages.push_back("The root node [janua_scene] of the XML is empty.");
			return false;
		}

		//Load meshes
		xml_node meshesNode = root.child("meshes");
		if (meshesNode.empty())
		{
			errorMessages.push_back("The \"meshes\" node of the XML is empty.");
			return false;
		}
		xml_attribute countAttr = meshesNode.attribute("count");
		if (countAttr.empty())
		{
			errorMessages.push_back("The \"meshes\" has not a count property.");
			return false;
		}
		int meshesCount = countAttr.as_int();
		int i = 0;
		unordered_map<unsigned int, unsigned int> idMap;
		for (xml_node meshNode = meshesNode.first_child(); meshNode; meshNode = meshNode.next_sibling())
		{
			MeshData meshData;

			//id
			string idStr = meshNode.attribute("type").as_string();
			meshData.id = meshNode.attribute("type").as_uint();

			//Check unique
			unordered_map<unsigned int, unsigned int>::iterator  it = idMap.find(meshData.id);
			if (it != idMap.end())
			{
				errorMessages.push_back("The ID: " + idStr + " is duplicated.");
				continue;
			}
			idMap[meshData.id] = meshData.id;

			//type
			string type = meshNode.attribute("type").as_string();
			if (type == "OCCLUDER")
			{
				meshData.type = OCCLUDER;
			}
			else if (type == "OCCLUDEE")
			{
				meshData.type = OCCLUDEE;
			}
			else
			{
				errorMessages.push_back("Bad mesh type for ID: " + idStr);
				continue;
			}

			//triCount
			string triCountStr = meshNode.attribute("triCount").as_string();
			meshData.trianglesCount = meshNode.attribute("triCount").as_uint();
			unsigned int vertexValuesCount = meshData.trianglesCount * 3 * 3;
			meshData.vertexData = new float[vertexValuesCount];

			//vertex values
			string vertexValues = meshNode.child_value();
			int start = 0, end = 0;
			string floatStr;
			float coordValue;
			int currentVertIdx = 0;
			while ((end = vertexValues.find(' ', start)) != string::npos)
			{
				floatStr = vertexValues.substr(start, end - start);
				coordValue = (float)atof(floatStr.c_str());
				meshData.vertexData[currentVertIdx++] = coordValue;
				start = end + 1;

				if (currentVertIdx >= (int)vertexValuesCount)
				{
					errorMessages.push_back("The mesh with ID: " + idStr + " has more vertices than the triCount specified [" + triCountStr + "]");
					currentVertIdx = -1;
					break;
				}
			}
			if (currentVertIdx < 0)
			{
				continue;
			}
			floatStr = vertexValues.substr(start);
			coordValue = (float)atof(floatStr.c_str());
			meshData.vertexData[currentVertIdx++] = coordValue;

			//check amounts
			if (currentVertIdx != vertexValuesCount)
			{
				errorMessages.push_back("The triCount [" + triCountStr + "] for the mesh with ID: " + idStr + " does not match with amount of coordinates [" + toString((int)vertexValuesCount) + "]");
				continue;
			}
		}



		return true;
	}

	string PVSPreprocessor::toString(const int n)
	{
		stringstream ss;
		ss << n;
		return ss.str();
	}


	void PVSPreprocessor::buildPVS()
	{
		//Create scene
		SceneOptions ocSceneOptions;
		ocSceneOptions.setMaxCellSize((int)maxCellSize.x, (int)maxCellSize.y, (int)maxCellSize.z);
		ocSceneOptions.setVoxelSize(voxelSize.x, voxelSize.y, voxelSize.z);
		Scene ocScene = Scene(ocSceneOptions, sceneName);

		//Add meshes to scene
		vector<Model*> ocModels;
		Matrix4x4 identityMat;
		for (unsigned int i = 0; i < meshes.size(); i++)
		{
			MeshData meshData = meshes[i];

			//Sequential index data
			int indexCount = meshData.trianglesCount * 3;
			int* indexData = new int[indexCount];
			for (int i = 0; i < indexCount; i++)
			{
				indexData[i] = i;
			}

			//Create model
			Model* ocModel = new Model(meshData.vertexData, indexCount, indexData, meshData.trianglesCount);

			//Add model to scene
			ocModels.push_back(ocModel);
			ocScene.addModelInstance((*ocModel), meshData.id, identityMat, meshData.type);

			delete[] indexData;
		}

		//Generate voxels from the scene
		PVSGenerator gen = PVSGenerator(ocScene);
		shared_ptr<PVSDatabase> ocDatabase = gen.generatePVSDatabase();

		//Export to file
		PVSDatabaseExporter dbExporter(*ocDatabase);
		int allocatedSize = dbExporter.getBufferSize();
		char* buffer = new char[allocatedSize];
		dbExporter.saveToBuffer(buffer);
		FILE* file = fopen(outputPath.c_str(), "wb");
		fwrite(buffer, 1, allocatedSize, file);
		fclose(file);
		delete[] buffer;

	}


	void PVSPreprocessor::dispose()
	{
		for (unsigned int i = 0; i < meshes.size(); i++)
		{
			delete[] meshes[i].vertexData;
		}
	}

	string PVSPreprocessor::getErrors()
	{
		string errors = "Errors (" + toString((int)errorMessages.size()) + "): \n";
		for (unsigned int i = 0; i < errorMessages.size(); i++)
		{
			errors += " - " + errorMessages[i] + "\n";
		}
		return errors;
	}

	vector<string> PVSPreprocessor::split(const string& text, char sep)
	{
		vector<string> tokens;
		int start = 0, end = 0;
		while ((end = text.find(sep, start)) != string::npos)
		{
			tokens.push_back(text.substr(start, end - start));
			start = end + 1;
		}
		tokens.push_back(text.substr(start));
		return tokens;
	}
}