/********************************************************/
/* AABB-triangle overlap test code                      */
/* by Tomas Akenine-Möller                              */
/* Function: int triBoxOverlap(float boxcenter[3],      */
/*          float boxhalfsize[3],float triverts[3][3]); */
/* History:                                             */
/*   2001-03-05: released the code in its first version */
/*   2001-06-18: changed the order of the tests, faster */
/*                                                      */
/* Acknowledgement: Many thanks to Pierre Terdiman for  */
/* suggestions and discussions on how to optimize code. */
/* Thanks to David Hunt for finding a ">="-bug!         */
/********************************************************/

#pragma once

#include "LineSegment.h"
#include "Vector3f.h"
#include "Plane.h"


#include <math.h>
#include <stdio.h>



/**
* Intersection and collision detection routines
*/
class CollisionUtils
{

public:

	/**
	* Plane-Box collision
	*/
	static int planeBoxOverlap(float normal[3], float vert[3], float maxbox[3]);

	/**
	* Triangle-Box collision
	*/
	static int triBoxOverlap(float boxcenter[3],float boxhalfsize[3],float triverts[3][3]);



	#define NUMDIM	3
	#define RIGHT	0
	#define LEFT	1
	#define MIDDLE	2
	#define TRUE	1
	#define FALSE	0

	/* 
	Fast Ray-Box Intersection
	by Andrew Woo
	from "Graphics Gems", Academic Press, 1990
	*/
	static bool HitBoundingBox(double minB[NUMDIM], double maxB[NUMDIM], double origin[NUMDIM], double dir[NUMDIM], double coord[NUMDIM]);

	/**
	* AABB-AABB test
	*/
	static bool boxBoxOverlapTest(float aMin[3], float aMax[3], float bMin[3], float bMax[3]);

};



