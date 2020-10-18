#include "StdAfx.h"
#include "LineSegment.h"

using std::logic_error;

LineSegment::LineSegment(Vector3f p_StartPoint, Vector3f p_EndPoint) : startPoint(p_StartPoint), endPoint(p_EndPoint)
{
	if( p_StartPoint == p_EndPoint )
		throw new logic_error("Invalid Line segment");
}


LineSegment::~LineSegment(void)
{
}
