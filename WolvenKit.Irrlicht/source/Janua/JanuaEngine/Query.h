#pragma once

#include "PVSDatabase.h"
#include "QueryResult.h"

/**
* A Query is used to determine the Potentially Visible Set using the given PVSDatabase.
* It returns a QueryResult containing the visible Model Ids.
*/
class Query
{
public:

	/**
	* Creates a Query based on the given PVS Database
	* @param pvsDatabase	The PVSDatabase.
	*/
	Query(const PVSDatabase& pvsDatabase);
	virtual ~Query(void);

	/**
	* Gets the PVS from a point in space. It doesn't take into account the frustum.
	* Retrieves the PVS that corresponds to the cell region where the position is contained.
	* If the position given is not inside any cell, then it returns zero model Ids.
	* @param position	The vector3f position in world space.
	*/
	const QueryResult getPotentiallyVisibleObjectsFromRegion( const Vector3f position );

private:
	const PVSDatabase& m_pvsDatabase;
};

