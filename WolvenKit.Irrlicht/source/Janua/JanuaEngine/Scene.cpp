#include "stdafx.h"
#include "Scene.h"

using std::logic_error;

Scene::Scene(const SceneOptions& pOptions): options(pOptions), name("")
{

}

Scene::Scene(const SceneOptions& pOptions, const string& pName) : options(pOptions), name(pName)
{

}


Scene::~Scene(void)
{
}

void Scene::addModelInstance(const Model& model, int modelId, const Matrix4x4& transformMatrix, SceneObjectType type )
{
	const ModelInstance& modelInstance = ModelInstance(model, modelId, transformMatrix, type);

	//TODO: replace by another more efficient find
	for(unsigned int c = 0 ; c < modelInstances.size() ; c++ )
	{
		if( modelInstances[c].getModelId() == modelId )
			throw new logic_error("Model id already exists");
	}

	modelInstances.push_back(modelInstance);
}

int Scene::getModelInstancesCount() const
{
	return modelInstances.size();
}

const ModelInstance& Scene::getModelInstance( int index ) const
{
	assert(index < getModelInstancesCount());
	assert(index >= 0);

	return modelInstances[index];
}
