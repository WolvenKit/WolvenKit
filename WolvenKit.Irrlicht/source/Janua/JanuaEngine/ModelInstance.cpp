#include "StdAfx.h"
#include "ModelInstance.h"
#include "SceneObjectType.h"

using std::min;
using std::max;
using std::logic_error;

ModelInstance::ModelInstance( const Model& pModel, int pModelId, const Matrix4x4& pTransformMatrix, SceneObjectType pType )
	: model(pModel)
{
	
	if( pModelId < 0 || pModelId >= JANUA_MAX_NUMBER_OF_MODELS )
		throw new logic_error("The model instance Id is not inside range");

	modelId = pModelId;

	transformMatrix = pTransformMatrix;
	sceneObjectType = pType;

	calculateAABB();
}

ModelInstance::~ModelInstance(void)
{

}

inline float replaceIfMin(float val, float min)
{
	if( val < min)
		return val;
	else
		return min;
}

inline float replaceIfMax(float val, float max)
{
	if( val > max)
		return val;
	else
		return max;
}

void ModelInstance::calculateAABB()
{

	Vector3f mins(FLT_MAX);
	Vector3f maxs(FLT_MIN);

	//TODO: Paralellize.
	//TODO: avoid fetching triangle per triangle, do it bulk.
	for (int i = 0 ; i < model.getTriangleCount(); i++)
	{
		Triangle transformedTriangle = Triangle::Transform(model.getTriangle(i), transformMatrix);

		mins.x = min(transformedTriangle.a.x, mins.x);
		mins.y = min(transformedTriangle.a.y, mins.y);
		mins.z = min(transformedTriangle.a.z, mins.z);

		mins.x = min(transformedTriangle.b.x, mins.x);
		mins.y = min(transformedTriangle.b.y, mins.y);
		mins.z = min(transformedTriangle.b.z, mins.z);

		mins.x = min(transformedTriangle.c.x, mins.x);
		mins.y = min(transformedTriangle.c.y, mins.y);
		mins.z = min(transformedTriangle.c.z, mins.z);


		maxs.x = max(transformedTriangle.a.x, maxs.x);
		maxs.y = max(transformedTriangle.a.y, maxs.y);
		maxs.z = max(transformedTriangle.a.z, maxs.z);
				 
		maxs.x = max(transformedTriangle.b.x, maxs.x);
		maxs.y = max(transformedTriangle.b.y, maxs.y);
		maxs.z = max(transformedTriangle.b.z, maxs.z);
				 
		maxs.x = max(transformedTriangle.c.x, maxs.x);
		maxs.y = max(transformedTriangle.c.y, maxs.y);
		maxs.z = max(transformedTriangle.c.z, maxs.z);
	}

	modelAABB.minPoint = mins;
	modelAABB.maxPoint = maxs;
}

void ModelInstance::getModelTrianglesWorldSpace(  vector<Triangle>& triangles ) const
{

	//triangles.reserve(model.getTriangleCount());

	for (int i = 0; i < (int) model.getTriangleCount() ; i++)
	{
		triangles.push_back(Triangle::Transform( model.getTriangle(i), transformMatrix)) ;
	}
}
