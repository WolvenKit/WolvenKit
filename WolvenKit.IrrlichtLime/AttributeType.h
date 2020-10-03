#pragma once

#include "stdafx.h"

using namespace irr;
using namespace io;
using namespace System;

namespace IrrlichtLime {
namespace IO {

	/// <summary>
	/// Types of attributes available for <c>Attributes</c>.
	/// </summary>
	public enum class AttributeType
	{
		/// <summary>
		/// Integer attribute.
		/// </summary>
		Int = EAT_INT,

		/// <summary>
		/// Float attribute.
		/// </summary>
		Float = EAT_FLOAT,

		/// <summary>
		/// String attribute.
		/// </summary>
		String = EAT_STRING,

		/// <summary>
		/// Boolean attribute.
		/// </summary>
		Bool = EAT_BOOL,

		/// <summary>
		/// Enumeration attribute. Read-only. Please use <see cref="Int"/> in case you need to write.
		/// </summary>
		Enum = EAT_ENUM, // read-only type; i don't have clear solution for implementation of adding and modifying values; read more in Attributes::AddValue() in proper switch-case region

		/// <summary>
		/// Color attribute.
		/// </summary>
		Color = EAT_COLOR,

		/// <summary>
		/// Floating point color attribute.
		/// </summary>
		Colorf = EAT_COLORF,

		/// <summary>
		/// 3d vector attribute.
		/// </summary>
		Vector3Df = EAT_VECTOR3D,

		/// <summary>
		/// Integer 2d vector attribute.
		/// </summary>
		Vector2Di = EAT_POSITION2D,

		/// <summary>
		/// Float point 2d vector attribute.
		/// </summary>
		Vector2Df = EAT_VECTOR2D,

		/// <summary>
		/// Rectangle attribute.
		/// </summary>
		Recti = EAT_RECT,

		/// <summary>
		/// Matrix attribute.
		/// </summary>
		Matrix = EAT_MATRIX,

		/// <summary>
		/// Quaternion attribute.
		/// </summary>
		Quaternion = EAT_QUATERNION,

		/// <summary>
		/// 3d bounding box attribute.
		/// </summary>
		AABBox = EAT_BBOX,

		/// <summary>
		/// Plane attribute.
		/// </summary>
		Plane3Df = EAT_PLANE,

		/// <summary>
		/// Triangle attribute.
		/// </summary>
		Triangle3Df = EAT_TRIANGLE3D,

		// EAT_LINE2D // we don't support it, because we do not have Line2Df type

		/// <summary>
		/// Line attribute.
		/// </summary>
		Line3Df = EAT_LINE3D,

		/// <summary>
		/// Array of strings attribute.
		/// </summary>
		StringArray = EAT_STRINGWARRAY,

		// EAT_FLOATARRAY // i have no idea how to add/read/write this type using io::IAttributes :(
		// EAT_INTARRAY // (either)

		/// <summary>
		/// Byte array attribute.
		/// </summary>
		ByteArray = EAT_BINARY,

		/// <summary>
		/// Texture reference attribute.
		/// </summary>
		Texture = EAT_TEXTURE,

		// EAT_USER_POINTER // we don't support it
		// EAT_DIMENSION2D // we don't have Dimension2Du type; for holding Dimension2Di-type-like value user can use Vector2Di

		/// <summary>
		/// Unknown attribute.
		/// </summary>
		Unknown = EAT_UNKNOWN
	};

} // end namespace IO
} // end namespace IrrlichtLime
