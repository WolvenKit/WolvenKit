#include "stdafx.h"
#include "Model.h"
#include <assert.h>
#include "..\Core\Triangle.h"
#include <stdexcept>

using std::logic_error;

Model::Model(const float pVertices[], int pVerticesCount, const int pIndices[], int pTriangleCount)
{

	//Verify that the vertices count and indices count are valid.
	assert( pVertices > 0 );
	assert( pTriangleCount > 0 );


	vertices.reserve(pVerticesCount * 3);
	indices.reserve(pTriangleCount * 3 ); //Three indices per triangle
	
	//TODO: Verify that all indices point to existing vertices.

	//Copy the vertices and indices to own buffer.
	for (int i = 0; i < pVerticesCount * 3; i++)
	{
		vertices.push_back( pVertices[i]);
	}

	for (int i = 0; i < pTriangleCount * 3 ; i++)
	{
		if( pIndices[i] >= pVerticesCount )
			throw  logic_error("An index points to unexisting vertex.");

		indices.push_back( pIndices[i]);
	}

		
}


Model::~Model(void)
{
}


Triangle Model::getTriangle( int triangleId ) const
{
	//Check index bounds.
	assert( triangleId < getTriangleCount());
	
	//The starting vertex index of the triangle.
	int vertexIndex1, vertexIndex2, vertexIndex3;


	vertexIndex1 = indices[triangleId*3];
	vertexIndex2 = indices[triangleId*3 + 1];
	vertexIndex3 = indices[triangleId*3 + 2];

	Vector3f vec1, vec2, vec3;

	vec1.x = vertices[ vertexIndex1*3];
	vec1.y = vertices[ vertexIndex1*3 + 1];
	vec1.z = vertices[ vertexIndex1*3 + 2];

	vec2.x = vertices[ vertexIndex2*3 ];
	vec2.y = vertices[ vertexIndex2*3 + 1];
	vec2.z = vertices[ vertexIndex2*3 + 2];

	vec3.x = vertices[ vertexIndex3*3];
	vec3.y = vertices[ vertexIndex3*3 + 1];
	vec3.z = vertices[ vertexIndex3*3 + 2];


	return Triangle( vec1, vec2, vec3 );
}

int Model::getTriangleCount() const
{
	return static_cast<int>(indices.size() / 3);
}

int Model::getIndicesCount() const
{
	return static_cast<int>(indices.size());
}

int Model::getIndex( int indexId ) const
{
	assert( indexId > 0 );
	assert( indexId < getIndicesCount() );

	return indices[indexId];
}
