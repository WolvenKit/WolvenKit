#include "StdAfx.h"
#include "Ray.h"

using std::logic_error;

Ray::Ray(void)
{
	origin = Vector3f::Zero;
	direction.x = 1;
	direction.y = 0;
	direction.z = 0;
}

Ray::Ray(const Vector3f p_origin, const Vector3f p_direction)
{
	origin = p_origin;
	direction = p_direction;

	if( origin == direction)
		throw logic_error("Invalid Ray.");
}

Ray::~Ray(void)
{
}
