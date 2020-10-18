#include "StdAfx.h"
#include "PortalQuad.h"


PortalQuad::PortalQuad(const Vector3f p_points[4])
{
	points[0] = p_points[0];
	points[1] = p_points[1];
	points[2] = p_points[2];
	points[3] = p_points[3];
}


PortalQuad::~PortalQuad(void)
{
}
