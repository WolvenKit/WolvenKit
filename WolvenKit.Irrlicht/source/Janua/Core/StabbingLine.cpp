#include "StdAfx.h"
#include "StabbingLine.h"
#include "Plane.h"
#include "PortalQuad.h"

//#include "CollisionUtils.h"

using std::logic_error;

static int linesTested = 0;

StabbingLine::StabbingLine(void)
{
}

//Classifies a set of Axis Aligned line segments into three sets, the X, Y and Z aligned.
//Line segments must be aligned to one of the three axis or it will fail.
void classifySegmentsAxis( const vector<LineSegment>& axisAlignedLineSegments, vector<LineSegment>& xAligned,  vector<LineSegment>& yAligned,   vector<LineSegment>& zAligned)
{
	for(unsigned int c = 0 ; c < axisAlignedLineSegments.size() ; ++c)
	{
		const LineSegment& currentLine = axisAlignedLineSegments[c];

		Vector3f delta = currentLine.endPoint - currentLine.startPoint;

		if( delta == Vector3f::Zero)
			throw logic_error("There is a non axis aligned line in the set");

		if( delta.x == 0.0f && delta.y == 0.0f )
			zAligned.push_back( currentLine );

		if( delta.x == 0.0f && delta.z == 0.0f )
			yAligned.push_back( currentLine );

		if( delta.y == 0.0f && delta.z == 0.0f )
			xAligned.push_back( currentLine );
	}
}


//From real time collision detection book.
bool intersectLineSegmentPlane( const LineSegment& line, const Plane& plane, Vector3f& intersectionPoint)
{
	
	// Compute the t value for the directed line ab intersecting the plane
	Vector3f ab = line.endPoint - line.startPoint;
	float t = (plane.d - Vector3f::Dot(plane.normal, line.startPoint)) / Vector3f::Dot(plane.normal, ab);

	// If t in [0..1] compute and return intersection point
	if (t >= 0.0f && t <= 1.0f) {
		intersectionPoint = line.startPoint + t*ab;
		return true;
	}

	return false;
}


float ScalarTriple( const Vector3f& a,  const Vector3f& b,  const Vector3f& c)
{
	const Vector3f m = Vector3f::Cross(a, b);
	return Vector3f::Dot(c, m);
}
	


// Given line pq and ccw quadrilateral abcd, return whether the line
// pierces the triangle. If so, also return the point r of intersection
//From real time collision detection book.
bool IntersectLineQuad(const Vector3f p, const Vector3f q, const Vector3f a, const Vector3f b, const Vector3f c, const Vector3f d, Vector3f& r)
{
	Vector3f pq = q - p;
	Vector3f pa = a - p;
	Vector3f pb = b - p;
	Vector3f pc = c - p;

	// Determine which triangle to test against by testing against diagonal first
	Vector3f m = Vector3f::Cross(pc, pq);
	float v = Vector3f::Dot(pa, m); // ScalarTriple(pq, pa, pc);
	if (v >= 0.0f) {
		// Test intersection against triangle abc
		float u = -Vector3f::Dot(pb, m); // ScalarTriple(pq, pc, pb);
		if (u < 0.0f) return false;
		float w = ScalarTriple(pq, pb, pa);

		if (w < 0.0f) return false;

		//TODO: I added this to avoid line coplanar to Quad
		//if( u + v + w == 0.0f)
		//	return false;

		// Compute r, r = u*a + v*b + w*c, from barycentric coordinates (u, v, w)
		float denom = 1.0f / (u + v + w);
		u *= denom;
		v *= denom;
		w *= denom; // w = 1.0f - u - v;
		r = u*a + v*b + w*c;
	} else {
		// Test intersection against triangle dac
		Vector3f pd = d - p;
		float u = Vector3f::Dot(pd, m); // ScalarTriple(pq, pd, pc);
		if (u < 0.0f) return false;
		float w = ScalarTriple(pq, pa, pd);
		if (w < 0.0f) return false;
		v = -v;

		//TODO: I added this to avoid line coplanar to Quad
		//if( u + v + w == 0.0f)
		//	return false;

		// Compute r, r = u*a + v*d + w*c, from barycentric coordinates (u, v, w)
		float denom = 1.0f / (u + v + w);
		u *= denom;
		v *= denom;
		w *= denom; // w = 1.0f - u - v;
		r = u*a + v*d + w*c;
	}
	return true;
}

bool StabbingLine::StabbingLineBetweenPortalsExist( vector<PortalQuad>& portalQuads )
{ 
	
	//For each portal.
	for(unsigned int p = 0 ; p < portalQuads.size() ; ++p)
	{
		const PortalQuad& currentPortal = portalQuads[p];

		//For every point of that portal quad.
		for(unsigned int quadPoint = 0 ; quadPoint < 4 ; ++quadPoint)
		{
			const Vector3f& startPoint =  currentPortal.points[quadPoint];

			//For every other portals
			for( unsigned int otherPortalI = 0 ; otherPortalI < portalQuads.size() ; ++otherPortalI)
			{
				if( otherPortalI != p ) //Do not create a line with the points of the same portal.
				{
					//For each of the four points.
					for(unsigned int otherPortalQuadPoint = 0 ; otherPortalQuadPoint < 4 ; ++otherPortalQuadPoint)
					{
						const Vector3f& endPoint =  portalQuads[otherPortalI].points[otherPortalQuadPoint];

						bool allIntersect = true;

						//Now test if it intersects the other portals in the list.
						for( unsigned int portalsToTestI = 0 ; portalsToTestI < portalQuads.size() ; ++portalsToTestI)
						{

							//All other portals except the two selected ones.
							if( (portalsToTestI != otherPortalI && portalsToTestI != p)  )
							{
								Vector3f intersectPoint;

								//Test intersection
								bool lineStabs = IntersectLineQuad( startPoint, endPoint,	portalQuads[portalsToTestI].points[0], 
																							portalQuads[portalsToTestI].points[1], 
																							portalQuads[portalsToTestI].points[2], 
																							portalQuads[portalsToTestI].points[3], 
																							intersectPoint);
								
								++linesTested;

								//If at least one doesn't intersect from the sequence, discard the whole line. try later with another different line.
								if( lineStabs == false) {
									allIntersect = false;
									break;
								}
							}
						}

						//If a given line, intersects the whole sequence of portals, then a stabbing line exists, so return true.
						if( allIntersect )
							return true;
					}
				}
			}
		}
	}

	return false;
}

StabbingLine::~StabbingLine(void)
{
}
