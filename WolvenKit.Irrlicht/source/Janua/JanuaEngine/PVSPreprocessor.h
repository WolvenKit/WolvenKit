#pragma once

#include <string>
#include <vector>
#include <unordered_map>
#include <sstream>
using namespace std;

#include "PVSDatabase.h"
#include "..\Core\Vector3f.h"
#include "SceneObjectType.h"
#include "SceneOptions.h"
#include "Scene.h"
#include "PVSGenerator.h"
#include "PVSDatabaseExporter.h"
#include "pugixml.hpp"
using namespace pugi;


namespace Janua
{
	/**
	* Tool to create the PVS from an input XML file with the raw scene data
	*/
	class PVSPreprocessor
	{

	public:

		/**
		* Raw-data for a mesh
		*/
		struct MeshData
		{
			/**
			* A unique identifier for the mesh
			*/
			unsigned int id;

			/**
			* Occludee or Occluder
			*/
			SceneObjectType type;

			/**
			* Number of triangles for the mesh
			*/
			unsigned int trianglesCount;

			/**
			* Vertex values (x, y z) for each triangle (the vertices are not indexed)
			*/
			float* vertexData;
		};



		/**
		* Constructor
		*/
		PVSPreprocessor();

		/**
		* Import meshes from the XML raw format file
		*/
		bool addMeshesFromXmlFile(const string inputPath);


		/**
		* Do the PVS building
		*/
		void buildPVS();

		/**
		* Free resources
		*/
		void dispose();

		/**
		* Retrieve error messages
		*/
		string getErrors();

		/**
		* Split string
		*/
		static vector<string> split(const string& text, char sep);

	private:

		vector<MeshData> meshes;

		vector<string> errorMessages;

	public:

		/**
		* The name of the scene
		*/
		string sceneName;

		/**
		* The path where the PVS file will be saved
		*/
		string outputPath;

		/**
		* The size of each voxel
		*/
		Vector3f voxelSize;

		/**
		* The max size a cell can achieve
		*/
		Vector3f maxCellSize;

	private:

		string PVSPreprocessor::toString(const int n);

	};
}
