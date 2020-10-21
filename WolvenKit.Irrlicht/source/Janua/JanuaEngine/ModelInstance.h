/*  ******************************************************************************* **
 * GIGC - Grupo de Investigación de Gráficos por Computadora - UTN FRBA - Argentina
 * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *  **
 * <copyright> copyright (c) 2013 </copyright>	
 * <autor> Leandro Roberto Barbagallo </autor>
 * <license href="https://github.com/gigc/Janua">MIT</license>
 ********************************************************************************** */

#pragma once
#include "..\Core\Matrix4x4.h"
#include "Model.h"
#include "SceneObjectType.h"
#include "..\Core\AABB.h"

#define JANUA_MAX_NUMBER_OF_MODELS 1048576

namespace Janua
{
	/**
	* A ModelInstance is a Model instanciated in the Scene and can be an Occluder or an Occludee.
	* Each ModelInstance has the same geometry of the original Model but it is transformed using the given Matrix4x4.
	* The ModelInstance can one of the options given by SceneObjectType.
	* It is identified uniquely by it's Model Id that is a number from 0 to 1,048,575. If value is outside range will throw an exception.
	*/
	class ModelInstance
	{
	public:


		/**
		* Creates an ModelInstance in the scene.
		* @param pModel				The Model to use.
		* @param pModelId			The unique identifier from 0 to 1,048,575.
		* @param pTransformMatrix	The 4x4 transform matrix.
		* @param pType				The type of SceneObjectType role that this ModelInstance has has inside the scene.
		*/
		ModelInstance(const Model& pModel, int pModelId, const Matrix4x4& pTransformMatrix, SceneObjectType pType);
		virtual ~ModelInstance(void);

		/**
		* Returns the Axis Aligned Bounding Box (AABB) of the ModelInstance. It is the AABB in world space.
		* @return The AABB of the transformed ModelInstance.
		*/
		AABB getModelAABB(void) const { return modelAABB; }; //Get the Model Axis Aligned Bounding Box.

		/**
		* Inserts the ModelInstance triangles to the given triangle array. The triangles are in world space.
		* @param triangles	The triangle vector to populate.
		*/
		void getModelTrianglesWorldSpace(vector<Triangle>& triangles) const;

		/**
		* Returns the ModelInstance unique identifier.
		* @return The integer identifier.
		*/
		const int getModelId() const { return modelId; };

		/**
		* Returns the SceneObjectType of the ModelInstance.
		* @return A SceneObjectType.
		*/
		const SceneObjectType getModelType() const { return sceneObjectType; };


		ModelInstance& ModelInstance::operator= (const ModelInstance& otherModelInstance);

	private:

		void calculateAABB();

		const Model& model;
		int modelId;

		AABB modelAABB;
		bool modelAABBcreated;
		Matrix4x4 transformMatrix;
		SceneObjectType sceneObjectType;
	};
}
