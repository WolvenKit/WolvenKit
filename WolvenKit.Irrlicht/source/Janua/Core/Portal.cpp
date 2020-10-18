#include "StdAfx.h"
#include "Portal.h"


Portal::Portal( shared_ptr<Cell> p_fromCell, shared_ptr<Cell> p_toCell, Point3i p_minPoint, Point3i p_maxPoint, Point3i p_facingPlane ) : fromCell(p_fromCell), toCell(p_toCell), minPoint(p_minPoint), maxPoint(p_maxPoint), facingPlane(p_facingPlane)
{

}


Portal::~Portal(void)
{
}
