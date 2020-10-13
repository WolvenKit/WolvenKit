#pragma once

#include "stdafx.h"

using namespace irr;
using namespace System;
using namespace IrrlichtLime::Core;

namespace IrrlichtLime {
namespace Video {

/// <summary>
/// Standard vertex used by the Irrlicht Engine.
/// </summary>
public ref class Vertex3D : Lime::NativeValue<video::S3DVertex>
{

#define _REFCLASS_ Vertex3D
#define _WRAPCLASS_ video::S3DVertex
#include "Vertex_template.h"
#undef _WRAPCLASS_
#undef _REFCLASS_

public:

	/// <summary>
	/// Constructs vertex from position, normal, color and texture coords.
	/// </summary>
	Vertex3D(float x, float y, float z, float nx, float ny, float nz, Video::Color^ c, float tu, float tv)
		: Lime::NativeValue<video::S3DVertex>(true)
	{
		LIME_ASSERT(c != nullptr);

		m_NativeValue = new video::S3DVertex(
			x, y, z,
			nx, ny, nz,
			*c->m_NativeValue,
			tu, tv);
	}

	/// <summary>
	/// Constructs vertex from position, normal and color.
	/// Texture coords set to (0,0).
	/// </summary>
	Vertex3D(float x, float y, float z, float nx, float ny, float nz, Video::Color^ c)
		: Lime::NativeValue<video::S3DVertex>(true)
	{
		LIME_ASSERT(c != nullptr);

		m_NativeValue = new video::S3DVertex(
			x, y, z,
			nx, ny, nz,
			*c->m_NativeValue,
			0, 0);
	}

	/// <summary>
	/// Constructs vertex from position and normal.
	/// Color is not initialized (can contain any value).
	/// Texture coords set to (0,0).
	/// </summary>
	Vertex3D(float x, float y, float z, float nx, float ny, float nz)
		: Lime::NativeValue<video::S3DVertex>(true)
	{
		m_NativeValue = new video::S3DVertex(
			x, y, z,
			nx, ny, nz,
			video::SColor(),
			0, 0);
	}

	/// <summary>
	/// Constructs vertex from position.
	/// Normal is set to (0,0,0).
	/// Color is not initialized (can contain any value).
	/// Texture coords set to (0,0).
	/// </summary>
	Vertex3D(float x, float y, float z)
		: Lime::NativeValue<video::S3DVertex>(true)
	{
		m_NativeValue = new video::S3DVertex(
			x, y, z,
			0, 0, 0,
			video::SColor(),
			0, 0);
	}

	/// <summary>
	/// Constructs vertex from position, normal, color and texture coords.
	/// </summary>
	Vertex3D(Vector3Df^ pos, Vector3Df^ normal, Video::Color^ color, Vector2Df^ tcoords)
		: Lime::NativeValue<video::S3DVertex>(true)
	{
		LIME_ASSERT(pos != nullptr);
		LIME_ASSERT(normal != nullptr);
		LIME_ASSERT(color != nullptr);
		LIME_ASSERT(tcoords != nullptr);

		m_NativeValue = new video::S3DVertex(
			*pos->m_NativeValue,
			*normal->m_NativeValue,
			*color->m_NativeValue,
			*tcoords->m_NativeValue);
	}

	/// <summary>
	/// Constructs vertex from position, normal and color.
	/// Texture coords set to (0,0).
	/// </summary>
	Vertex3D(Vector3Df^ pos, Vector3Df^ normal, Video::Color^ color)
		: Lime::NativeValue<video::S3DVertex>(true)
	{
		LIME_ASSERT(pos != nullptr);
		LIME_ASSERT(normal != nullptr);
		LIME_ASSERT(color != nullptr);

		m_NativeValue = new video::S3DVertex(
			*pos->m_NativeValue,
			*normal->m_NativeValue,
			*color->m_NativeValue,
			core::vector2df());
	}

	/// <summary>
	/// Constructs vertex from position and normal.
	/// Color is not initialized (can contain any value).
	/// Texture coords set to (0,0).
	/// </summary>
	Vertex3D(Vector3Df^ pos, Vector3Df^ normal)
		: Lime::NativeValue<video::S3DVertex>(true)
	{
		LIME_ASSERT(pos != nullptr);
		LIME_ASSERT(normal != nullptr);

		m_NativeValue = new video::S3DVertex(
			*pos->m_NativeValue,
			*normal->m_NativeValue,
			video::SColor(),
			core::vector2df());
	}

	/// <summary>
	/// Constructs vertex from position.
	/// Normal is set to (0,0,0).
	/// Color is not initialized (can contain any value).
	/// Texture coords set to (0,0).
	/// </summary>
	Vertex3D(Vector3Df^ pos)
		: Lime::NativeValue<video::S3DVertex>(true)
	{
		LIME_ASSERT(pos != nullptr);

		m_NativeValue = new video::S3DVertex(
			*pos->m_NativeValue,
			core::vector3df(),
			video::SColor(),
			core::vector2df());
	}
};

/// <summary>
/// Vertex with two texture coordinates.
/// Usually used for geometry with lightmaps or other special materials.
/// </summary>
public ref class Vertex3DTTCoords : Lime::NativeValue<video::S3DVertex2TCoords>
{

#define _REFCLASS_ Vertex3DTTCoords
#define _WRAPCLASS_ video::S3DVertex2TCoords
#include "Vertex_template.h"
#undef _WRAPCLASS_
#undef _REFCLASS_

public:

	/// <summary>
	/// Constructs vertex from position, color and two texture coords.
	/// Normal is set to (0,0,0).
	/// </summary>
	Vertex3DTTCoords(float x, float y, float z, Video::Color^ c, float tu, float tv, float tu2, float tv2)
		: Lime::NativeValue<video::S3DVertex2TCoords>(true)
	{
		LIME_ASSERT(c != nullptr);

		m_NativeValue = new video::S3DVertex2TCoords(
			x, y, z,
			*c->m_NativeValue,
			tu, tv,
			tu2, tv2);
	}

	/// <summary>
	/// Constructs vertex from position, normal, color and two texture coords.
	/// </summary>
	Vertex3DTTCoords(float x, float y, float z, float nx, float ny, float nz, Video::Color^ c, float tu, float tv, float tu2, float tv2)
		: Lime::NativeValue<video::S3DVertex2TCoords>(true)
	{
		LIME_ASSERT(c != nullptr);

		m_NativeValue = new video::S3DVertex2TCoords(
			x, y, z,
			nx, ny, nz,
			*c->m_NativeValue,
			tu, tv,
			tu2, tv2);
	}

	/// <summary>
	/// Constructs vertex from position, normal, color and one texture coords.
	/// TCoords and TCoords2 are getting same value.
	/// </summary>
	Vertex3DTTCoords(float x, float y, float z, float nx, float ny, float nz, Video::Color^ c, float tu, float tv)
		: Lime::NativeValue<video::S3DVertex2TCoords>(true)
	{
		LIME_ASSERT(c != nullptr);

		m_NativeValue = new video::S3DVertex2TCoords(
			x, y, z,
			nx, ny, nz,
			*c->m_NativeValue,
			tu, tv);
	}

	/// <summary>
	/// Constructs vertex from position, color and two texture coords.
	/// Normal is set to (0,0,0).
	/// </summary>
	Vertex3DTTCoords(Vector3Df^ pos, Video::Color^ color, Vector2Df^ tcoords, Vector2Df^ tcoords2)
		: Lime::NativeValue<video::S3DVertex2TCoords>(true)
	{
		LIME_ASSERT(pos != nullptr);
		LIME_ASSERT(color != nullptr);
		LIME_ASSERT(tcoords != nullptr);
		LIME_ASSERT(tcoords2 != nullptr);

		m_NativeValue = new video::S3DVertex2TCoords(
			*pos->m_NativeValue,
			*color->m_NativeValue,
			*tcoords->m_NativeValue,
			*tcoords2->m_NativeValue);
	}

	/// <summary>
	/// Constructs vertex from position, normal, color and two texture coords.
	/// </summary>
	Vertex3DTTCoords(Vector3Df^ pos, Vector3Df^ normal, Video::Color^ color, Vector2Df^ tcoords, Vector2Df^ tcoords2)
		: Lime::NativeValue<video::S3DVertex2TCoords>(true)
	{
		LIME_ASSERT(pos != nullptr);
		LIME_ASSERT(normal != nullptr);
		LIME_ASSERT(color != nullptr);
		LIME_ASSERT(tcoords != nullptr);
		LIME_ASSERT(tcoords2 != nullptr);

		m_NativeValue = new video::S3DVertex2TCoords(
			*pos->m_NativeValue,
			*normal->m_NativeValue,
			*color->m_NativeValue,
			*tcoords->m_NativeValue,
			*tcoords2->m_NativeValue);
	}

	/// <summary>
	/// Constructs vertex from position, normal, color and one texture coords.
	/// TCoords and TCoords2 are getting same value.
	/// </summary>
	Vertex3DTTCoords(Vector3Df^ pos, Vector3Df^ normal, Video::Color^ color, Vector2Df^ tcoords)
		: Lime::NativeValue<video::S3DVertex2TCoords>(true)
	{
		LIME_ASSERT(pos != nullptr);
		LIME_ASSERT(normal != nullptr);
		LIME_ASSERT(color != nullptr);
		LIME_ASSERT(tcoords != nullptr);

		m_NativeValue = new video::S3DVertex2TCoords(
			*pos->m_NativeValue,
			*normal->m_NativeValue,
			*color->m_NativeValue,
			*tcoords->m_NativeValue);
	}

	/// <summary>
	/// Constructs vertex from Vertex3D.
	/// TCoords2 is not initialized (can contain any value).
	/// </summary>
	Vertex3DTTCoords(Vertex3D^ o)
		: Lime::NativeValue<video::S3DVertex2TCoords>(true)
	{
		LIME_ASSERT(o != nullptr);
		m_NativeValue = new video::S3DVertex2TCoords(*o->m_NativeValue);
	}

	/// <summary>
	/// Second set of texture coordinates.
	/// </summary>
	property Vector2Df^ TCoords2
	{
		Vector2Df^ get()
		{
			return gcnew Vector2Df(m_NativeValue->TCoords2);
		}
		void set(Vector2Df^ value)
		{
			LIME_ASSERT(value != nullptr);
			m_NativeValue->TCoords2 = *value->m_NativeValue;
		}
	}
};

/// <summary>
/// Vertex with a tangent and binormal vector.
/// Usually used for tangent space normal mapping.
/// Usually tangent and binormal get send to shaders as texture coordinate sets 1 and 2.
/// </summary>
public ref class Vertex3DTangents : Lime::NativeValue<video::S3DVertexTangents>
{

#define _REFCLASS_ Vertex3DTangents
#define _WRAPCLASS_ video::S3DVertexTangents
#include "Vertex_template.h"
#undef _WRAPCLASS_
#undef _REFCLASS_

public:

	/// <summary>
	/// Constructs vertex from position, normal, color, texture coords, tangent and binormal.
	/// </summary>
	Vertex3DTangents(float x, float y, float z, float nx, float ny, float nz, Video::Color^ c, float tu, float tv, float tanx, float tany, float tanz, float binx, float biny, float binz)
		: Lime::NativeValue<video::S3DVertexTangents>(true)
	{
		LIME_ASSERT(c != nullptr);

		m_NativeValue = new video::S3DVertexTangents(
			x, y, z,
			nx, ny, nz,
			*c->m_NativeValue,
			tu, tv,
			tanx, tany, tanz,
			binx, biny, binz);
	}

	/// <summary>
	/// Constructs vertex from position, normal, color, texture coords and tangent.
	/// Binormal is set to (0,0,0).
	/// </summary>
	Vertex3DTangents(float x, float y, float z, float nx, float ny, float nz, Video::Color^ c, float tu, float tv, float tanx, float tany, float tanz)
		: Lime::NativeValue<video::S3DVertexTangents>(true)
	{
		LIME_ASSERT(c != nullptr);

		m_NativeValue = new video::S3DVertexTangents(
			x, y, z,
			nx, ny, nz,
			*c->m_NativeValue,
			tu, tv,
			tanx, tany, tanz);
	}

	/// <summary>
	/// Constructs vertex from position, normal, color and texture coords.
	/// Tangent and Binormal are both set to (0,0,0).
	/// </summary>
	Vertex3DTangents(float x, float y, float z, float nx, float ny, float nz, Video::Color^ c, float tu, float tv)
		: Lime::NativeValue<video::S3DVertexTangents>(true)
	{
		LIME_ASSERT(c != nullptr);

		m_NativeValue = new video::S3DVertexTangents(
			x, y, z,
			nx, ny, nz,
			*c->m_NativeValue,
			tu, tv);
	}

	/// <summary>
	/// Constructs vertex from position, normal and color.
	/// TCoords is set to (0,0).
	/// Tangent and Binormal are both set to (0,0,0).
	/// </summary>
	Vertex3DTangents(float x, float y, float z, float nx, float ny, float nz, Video::Color^ c)
		: Lime::NativeValue<video::S3DVertexTangents>(true)
	{
		LIME_ASSERT(c != nullptr);

		m_NativeValue = new video::S3DVertexTangents(
			x, y, z,
			nx, ny, nz,
			*c->m_NativeValue);
	}

	/// <summary>
	/// Constructs vertex from position and normal.
	/// Color is set to solid white (0xffffffff).
	/// TCoords is set to (0,0).
	/// Tangent and Binormal are both set to (0,0,0).
	/// </summary>
	Vertex3DTangents(float x, float y, float z, float nx, float ny, float nz)
		: Lime::NativeValue<video::S3DVertexTangents>(true)
	{
		m_NativeValue = new video::S3DVertexTangents(
			x, y, z,
			nx, ny, nz);
	}

	/// <summary>
	/// Constructs vertex from position.
	/// Color is set to solid white (0xffffffff).
	/// TCoords is set to (0,0).
	/// Normal, Tangent and Binormal are all set to (0,0,0).
	/// </summary>
	Vertex3DTangents(float x, float y, float z)
		: Lime::NativeValue<video::S3DVertexTangents>(true)
	{
		m_NativeValue = new video::S3DVertexTangents(
			x, y, z);
	}

	/// <summary>
	/// Constructs vertex from position, normal, color, texture coords, tangent and binormal.
	/// </summary>
	Vertex3DTangents(Vector3Df^ pos, Vector3Df^ normal, Video::Color^ color, Vector2Df^ tcoords, Vector3Df^ tangent, Vector3Df^ binormal)
		: Lime::NativeValue<video::S3DVertexTangents>(true)
	{
		LIME_ASSERT(pos != nullptr);
		LIME_ASSERT(normal != nullptr);
		LIME_ASSERT(color != nullptr);
		LIME_ASSERT(tcoords != nullptr);
		LIME_ASSERT(tangent != nullptr);
		LIME_ASSERT(binormal != nullptr);

		m_NativeValue = new video::S3DVertexTangents(
			*pos->m_NativeValue,
			*normal->m_NativeValue,
			*color->m_NativeValue,
			*tcoords->m_NativeValue,
			*tangent->m_NativeValue,
			*binormal->m_NativeValue);
	}

	/// <summary>
	/// Constructs vertex from position, normal, color, texture coords and tangent.
	/// Binormal is set to (0,0,0).
	/// </summary>
	Vertex3DTangents(Vector3Df^ pos, Vector3Df^ normal, Video::Color^ color, Vector2Df^ tcoords, Vector3Df^ tangent)
		: Lime::NativeValue<video::S3DVertexTangents>(true)
	{
		LIME_ASSERT(pos != nullptr);
		LIME_ASSERT(normal != nullptr);
		LIME_ASSERT(color != nullptr);
		LIME_ASSERT(tcoords != nullptr);
		LIME_ASSERT(tangent != nullptr);

		m_NativeValue = new video::S3DVertexTangents(
			*pos->m_NativeValue,
			*normal->m_NativeValue,
			*color->m_NativeValue,
			*tcoords->m_NativeValue,
			*tangent->m_NativeValue);
	}

	/// <summary>
	/// Constructs vertex from position, normal, color and texture coords.
	/// Tangent and Binormal are both set to (0,0,0).
	/// </summary>
	Vertex3DTangents(Vector3Df^ pos, Vector3Df^ normal, Video::Color^ color, Vector2Df^ tcoords)
		: Lime::NativeValue<video::S3DVertexTangents>(true)
	{
		LIME_ASSERT(pos != nullptr);
		LIME_ASSERT(normal != nullptr);
		LIME_ASSERT(color != nullptr);
		LIME_ASSERT(tcoords != nullptr);

		m_NativeValue = new video::S3DVertexTangents(
			*pos->m_NativeValue,
			*normal->m_NativeValue,
			*color->m_NativeValue,
			*tcoords->m_NativeValue);
	}

	/// <summary>
	/// Tangent vector along the x-axis of the texture.
	/// </summary>
	property Vector3Df^ Tangent
	{
		Vector3Df^ get()
		{
			return gcnew Vector3Df(m_NativeValue->Tangent);
		}
		void set(Vector3Df^ value)
		{
			LIME_ASSERT(value != nullptr);
			m_NativeValue->Tangent = *value->m_NativeValue;
		}
	}

	/// <summary>
	/// Binormal vector (tangent x normal).
	/// </summary>
	property Vector3Df^ Binormal
	{
		Vector3Df^ get()
		{
			return gcnew Vector3Df(m_NativeValue->Binormal);
		}
		void set(Vector3Df^ value)
		{
			LIME_ASSERT(value != nullptr);
			m_NativeValue->Binormal = *value->m_NativeValue;
		}
	}
};

} // end namespace Video
} // end namespace IrrlichtLime
