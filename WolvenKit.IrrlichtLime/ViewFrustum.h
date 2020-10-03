#pragma once

#include "stdafx.h"

using namespace irr;
using namespace System;

namespace IrrlichtLime {
namespace Scene {

public ref class ViewFrustum : Lime::NativeValue<scene::SViewFrustum>
{
public:

	enum class Plane
	{
		Far = scene::SViewFrustum::VF_FAR_PLANE,
		Near = scene::SViewFrustum::VF_NEAR_PLANE,
		Left = scene::SViewFrustum::VF_LEFT_PLANE,
		Right = scene::SViewFrustum::VF_RIGHT_PLANE,
		Bottom = scene::SViewFrustum::VF_BOTTOM_PLANE,
		Top = scene::SViewFrustum::VF_TOP_PLANE
	};

	ViewFrustum()
		: Lime::NativeValue<scene::SViewFrustum>(true)
	{
		m_NativeValue = new scene::SViewFrustum();
	}

	ViewFrustum(ViewFrustum^ copy)
		: Lime::NativeValue<scene::SViewFrustum>(true)
	{
		LIME_ASSERT(copy != nullptr);
		m_NativeValue = new scene::SViewFrustum(*copy->m_NativeValue);
	}

	ViewFrustum(Matrix^ mat, bool zClipFromZero)
		: Lime::NativeValue<scene::SViewFrustum>(true)
	{
		LIME_ASSERT(mat != nullptr);
		m_NativeValue = new scene::SViewFrustum(*mat->m_NativeValue, zClipFromZero);
	}

	void Set(Matrix^ mat, bool zClipFromZero)
	{
		LIME_ASSERT(mat != nullptr);
		m_NativeValue->setFrom(*mat->m_NativeValue, zClipFromZero);
	}

	bool ClipLine(Line3Df^% line)
	{
		LIME_ASSERT(line != nullptr);
		return m_NativeValue->clipLine(*line->m_NativeValue);
	}

	Plane3Df^ GetPlane(Plane plane)
	{
		return gcnew Plane3Df(m_NativeValue->planes[(scene::SViewFrustum::VFPLANES)plane]);
	}

	Matrix^ GetTransform(Video::TransformationState state)
	{
		return gcnew Matrix(m_NativeValue->getTransform((video::E_TRANSFORMATION_STATE)state));
	}

	void RecalculateBoundingBox()
	{
		m_NativeValue->recalculateBoundingBox();
	}

	void SetPlane(Plane plane, Plane3Df^ value)
	{
		LIME_ASSERT(value != nullptr);
		m_NativeValue->planes[(scene::SViewFrustum::VFPLANES)plane] = *value->m_NativeValue;
	}

	void Transform(Matrix^ mat)
	{
		LIME_ASSERT(mat != nullptr);
		m_NativeValue->transform(*mat->m_NativeValue);
	}

	property AABBox^ BoundingBox
	{
		AABBox^ get()
		{
			return gcnew AABBox(m_NativeValue->boundingBox);
		}
		void set(AABBox^ value)
		{
			LIME_ASSERT(value != nullptr);
			m_NativeValue->boundingBox = *value->m_NativeValue;
		}
	}

	property Vector3Df^ CameraPosition
	{
		Vector3Df^ get()
		{
			return gcnew Vector3Df(m_NativeValue->cameraPosition);
		}
		void set(Vector3Df^ value)
		{
			LIME_ASSERT(value != nullptr);
			m_NativeValue->cameraPosition = *value->m_NativeValue;
		}
	}

	property Vector3Df^ FarLeftUp
	{
		Vector3Df^ get() { return gcnew Vector3Df(m_NativeValue->getFarLeftUp()); }
	}

	property Vector3Df^ FarLeftDown
	{
		Vector3Df^ get() { return gcnew Vector3Df(m_NativeValue->getFarLeftDown()); }
	}

	property Vector3Df^ FarRightUp
	{
		Vector3Df^ get() { return gcnew Vector3Df(m_NativeValue->getFarRightUp()); }
	}

	property Vector3Df^ FarRightDown
	{
		Vector3Df^ get() { return gcnew Vector3Df(m_NativeValue->getFarRightDown()); }
	}

	property Vector3Df^ NearLeftUp
	{
		Vector3Df^ get() { return gcnew Vector3Df(m_NativeValue->getNearLeftUp()); }
	}

	property Vector3Df^ NearLeftDown
	{
		Vector3Df^ get() { return gcnew Vector3Df(m_NativeValue->getNearLeftDown()); }
	}

	property Vector3Df^ NearRightUp
	{
		Vector3Df^ get() { return gcnew Vector3Df(m_NativeValue->getNearRightUp()); }
	}

	property Vector3Df^ NearRightDown
	{
		Vector3Df^ get() { return gcnew Vector3Df(m_NativeValue->getNearRightDown()); }
	}

internal:

	ViewFrustum(const scene::SViewFrustum& value)
		: Lime::NativeValue<scene::SViewFrustum>(true)
	{
		m_NativeValue = new scene::SViewFrustum(value);
	}

	ViewFrustum(scene::SViewFrustum* ref)
		: Lime::NativeValue<scene::SViewFrustum>(false)
	{
		LIME_ASSERT(ref != nullptr);
		m_NativeValue = ref;
	}
};

} // end namespace Scene
} // end namespace IrrlichtLime