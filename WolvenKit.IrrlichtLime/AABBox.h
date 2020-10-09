#pragma once

#include "stdafx.h"

using namespace irr;
using namespace System;

namespace IrrlichtLime {
namespace Core {

/// <summary>
/// Axis aligned bounding box in 3d dimensional space.
/// Has some useful methods used with occlusion culling or clipping.
/// </summary>
public ref class AABBox : Lime::NativeValue<core::aabbox3df>
{
public:

	/// <summary>
	/// Equality operator.
	/// </summary>
	static bool operator == (AABBox^ v1, AABBox^ v2)
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
	static bool operator != (AABBox^ v1, AABBox^ v2)
	{
		return !(v1 == v2);
	}

	/// <summary>
	/// Default constructor.
	/// Initializes MinEdge with (-1,-1,-1) and MaxEdge with (1,1,1).
	/// </summary>
	AABBox()
		: Lime::NativeValue<core::aabbox3df>(true)
	{
		m_NativeValue = new core::aabbox3df();
	}

	/// <summary>
	/// Copy constructor.
	/// </summary>
	/// <param name="copy">Other bouding box.</param>
	AABBox(AABBox^ copy)
		: Lime::NativeValue<core::aabbox3df>(true)
	{
		LIME_ASSERT(copy != nullptr);

		m_NativeValue = new core::aabbox3df();
		m_NativeValue->reset(*copy->m_NativeValue);
	}

	/// <summary>
	/// Constructor with min edge and max edge.
	/// </summary>
	/// <param name="minx">Min edge X coord.</param>
	/// <param name="miny">Min edge Y coord.</param>
	/// <param name="minz">Min edge Z coord.</param>
	/// <param name="maxx">Max edge X coord.</param>
	/// <param name="maxy">Max edge Y coord.</param>
	/// <param name="maxz">Max edge Z coord.</param>
	AABBox(float minx, float miny, float minz, float maxx, float maxy, float maxz)
		: Lime::NativeValue<core::aabbox3df>(true)
	{
		m_NativeValue = new core::aabbox3df(minx, miny, minz, maxx, maxy, maxz);
	}

	/// <summary>
	/// Constructor with only one point.
	/// </summary>
	/// <param name="x">X coord of the point.</param>
	/// <param name="y">Y coord of the point.</param>
	/// <param name="z">Z coord of the point.</param>
	AABBox(float x, float y, float z)
		: Lime::NativeValue<core::aabbox3df>(true)
	{
		m_NativeValue = new core::aabbox3df(x, y, z, x, y, z);
	}

	/// <summary>
	/// Constructor with min edge and max edge.
	/// </summary>
	/// <param name="min">Min edge point.</param>
	/// <param name="max">Max edge point.</param>
	AABBox(Vector3Df^ min, Vector3Df^ max)
		: Lime::NativeValue<core::aabbox3df>(true)
	{
		LIME_ASSERT(min != nullptr);
		LIME_ASSERT(max != nullptr);

		m_NativeValue = new core::aabbox3df(*min->m_NativeValue, *max->m_NativeValue);
	}

	/// <summary>
	/// Constructor with only one point.
	/// </summary>
	/// <param name="point">The point.</param>
	AABBox(Vector3Df^ point)
		: Lime::NativeValue<core::aabbox3df>(true)
	{
		LIME_ASSERT(point != nullptr);
		m_NativeValue = new core::aabbox3df(*point->m_NativeValue);
	}

	/// <summary>
	/// Sets new values for min edge and max edge.
	/// </summary>
	/// <param name="minx">Min edge X coord.</param>
	/// <param name="miny">Min edge Y coord.</param>
	/// <param name="minz">Min edge Z coord.</param>
	/// <param name="maxx">Max edge X coord.</param>
	/// <param name="maxy">Max edge Y coord.</param>
	/// <param name="maxz">Max edge Z coord.</param>
	void Set(float minx, float miny, float minz, float maxx, float maxy, float maxz)
	{
		m_NativeValue->MinEdge.set(minx, miny, minz);
		m_NativeValue->MaxEdge.set(maxx, maxy, maxz);
	}

	/// <summary>
	/// Sets new values for min edge and max edge.
	/// </summary>
	/// <param name="min">New value for min edge point.</param>
	/// <param name="max">New value for max edge point.</param>
	void Set(Vector3Df^ min, Vector3Df^ max)
	{
		LIME_ASSERT(min != nullptr);
		LIME_ASSERT(max != nullptr);

		m_NativeValue->MinEdge = *min->m_NativeValue;
		m_NativeValue->MaxEdge = *max->m_NativeValue;
	}

	/// <summary>
	/// Sets the bounding box to a one-point box.
	/// </summary>
	/// <param name="x">X coord of the point.</param>
	/// <param name="y">Y coord of the point.</param>
	/// <param name="z">Z coord of the point.</param>
	void Set(float x, float y, float z)
	{
		m_NativeValue->reset(x, y, z);
	}

	/// <summary>
	/// Sets the bounding box to a one-point box.
	/// </summary>
	/// <param name="newPoint">The point.</param>
	void Set(Vector3Df^ newPoint)
	{
		LIME_ASSERT(newPoint != nullptr);
		m_NativeValue->reset(*newPoint->m_NativeValue);
	}

	/// <summary>
	/// Sets the bounding box to new bounding box.
	/// </summary>
	/// <param name="newBox">New box to set this one to.</param>
	void Set(AABBox^ newBox)
	{
		LIME_ASSERT(newBox != nullptr);
		m_NativeValue->reset(*newBox->m_NativeValue);
	}

	/// <summary>
	/// Adds a point to the bounding box.
	/// The box grows bigger, if point was outside of the box.
	/// </summary>
	/// <param name="x">X coordinate of the point to add to this box.</param>
	/// <param name="y">Y coordinate of the point to add to this box.</param>
	/// <param name="z">Z coordinate of the point to add to this box.</param>
	void AddInternalPoint(float x, float y, float z)
	{
		m_NativeValue->addInternalPoint(x, y, z);
	}

	/// <summary>
	/// Adds a point to the bounding box.
	/// The box grows bigger, if point was outside of the box.
	/// </summary>
	/// <param name="p">Point to add into the box.</param>
	void AddInternalPoint(Vector3Df^ p)
	{
		LIME_ASSERT(p != nullptr);
		m_NativeValue->addInternalPoint(*p->m_NativeValue);
	}

	/// <summary>
	/// Adds another bounding box.
	/// The box grows bigger, if the new box was outside of the box.
	/// </summary>
	/// <param name="b">Other bounding box to add into this box.</param>
	void AddInternalBox(AABBox^ b)
	{
		LIME_ASSERT(b != nullptr);
		m_NativeValue->addInternalBox(*b->m_NativeValue);
	}

	/// <summary>
	/// Returns the intersection of this box with another, if possible.
	/// </summary>
	/// <param name="other">Other bounding box.</param>
	/// <returns>AABBox if there is an intersection and null if no intersection.</returns>
	AABBox^ Intersect(AABBox^ other)
	{
		LIME_ASSERT(other != nullptr);

		if (m_NativeValue->intersectsWithBox(*other->m_NativeValue))
		{
			return gcnew AABBox(m_NativeValue->intersect(*other->m_NativeValue));
		}

		return nullptr;
	}

	/// <summary>
	/// Determines if the axis-aligned box intersects with another axis-aligned box.
	/// </summary>
	/// <param name="other">Other box to check a intersection with.</param>
	/// <returns>True if there is an intersection with the other box, otherwise false.</returns>
	bool IntersectsWithBox(AABBox^ other)
	{
		LIME_ASSERT(other != nullptr);
		return m_NativeValue->intersectsWithBox(*other->m_NativeValue);
	}

	/// <summary>
	/// Tests if the box intersects with a line.
	/// </summary>
	/// <param name="line">Line to test intersection with.</param>
	/// <returns>True if there is an intersection, else false.</returns>
	bool IntersectsWithLine(Line3Df^ line)
	{
		LIME_ASSERT(line != nullptr);
		return m_NativeValue->intersectsWithLine(*line->m_NativeValue);
	}

	/// <summary>
	/// Determines if a point is within this box.
	/// Border is included (IS part of the box)!
	/// </summary>
	/// <param name="p">Point to check.</param>
	/// <returns>True if the point is within the box and false if not.</returns>
	bool IsInside(Vector3Df^ p)
	{
		LIME_ASSERT(p != nullptr);
		return m_NativeValue->isPointInside(*p->m_NativeValue);
	}

	/// <summary>
	/// Determines if a point is within this box and not its borders.
	/// Border is excluded (NOT part of the box)!
	/// </summary>
	/// <param name="p">Point to check.</param>
	/// <returns>True if the point is within the box and false if not.</returns>
	bool IsInsideFully(Vector3Df^ p)
	{
		LIME_ASSERT(p != nullptr);
		return m_NativeValue->isPointTotalInside(*p->m_NativeValue);
	}

	/// <summary>
	/// Check if this box is completely inside given bounding box.
	/// Border is excluded (NOT part of the box)!
	/// </summary>
	/// <param name="b">Other box to check against.</param>
	/// <returns>True if this box is completely inside the other box, otherwise false.</returns>
	bool IsInside(AABBox^ b)
	{
		LIME_ASSERT(b != nullptr);
		return m_NativeValue->isFullInside(*b->m_NativeValue);
	}

	/// <summary>
	/// Repairs the box.
	/// Necessary if for example MinEdge and MaxEdge are swapped.
	/// </summary>
	void Repair()
	{
		m_NativeValue->repair();
	}

	/// <summary>
	/// Surface area of the box in squared units.
	/// </summary>
	property float Area
	{
		float get() { return m_NativeValue->getArea(); }
	}

	/// <summary>
	/// Center of the bounding box.
	/// </summary>
	property Vector3Df^ Center
	{
		Vector3Df^ get() { return gcnew Vector3Df(m_NativeValue->getCenter()); }
	}

	/// <summary>
	/// All 8 edges of the bounding box.
	/// </summary>
	property array<Vector3Df^>^ Edges
	{
		array<Vector3Df^>^ get()
		{
			core::vector3df v[8];
			m_NativeValue->getEdges(v);

			array<Vector3Df^>^ a = gcnew array<Vector3Df^>(8);
			for (int i = 0; i < 8; i++)
				a[i] = gcnew Vector3Df(v[i]);
			
			return a;
		}
	}

	/// <summary>
	/// Extent of the box (maximal distance of two points in the box).
	/// </summary>
	property Vector3Df^ Extent
	{
		Vector3Df^ get() { return gcnew Vector3Df(m_NativeValue->getExtent()); }
	}

	/// <summary>
	/// Check if the box is empty.
	/// This means that there is no space between the min and max edge.
	/// </summary>
	property bool IsEmpty
	{
		bool get() { return m_NativeValue->isEmpty(); }
	}

	/// <summary>
	/// Check if MaxEdge &gt; MinEdge.
	/// </summary>
	property bool IsValid
	{
		bool get() { return m_NativeValue->isValid(); }
	}

	/// <summary>
	/// The far edge.
	/// </summary>
	property Vector3Df^ MaxEdge
	{
		Vector3Df^ get()
		{
			return gcnew Vector3Df(m_NativeValue->MaxEdge);
		}
		void set(Vector3Df^ value)
		{
			LIME_ASSERT(value != nullptr);
			m_NativeValue->MaxEdge = *value->m_NativeValue;
		}
	}

	/// <summary>
	/// The near edge.
	/// </summary>
	property Vector3Df^ MinEdge
	{
		Vector3Df^ get()
		{
			return gcnew Vector3Df(m_NativeValue->MinEdge);
		}
		void set(Vector3Df^ value)
		{
			LIME_ASSERT(value != nullptr);
			m_NativeValue->MinEdge = *value->m_NativeValue;
		}
	}

	/// <summary>
	/// Radius of the bounding sphere.
	/// </summary>
	property float Radius
	{
		float get() { return m_NativeValue->getRadius(); }
	}

	/// <summary>
	/// Volume enclosed by the box in cubed units.
	/// </summary>
	property float Volume
	{
		float get() { return m_NativeValue->getVolume(); }
	}

	virtual String^ ToString() override
	{
		return String::Format("MinEdge={0}; MaxEdge={1}", MinEdge, MaxEdge);
	}

internal:

	AABBox(const core::aabbox3df& other)
		: Lime::NativeValue<core::aabbox3df>(true)
	{
		m_NativeValue = new core::aabbox3df(other);
	}
};

} // end namespace Core
} // end namespace IrrlichtLime
