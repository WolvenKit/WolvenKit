#pragma once

#include "stdafx.h"

using namespace irr;
using namespace System;

namespace IrrlichtLime {
namespace Core {

/// <summary>
/// 3D triangle class for doing collision detection and other things.
/// </summary>
public ref class Triangle3Df : Lime::NativeValue<core::triangle3df>
{
public:

	/// <summary>
	/// Equality operator.
	/// </summary>
	static bool operator == (Triangle3Df^ v1, Triangle3Df^ v2)
	{
		bool v1n = Object::ReferenceEquals(v1, nullptr);
		bool v2n = Object::ReferenceEquals(v2, nullptr);

		if (v1n && v2n)
			return true;

		if (v1n || v2n)
			return false;

		return (*v1->m_NativeValue) == (*v2->m_NativeValue);
	}

	/// <summary>
	/// Inequality operator.
	/// </summary>
	static bool operator != (Triangle3Df^ v1, Triangle3Df^ v2)
	{
		return !(v1 == v2);
	}

	/// <summary>
	/// Constructor for an all 0 triangle.
	/// </summary>
	Triangle3Df()
		: Lime::NativeValue<core::triangle3df>(true)
	{
		m_NativeValue = new core::triangle3df();
	}

	/// <summary>
	/// Copy constructor.
	/// </summary>
	/// <param name="copy">Other triangle.</param>
	Triangle3Df(Triangle3Df^ copy)
		: Lime::NativeValue<core::triangle3df>(true)
	{
		LIME_ASSERT(copy != nullptr);
		m_NativeValue = new core::triangle3df(copy->m_NativeValue->pointA, copy->m_NativeValue->pointB, copy->m_NativeValue->pointC);
	}

	/// <summary>
	/// Constructor for triangle with given three vertices.
	/// </summary>
	/// <param name="point1">First point.</param>
	/// <param name="point2">Second point.</param>
	/// <param name="point3">Third point.</param>
	Triangle3Df(Vector3Df^ point1, Vector3Df^ point2, Vector3Df^ point3)
		: Lime::NativeValue<core::triangle3df>(true)
	{
		LIME_ASSERT(point1 != nullptr);
		LIME_ASSERT(point2 != nullptr);
		LIME_ASSERT(point3 != nullptr);

		m_NativeValue = new core::triangle3df(*point1->m_NativeValue, *point2->m_NativeValue, *point3->m_NativeValue);
	}

	/// <summary>
	/// Sets the triangle's points.
	/// </summary>
	/// <param name="point1">First point.</param>
	/// <param name="point2">Second point.</param>
	/// <param name="point3">Third point.</param>
	void Set(Vector3Df^ point1, Vector3Df^ point2, Vector3Df^ point3)
	{
		LIME_ASSERT(point1 != nullptr);
		LIME_ASSERT(point2 != nullptr);
		LIME_ASSERT(point3 != nullptr);

		m_NativeValue->set(*point1->m_NativeValue, *point2->m_NativeValue, *point3->m_NativeValue);
	}

	/// <summary>
	/// Get the closest point on a triangle to a point on the same plane.
	/// </summary>
	/// <param name="point">Point which must be on the same plane as the triangle.</param>
	/// <returns>The closest point of the triangle.</returns>
	Vector3Df^ GetClosestPointOnTriangle(Vector3Df^ point)
	{
		LIME_ASSERT(point != nullptr);
		return gcnew Vector3Df(m_NativeValue->closestPointOnTriangle(*point->m_NativeValue));
	}

	/// <summary>
	/// Determines if the triangle is totally inside a bounding box.
	/// </summary>
	/// <param name="box">Box to check.</param>
	/// <returns>True if triangle is within the box, otherwise false.</returns>
	bool IsTotalInsideBox(AABBox^ box)
	{
		LIME_ASSERT(box != nullptr);
		return m_NativeValue->isTotalInsideBox(*box->m_NativeValue);
	}

	/// <summary>
	/// Determines if the triangle is totally outside a bounding box.
	/// </summary>
	/// <param name="box">Box to check.</param>
	/// <returns>True if triangle is outside the box, otherwise false.</returns>
	bool IsTotalOutsideBox(AABBox^ box)
	{
		LIME_ASSERT(box != nullptr);
		return m_NativeValue->isTotalOutsideBox(*box->m_NativeValue);
	}

	/// <summary>
	/// Test if the triangle would be front or backfacing from any point.
	/// Thus, this method assumes a camera position from which the triangle is definitely visible when looking at the given direction.
	/// Do not use this method with points as it will give wrong results!
	/// </summary>
	/// <param name="lookDirection">Look direction.</param>
	/// <returns>True if the plane is front facing and false if it is backfacing.</returns>
	bool IsFrontFacing(Vector3Df^ lookDirection)
	{
		LIME_ASSERT(lookDirection != nullptr);
		return m_NativeValue->isFrontFacing(*lookDirection->m_NativeValue);
	}

	/// <summary>
	/// Check if a point is inside the triangle (border-points count also as inside).
	/// </summary>
	/// <param name="point">Point to test. Assumes that this point is already on the plane of the triangle.</param>
	/// <returns>True if the point is inside the triangle, otherwise false.</returns>
	bool IsPointInside(Vector3Df^ point)
	{
		LIME_ASSERT(point != nullptr);
		return m_NativeValue->isPointInside(*point->m_NativeValue);
	}

	/// <summary>
	/// Check if a point is inside the triangle (border-points count also as inside).
	/// This method uses a barycentric coordinate system.
	/// It is faster than <c>isPointInside()</c> but is more susceptible to floating point rounding errors.
	/// This will especially be noticeable when the FPU is in single precision mode (which is for example set on default by Direct3D).
	/// </summary>
	/// <param name="point">Point to test. Assumes that this point is already on the plane of the triangle.</param>
	/// <returns>True if the point is inside the triangle, otherwise false.</returns>
	bool IsPointInsideFast(Vector3Df^ point)
	{
		LIME_ASSERT(point != nullptr);
		return m_NativeValue->isPointInsideFast(*point->m_NativeValue);
	}

	/// <summary>
	/// Get an intersection with a 3d line.
	/// Please note that also points are returned as intersection which are on the line, but not between the start and end point of the line.
	/// If you want the returned point be between start and end use <c>GetIntersectionWithLimitedLine()</c>.
	/// </summary>
	/// <param name="linePoint">Point of the line to intersect with.</param>
	/// <param name="lineVect">Vector of the line to intersect with.</param>
	/// <param name="intersection">Place to store the intersection point, if there is one.</param>
	/// <returns>True if there was an intersection, false if there was not.</returns>
	bool GetIntersectionWithLine(Vector3Df^ linePoint, Vector3Df^ lineVect, [Out] Vector3Df^% intersection)
	{
		LIME_ASSERT(linePoint != nullptr);
		LIME_ASSERT(lineVect != nullptr);

		core::vector3df i;
		bool b = m_NativeValue->getIntersectionWithLine(
			*linePoint->m_NativeValue,
			*lineVect->m_NativeValue,
			i);

		if (b)
			intersection = gcnew Vector3Df(i);

		return b;
	}

	/// <summary>
	/// Get an intersection with a 3d line.
	/// </summary>
	/// <param name="line">Line to intersect with.</param>
	/// <param name="intersection">Place to store the intersection point, if there is one.</param>
	/// <returns>True if there was an intersection, false if not.</returns>
	bool GetIntersectionWithLimitedLine(Line3Df^ line, [Out] Vector3Df^% intersection)
	{
		LIME_ASSERT(line != nullptr);

		core::vector3df i;
		bool b = m_NativeValue->getIntersectionWithLimitedLine(
			*line->m_NativeValue,
			i);

		if (b)
			intersection = gcnew Vector3Df(i);

		return b;
	}

	/// <summary>
	/// Calculates the intersection between a 3d line and the plane the triangle is on.
	/// </summary>
	/// <param name="linePoint">Point of the line to intersect with.</param>
	/// <param name="lineVect">Vector of the line to intersect with.</param>
	/// <param name="intersection">Place to store the intersection point, if there is one.</param>
	/// <returns>True if there was an intersection, else false.</returns>
	bool GetIntersectionOfPlaneWithLine(Vector3Df^ linePoint, Vector3Df^ lineVect, [Out] Vector3Df^% intersection)
	{
		LIME_ASSERT(linePoint != nullptr);
		LIME_ASSERT(lineVect != nullptr);

		core::vector3df i;
		bool b = m_NativeValue->getIntersectionOfPlaneWithLine(
			*linePoint->m_NativeValue,
			*lineVect->m_NativeValue,
			i);

		if (b)
			intersection = gcnew Vector3Df(i);

		return b;
	}

	/// <summary>
	/// The plane of the triangle.
	/// </summary>
	property Plane3Df^ Plane
	{
		Plane3Df^ get() { return gcnew Plane3Df(m_NativeValue->getPlane()); }
	}

	/// <summary>
	/// The area of the triangle.
	/// </summary>
	property float Area
	{
		float get() { return m_NativeValue->getArea(); }
	}

	/// <summary>
	/// The normal of the triangle.
	/// Please note: The normal is not always normalized.
	/// </summary>
	property Vector3Df^ Normal
	{
		Vector3Df^ get() { return gcnew Vector3Df(m_NativeValue->getNormal()); }
	}

	/// <summary>
	/// Point A of the triangle.
	/// </summary>
	property Vector3Df^ A
	{
		Vector3Df^ get() { return gcnew Vector3Df(m_NativeValue->pointA); }
		void set(Vector3Df^ value) { LIME_ASSERT(value != nullptr); m_NativeValue->pointA = *value->m_NativeValue; }
	}

	/// <summary>
	/// Point B of the triangle.
	/// </summary>
	property Vector3Df^ B
	{
		Vector3Df^ get() { return gcnew Vector3Df(m_NativeValue->pointB); }
		void set(Vector3Df^ value) { LIME_ASSERT(value != nullptr); m_NativeValue->pointB = *value->m_NativeValue; }
	}

	/// <summary>
	/// Point C of the triangle.
	/// </summary>
	property Vector3Df^ C
	{
		Vector3Df^ get() { return gcnew Vector3Df(m_NativeValue->pointC); }
		void set(Vector3Df^ value) { LIME_ASSERT(value != nullptr); m_NativeValue->pointC = *value->m_NativeValue; }
	}

	virtual String^ ToString() override
	{
		return String::Format("({0}) - ({1}) - ({2})", A, B, C);
	}

internal:

	Triangle3Df(const core::triangle3df& value)
		: Lime::NativeValue<core::triangle3df>(true)
	{
		m_NativeValue = new core::triangle3df(value);
	}
};

} // end namespace Core
} // end namespace IrrlichtLime
