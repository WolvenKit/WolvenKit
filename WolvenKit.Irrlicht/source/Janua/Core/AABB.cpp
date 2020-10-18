#include "StdAfx.h"
#include "AABB.h"

AABB::AABB()
{

}

AABB::AABB( Vector3f pMinPoint, Vector3f pMaxPoint ) : minPoint(pMinPoint), maxPoint(pMaxPoint)
{
	assert(pMinPoint.x <= pMaxPoint.x);
	assert(pMinPoint.y <= pMaxPoint.y);
	assert(pMinPoint.z <= pMaxPoint.z);
}

AABB::~AABB(void)
{

}
