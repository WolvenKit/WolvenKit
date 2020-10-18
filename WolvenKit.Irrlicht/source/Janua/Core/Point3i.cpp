#include "StdAfx.h"
#include "Point3i.h"


Point3i::Point3i(void)
{
	x = y = z = 0;
}

Point3i::Point3i( int px, int py, int pz )
{
	x = px;
	y = py;
	z = pz;

}

Point3i::~Point3i(void)
{
}

bool operator!=( const Point3i& lhs, const Point3i& rhs  )
{
	return lhs.x != rhs.x || lhs.y != rhs.y || lhs.z != rhs.z;
}

bool operator==( const Point3i& lhs, const Point3i& rhs )
{
	return lhs.x == rhs.x && lhs.y == rhs.y && lhs.z == rhs.z;
}


//Arbitrary ordering for points. Sort in X, Y, Z order.
bool operator<( const Point3i& lhs, const Point3i& rhs )
{
	//TODO: Optimize to replace IFs.
	if( lhs.x < rhs.x)
		return true;
	else
		if( lhs.x == rhs.x)
			if(lhs.y < rhs.y)
				return true;
			else
				if(lhs.y == rhs.y)
					if(lhs.z < rhs.z)
						return true;
	
	return false;
}

Point3i Point3i::operator + (const Point3i& otherPoint)
{
	return (Point3i(x + otherPoint.x, y + otherPoint.y, z + otherPoint.z));
}

Point3i Point3i::operator - (const Point3i& otherPoint)
{
	return (Point3i(x - otherPoint.x, y - otherPoint.y, z - otherPoint.z));
}

Point3i operator + (const Point3i& lhs, const Point3i& rhs)
{
	return Point3i( lhs.x + rhs.x, lhs.y + rhs.y, lhs.z + rhs.z);
}

Point3i operator - (const Point3i& lhs, const Point3i& rhs)
{
	return Point3i( lhs.x - rhs.x, lhs.y - rhs.y, lhs.z - rhs.z);
}