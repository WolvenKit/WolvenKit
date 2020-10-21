/*  ******************************************************************************* **
 * GIGC - Grupo de Investigación de Gráficos por Computadora - UTN FRBA - Argentina
 * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *  **
 * <copyright> copyright (c) 2013 </copyright>	
 * <autor> Leandro Roberto Barbagallo </autor>
 * <license href="https://github.com/gigc/Janua">MIT</license>
 ********************************************************************************** */

#pragma once

#include "Model.h"
#include "../Core/Matrix4x4.h"
#include "SceneOptions.h"
#include "ModelInstance.h"
#include "SceneObjectType.h"
#include <string>
#include <vector>

using std::string;
using std::vector;

//TODO: add namespace
namespace Janua
{
	/**
	* A Scene contains several Model instances inside under a previously set SceneOptions.
	*
	*/
	class Scene
	{
	public:

		Scene();
		Scene(const SceneOptions& options);
		Scene(const SceneOptions& options, const string& name);

		/**
		* Adds a Model instance to the current Scene. One Model can have several instances of itself, in different parts of the scene. This is to avoid storing the geometry of each instance.
		* @param model				The Model to add.
		* @param modelId			The model id. Must be a positive integer.
		* @param transformMatrix	The Matrix4x4 transform matrix for this instance.
		* @param type				The scene object type. Occluder or Occludee.
		*/
		void addModelInstance(const Model& model, int modelId, const Matrix4x4& transformMatrix, SceneObjectType type);

		/**
		* Returns the number of Models instances in the current Scene.
		* @return The number of Model instances.
		*/
		int getModelInstancesCount() const;

		/**
		* Returns the Model Instance at the given index.
		* @param index				The zero based index of the set of Model instances.
		* @return					The Model Instance at index.
		*/
		const ModelInstance& getModelInstance(int index)const;

		/**
		* The name of the Scene.
		*/
		const string name;

		/**
		* The Scene Options used in this Scene.
		*/
		SceneOptions options;

		virtual ~Scene(void);

		Scene& Scene::operator = (const Scene& otherScene);

	private:

		vector<ModelInstance> modelInstances;

	};
}