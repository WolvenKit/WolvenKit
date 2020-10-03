#pragma once

#include "stdafx.h"

using namespace irr;
using namespace System;

namespace IrrlichtLime {
namespace Core {

/// <summary>
/// 3D line between two points with intersection methods.
/// </summary>
public ref class Line3Df : Lime::NativeValue<core::line3df>
{
public:

	/// <summary>
	/// Equality operator.
	/// </summary>
	static bool operator == (Line3Df^ v1, Line3Df^ v2)
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
	static bool operator != (Line3Df^ v1, Line3Df^ v2)
	{
		return !(v1 == v2);
	}

	/// <summary>
	/// Default constructor.
	/// Initializes line from (0,0,0) to (1,1,1).
	/// </summary>
	Line3Df()
		: Lime::NativeValue<core::line3df>(true)
	{
		m_NativeValue = new core::line3df();
	}

	/// <summary>
	/// Copy constructor.
	/// </summary>
	/// <param name="copy">Other line.</param>
	Line3Df(Line3Df^ copy)
		: Lime::NativeValue<core::line3df>(true)
	{
		LIME_ASSERT(copy != nullptr);

		m_NativeValue = new core::line3df();
		m_NativeValue->setLine(*copy->m_NativeValue);
	}

	/// <summary>
	/// Constructor with two points.
	/// </summary>
	/// <param name="startX">Start X coord.</param>
	/// <param name="startY">Start Y coord.</param>
	/// <param name="startZ">Start Z coord.</param>
	/// <param name="endX">End X coord.</param>
	/// <param name="endY">End Y coord.</param>
	/// <param name="endZ">End Z coord.</param>
	Line3Df(float startX, float startY, float startZ, float endX, float endY, float endZ)
		: Lime::NativeValue<core::line3df>(true)
	{
		m_NativeValue = new core::line3df(startX, startY, startZ, endX, endY, endZ);
	}

	/// <summary>
	/// Constructor with two points.
	/// </summary>
	/// <param name="start">Start point.</param>
	/// <param name="end">End point.</param>
	Line3Df(Vector3Df^ start, Vector3Df^ end)
		: Lime::NativeValue<core::line3df>(true)
	{
		LIME_ASSERT(start != nullptr);
		LIME_ASSERT(end != nullptr);

		m_NativeValue = new core::line3df(*start->m_NativeValue, *end->m_NativeValue);
	}

	/// <summary>
	/// Set this line to a new line going through the two points.
	/// </summary>
	/// <param name="startX">Start X coord.</param>
	/// <param name="startY">Start Y coord.</param>
	/// <param name="startZ">Start Z coord.</param>
	/// <param name="endX">End X coord.</param>
	/// <param name="endY">End Y coord.</param>
	/// <param name="endZ">End Z coord.</param>
	void Set(float startX, float startY, float startZ, float endX, float endY, float endZ)
	{
		m_NativeValue->setLine(startX, startY, startZ, endX, endY, endZ);
	}

	/// <summary>
	/// Set this line to a new line going through the two points.
	/// </summary>
	/// <param name="start">Start point.</param>
	/// <param name="end">End point.</param>
	void Set(Vector3Df^ start, Vector3Df^ end)
	{
		LIME_ASSERT(start != nullptr);
		LIME_ASSERT(end != nullptr);

		m_NativeValue->setLine(*start->m_NativeValue, *end->m_NativeValue);
	}

	/// <summary>
	/// Set this line to a new line.
	/// </summary>
	/// <param name="newLine">New line.</param>
	void Set(Line3Df^ newLine)
	{
		LIME_ASSERT(newLine != nullptr);
		m_NativeValue->setLine(*newLine->m_NativeValue);
	}

	/// <summary>
	/// Check if the given point is between start and end of the line.
	/// Assumes that the point is already somewhere on the line.
	/// </summary>
	/// <param name="point">The point to test.</param>
	/// <returns>True if point is on the line between start and end, else false.</returns>
	bool IsPointBetweenStartAndEnd(Vector3Df^ point)
	{
		LIME_ASSERT(point != nullptr);
		return m_NativeValue->isPointBetweenStartAndEnd(*point->m_NativeValue);
	}

	/// <summary>
	/// Get the closest point on this line to a point.
	/// </summary>
	/// <param name="point">The point to compare to.</param>
	/// <returns>The nearest point which is part of the line.</returns>
	Vector3Df^ GetClosestPoint(Vector3Df^ point)
	{
		LIME_ASSERT(point != nullptr);
		return gcnew Vector3Df(m_NativeValue->getClosestPoint(*point->m_NativeValue));
	}

	/// <summary>
	/// Check if the line intersects with a sphere.
	/// </summary>
	/// <param name="sphereOrigin">Origin of the sphere.</param>
	/// <param name="sphereRadius">Radius of the sphere.</param>
	/// <param name="distance">The distance to the first intersection point.</param>
	/// <returns>True if there is an intersection. If there is one, the distance to the first intersection point is stored in "distance".</returns>
	bool GetIntersectionWithSphere(Vector3Df^ sphereOrigin, float sphereRadius, [Out] double% distance)
	{
		LIME_ASSERT(sphereOrigin != nullptr);

		f64 d = 0.0f;
		bool b = m_NativeValue->getIntersectionWithSphere(
			*sphereOrigin->m_NativeValue,
			sphereRadius,
			d);

		if (b)
			distance = d;

		return b;
	}

	/// <summary>
	/// Length of line.
	/// </summary>
	property float Length
	{
		float get() { return m_NativeValue->getLength(); }
	}

	/// <summary>
	/// Squared length of line.
	/// </summary>
	property float LengthSQ
	{
		float get() { return m_NativeValue->getLengthSQ(); }
	}

	/// <summary>
	/// Center of line.
	/// </summary>
	property Vector3Df^ Middle
	{
		Vector3Df^ get() { return gcnew Vector3Df(m_NativeValue->getMiddle()); }
	}

	/// <summary>
	/// Vector of line.
	/// </summary>
	property Vector3Df^ Vector
	{
		Vector3Df^ get() { return gcnew Vector3Df(m_NativeValue->getVector()); }
	}

	/// <summary>
	/// Start point of line.
	/// </summary>
	property Vector3Df^ Start
	{
		Vector3Df^ get() { return gcnew Vector3Df(m_NativeValue->start); }
		void set(Vector3Df^ value) { LIME_ASSERT(value != nullptr); m_NativeValue->start = *value->m_NativeValue; }
	}

	/// <summary>
	/// End point of line.
	/// </summary>
	property Vector3Df^ End
	{
		Vector3Df^ get() { return gcnew Vector3Df(m_NativeValue->end); }
		void set(Vector3Df^ value) { LIME_ASSERT(value != nullptr); m_NativeValue->end = *value->m_NativeValue; }
	}

	virtual String^ ToString() override
	{
		return String::Format("({0}) - ({1})", Start, End);
	}

internal:

	Line3Df(const core::line3df& value)
		: Lime::NativeValue<core::line3df>(true)
	{
		m_NativeValue = new core::line3df(value);
	}
};

} // end namespace Core
} // end namespace IrrlichtLime
