#include "StdAfx.h"
#include "Triangle.h"
#include "Vector3f.h"
#include "Matrix4x4.h"

Triangle::Triangle( const Vector3f& pA, const Vector3f& pB, const Vector3f& pC ) : a(pA), b(pB), c(pC)
{

}

Triangle::~Triangle(void)
{
}

Triangle Triangle::Transform( const Triangle pOriginalTriangle, const Matrix4x4& pTransformMatrix )
{
	return Triangle(
		Vector3f::Transform(pOriginalTriangle.a, pTransformMatrix),
		Vector3f::Transform(pOriginalTriangle.b, pTransformMatrix),
		Vector3f::Transform(pOriginalTriangle.c, pTransformMatrix)
		);

}
