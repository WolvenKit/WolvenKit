#include "StdAfx.h"
#include "Plane.h"


Plane::Plane(const Vector3f p_normal, float p_d) : normal( p_normal), d(p_d)
{

	//TODO: check the normal is a unit vector.
}


Plane::~Plane(void)
{
}
