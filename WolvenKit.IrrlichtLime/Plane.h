#pragma once

#include "stdafx.h"

using namespace irr;
using namespace System;

namespace IrrlichtLime {
namespace Core {

/// <summary>
/// Plane class with some intersection testing methods.
/// It has to be ensured, that the normal is always normalized.
/// The constructors and setters of this class will not ensure this automatically.
/// So any normal passed in has to be normalized in advance.
/// No change to the normal will be made by any of the class methods.
/// </summary>
public ref class Plane3Df : Lime::NativeValue<core::plane3df>
{
public:

	/// <summary>
	/// Equality operator.
	/// </summary>
	static bool operator == (Plane3Df^ v1, Plane3Df^ v2)
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
	static bool operator != (Plane3Df^ v1, Plane3Df^ v2)
	{
		return !(v1 == v2);
	}

	/// <summary>
	/// Constructs plane from member point (0,0,0) and normal (0,1,0).
	/// </summary>
	Plane3Df()
		: Lime::NativeValue<core::plane3df>(true)
	{
		m_NativeValue = new core::plane3df();
	}

	/// <summary>
	/// Copy constructor.
	/// </summary>
	Plane3Df(Plane3Df^ copy)
		: Lime::NativeValue<core::plane3df>(true)
	{
		LIME_ASSERT(copy != nullptr);
		m_NativeValue = new core::plane3df(copy->m_NativeValue->Normal, copy->m_NativeValue->D);
	}

	/// <summary>
	/// Constructs plane from specified member point and normal.
	/// </summary>
	Plane3Df(Vector3Df^ memberPoint, Vector3Df^ normal)
		: Lime::NativeValue<core::plane3df>(true)
	{
		LIME_ASSERT(memberPoint != nullptr);
		LIME_ASSERT(normal != nullptr);

		m_NativeValue = new core::plane3df(*memberPoint->m_NativeValue, *normal->m_NativeValue);
	}

	/// <summary>
	/// Constructs plane from specified member point and normal.
	/// </summary>
	Plane3Df(float pointX, float pointY, float pointZ, float normalX, float normalY, float normalZ)
		: Lime::NativeValue<core::plane3df>(true)
	{
		m_NativeValue = new core::plane3df(pointX, pointY, pointZ, normalX, normalY, normalZ);
	}

	/// <summary>
	/// Constructs plane from three member points.
	/// </summary>
	Plane3Df(Vector3Df^ point1, Vector3Df^ point2, Vector3Df^ point3)
		: Lime::NativeValue<core::plane3df>(true)
	{
		LIME_ASSERT(point1 != nullptr);
		LIME_ASSERT(point2 != nullptr);
		LIME_ASSERT(point3 != nullptr);

		m_NativeValue = new core::plane3df(*point1->m_NativeValue, *point2->m_NativeValue, *point3->m_NativeValue);
	}

	/// <summary>
	/// Constructs plane from normal and the distance from origin.
	/// </summary>
	Plane3Df(Vector3Df^ normal, float d)
		: Lime::NativeValue<core::plane3df>(true)
	{
		LIME_ASSERT(normal != nullptr);
		m_NativeValue = new core::plane3df(*normal->m_NativeValue, d);
	}

	/// <summary>
	/// Set this plane from specified member point and normal.
	/// </summary>
	void Set(Vector3Df^ memberPoint, Vector3Df^ normal)
	{
		LIME_ASSERT(memberPoint != nullptr);
		LIME_ASSERT(normal != nullptr);

		m_NativeValue->setPlane(*memberPoint->m_NativeValue, *normal->m_NativeValue);
	}

	/// <summary>
	/// Set this plane from three member points.
	/// </summary>
	void Set(Vector3Df^ point1, Vector3Df^ point2, Vector3Df^ point3)
	{
		LIME_ASSERT(point1 != nullptr);
		LIME_ASSERT(point2 != nullptr);
		LIME_ASSERT(point3 != nullptr);

		m_NativeValue->setPlane(*point1->m_NativeValue, *point2->m_NativeValue, *point3->m_NativeValue);
	}

	/// <summary>
	/// Set this plane from normal and the distance from origin.
	/// </summary>
	void Set(Vector3Df^ normal, float d)
	{
		LIME_ASSERT(normal != nullptr);
		m_NativeValue->setPlane(*normal->m_NativeValue, d);
	}

	/// <summary>
	/// Get an intersection with a 3d line.
	/// </summary>
	/// <param name="linePoint">Point of the line to intersect with.</param>
	/// <param name="lineVect">Vector of the line to intersect with.</param>
	/// <returns>The intersection point, or null if none.</returns>
	Vector3Df^ GetIntersectionWithLine(Vector3Df^ linePoint, Vector3Df^ lineVect)
	{
		LIME_ASSERT(linePoint != nullptr);
		LIME_ASSERT(lineVect != nullptr);

		core::vector3df i;
		bool b = m_NativeValue->getIntersectionWithLine(
			*linePoint->m_NativeValue,
			*lineVect->m_NativeValue,
			i);

		if (b)
			return gcnew Vector3Df(i);

		return nullptr;
	}

	/// <summary>
	/// Get percentage of line between two points where an intersection with this plane happens.
	/// Only useful if known that there is an intersection.
	/// </summary>
	/// <returns>Where on a line between two points an intersection with this plane happened.
	/// For example, 0.5 is returned if the intersection happened exactly in the middle of the two points.</returns>
	float GetKnownIntersectionWithLine(Vector3Df^ linePoint1, Vector3Df^ linePoint2)
	{
		LIME_ASSERT(linePoint1 != nullptr);
		LIME_ASSERT(linePoint2 != nullptr);

		return m_NativeValue->getKnownIntersectionWithLine(*linePoint1->m_NativeValue, *linePoint2->m_NativeValue);
	}

	/// <summary>
	/// Get an intersection with a 3d line, limited between two 3d points.
	/// </summary>
	/// <returns>The intersection point, or null if none.</returns>
	Vector3Df^ GetIntersectionWithLimitedLine(Vector3Df^ linePoint1, Vector3Df^ linePoint2)
	{
		LIME_ASSERT(linePoint1 != nullptr);
		LIME_ASSERT(linePoint2 != nullptr);

		core::vector3df i;
		bool b = m_NativeValue->getIntersectionWithLimitedLine(
			*linePoint1->m_NativeValue,
			*linePoint2->m_NativeValue,
			i);

		if (b)
			return gcnew Vector3Df(i);

		return nullptr;
	}

	/// <summary>
	/// Get the intersection with other plane if there is one.
	/// </summary>
	/// <param name="other">Other plane to intersect with.</param>
	/// <param name="intersectionLinePoint">Base point of intersection line.</param>
	/// <param name="intersectionLineVector">Vector of intersection.</param>
	/// <returns>True if there is a intersection, false if not.</returns>
	bool GetIntersectionWithPlane(Plane3Df^ other, [Out] Vector3Df^% intersectionLinePoint, [Out] Vector3Df^% intersectionLineVector)
	{
		LIME_ASSERT(other != nullptr);

		core::vector3df p;
		core::vector3df v;
		bool b = m_NativeValue->getIntersectionWithPlane(
			*other->m_NativeValue,
			p, v);

		if (b)
		{
			intersectionLinePoint = gcnew Vector3Df(p);
			intersectionLineVector = gcnew Vector3Df(v);
		}

		return b;
	}

	/// <summary>
	/// Get the intersection point with two other planes if there is one.
	/// </summary>
	/// <returns>The intersection point, or null if none.</returns>
	Vector3Df^ GetIntersectionWithPlanes(Plane3Df^ other1, Plane3Df^ other2)
	{
		LIME_ASSERT(other1 != nullptr);
		LIME_ASSERT(other2 != nullptr);

		core::vector3df p;
		bool b = m_NativeValue->getIntersectionWithPlanes(
			*other1->m_NativeValue,
			*other2->m_NativeValue,
			p);

		if (b)
			return gcnew Vector3Df(p);

		return nullptr;
	}

	/// <summary>
	/// Test if the triangle would be front or backfacing from any point.
	/// Thus, this method assumes a camera position from which the triangle is definitely visible when looking into the given direction.
	/// Note that this only works if the normal is normalized.
	/// Do not use this method with points as it will give wrong results!
	/// </summary>
	bool IsFrontFacing(Vector3Df^ lookDirection)
	{
		LIME_ASSERT(lookDirection != nullptr);
		return m_NativeValue->isFrontFacing(*lookDirection->m_NativeValue);
	}

	/// <summary>
	/// Get the distance to a point.
	/// Note that this only works if the normal is normalized.
	/// </summary>
	float GetDistanceTo(Vector3Df^ point)
	{
		LIME_ASSERT(point != nullptr);
		return m_NativeValue->getDistanceTo(*point->m_NativeValue);
	}

	/// <summary>
	/// Tests if there is an intersection with the other plane.
	/// </summary>
	bool ExistsIntersection(Plane3Df^ other)
	{
		LIME_ASSERT(other != nullptr);
		return m_NativeValue->existsIntersection(*other->m_NativeValue);
	}

	/// <summary>
	/// Member point of the plane.
	/// </summary>
	property Vector3Df^ MemberPoint
	{
		Vector3Df^ get() { return gcnew Vector3Df(m_NativeValue->getMemberPoint()); }
		void set(Vector3Df^ value) { LIME_ASSERT(value != nullptr); m_NativeValue->recalculateD(*value->m_NativeValue); }
	}

	/// <summary>
	/// Normal vector of the plane.
	/// </summary>
	property Vector3Df^ Normal
	{
		Vector3Df^ get() { return gcnew Vector3Df(m_NativeValue->Normal); }
		void set(Vector3Df^ value) { LIME_ASSERT(value != nullptr); m_NativeValue->Normal = *value->m_NativeValue; }
	}

	/// <summary>
	/// Distance from origin.
	/// </summary>
	property float D
	{
		float get() { return m_NativeValue->D; }
		void set(float value) { m_NativeValue->D = value; }
	}

	virtual String^ ToString() override
	{
		return String::Format("({0}) D={1}", Normal, D);
	}

internal:

	Plane3Df(const core::plane3df& value)
		: Lime::NativeValue<core::plane3df>(true)
	{
		m_NativeValue = new core::plane3df(value);
	}
};

} // end namespace Core
} // end namespace IrrlichtLime
