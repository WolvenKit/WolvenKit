#pragma once

#include "stdafx.h"

using namespace irr;
using namespace System;

namespace IrrlichtLime {
namespace Core {

/// <summary>
/// 4x4 matrix. Mostly used as transformation matrix for 3d calculations.
/// The matrix is a D3D style matrix, row major with translations in the 4th row.
/// </summary>
public ref class Matrix : Lime::NativeValue<core::matrix4>
{
public:

	/// <summary>
	/// Identity matrix.
	/// </summary>
	static property Matrix^ Identity { Matrix^ get() { return gcnew Matrix(core::matrix4(core::matrix4::EM4CONST_IDENTITY)); } }

	/// <summary>
	/// Equality operator.
	/// </summary>
	static bool operator == (Matrix^ v1, Matrix^ v2)
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
	static bool operator != (Matrix^ v1, Matrix^ v2)
	{
		return !(v1 == v2);
	}

	/// <summary>
	/// Add two matrices.
	/// </summary>
	static Matrix^ operator + (Matrix^ v1, Matrix^ v2)
	{
		LIME_ASSERT(v1 != nullptr);
		LIME_ASSERT(v2 != nullptr);

		return gcnew Matrix((*v1->m_NativeValue) + (*v2->m_NativeValue));
	}

	/// <summary>
	/// Subtract matrices.
	/// </summary>
	static Matrix^ operator - (Matrix^ v1, Matrix^ v2)
	{
		LIME_ASSERT(v1 != nullptr);
		LIME_ASSERT(v2 != nullptr);

		return gcnew Matrix((*v1->m_NativeValue) - (*v2->m_NativeValue));
	}

	/// <summary>
	/// Multiply by scalar.
	/// </summary>
	static Matrix^ operator * (Matrix^ v1, float v2)
	{
		LIME_ASSERT(v1 != nullptr);
		return gcnew Matrix((*v1->m_NativeValue) * v2);
	}

	/// <summary>
	/// Multiply by another matrix.
	/// Calculate other*this.
	/// </summary>
	static Matrix^ operator * (Matrix^ v1, Matrix^ v2)
	{
		LIME_ASSERT(v1 != nullptr);
		LIME_ASSERT(v2 != nullptr);

		return gcnew Matrix((*v1->m_NativeValue) * (*v2->m_NativeValue));
	}

	/// <summary>
	/// Default constructor.
	/// Initializes identity matrix.
	/// </summary>
	Matrix()
		: Lime::NativeValue<core::matrix4>(true)
	{
		m_NativeValue = new core::matrix4();
	}

	/// <summary>
	/// Copy constructor.
	/// </summary>
	/// <param name="copy">Other matrix.</param>
	Matrix(Matrix^ copy)
		: Lime::NativeValue<core::matrix4>(true)
	{
		LIME_ASSERT(copy != nullptr);
		m_NativeValue = new core::matrix4(*copy->m_NativeValue);
	}

	/// <summary>
	/// Constructor with vectors.
	/// </summary>
	/// <param name="translation">The translation vector.</param>
	/// <param name="rotation">The rotation vector. Default is no rotation, e.g. (0,0,0).</param>
	/// <param name="scale">The scale vector. Default is no scale, e.g. (1,1,1).</param>
	Matrix(Vector3Df^ translation, Vector3Df^ rotation, Vector3Df^ scale)
		: Lime::NativeValue<core::matrix4>(true)
	{
		LIME_ASSERT(translation != nullptr);
		LIME_ASSERT(rotation != nullptr);
		LIME_ASSERT(scale != nullptr);

		m_NativeValue = new core::matrix4();
		m_NativeValue->setTranslation(*translation->m_NativeValue);
		m_NativeValue->setRotationDegrees(*rotation->m_NativeValue);
		m_NativeValue->setScale(*scale->m_NativeValue);
	}

	/// <summary>
	/// Constructor with vectors.
	/// </summary>
	/// <param name="translation">The translation vector.</param>
	/// <param name="rotation">The rotation vector. Default is no rotation, e.g. (0,0,0).</param>
	Matrix(Vector3Df^ translation, Vector3Df^ rotation)
		: Lime::NativeValue<core::matrix4>(true)
	{
		LIME_ASSERT(translation != nullptr);
		LIME_ASSERT(rotation != nullptr);

		m_NativeValue = new core::matrix4();
		m_NativeValue->setTranslation(*translation->m_NativeValue);
		m_NativeValue->setRotationDegrees(*rotation->m_NativeValue);
	}

	/// <summary>
	/// Constructor with vectors.
	/// </summary>
	/// <param name="translation">The translation vector.</param>
	Matrix(Vector3Df^ translation)
		: Lime::NativeValue<core::matrix4>(true)
	{
		LIME_ASSERT(translation != nullptr);

		m_NativeValue = new core::matrix4();
		m_NativeValue->setTranslation(*translation->m_NativeValue);
	}

	/// <summary>
	/// Builds a matrix which rotates a source vector to a look vector over an arbitrary axis.
	/// </summary>
	/// <param name="camPos">Viewer position in world coord.</param>
	/// <param name="center">Object position in world-coord, rotation pivot.</param>
	/// <param name="translation">Object final translation from center.</param>
	/// <param name="axis">Axis to rotate about.</param>
	/// <param name="from">Source vector to rotate from.</param>
	void BuildAxisAlignedBillboard(Vector3Df^ camPos, Vector3Df^ center, Vector3Df^ translation, Vector3Df^ axis, Vector3Df^ from)
	{
		LIME_ASSERT(camPos != nullptr);
		LIME_ASSERT(center != nullptr);
		LIME_ASSERT(translation != nullptr);
		LIME_ASSERT(axis != nullptr);
		LIME_ASSERT(from != nullptr);

		m_NativeValue->buildAxisAlignedBillboard(
			*camPos->m_NativeValue,
			*center->m_NativeValue,
			*translation->m_NativeValue,
			*axis->m_NativeValue,
			*from->m_NativeValue);
	}

	/// <summary>
	/// Builds a left-handed look-at matrix.
	/// </summary>
	Matrix^ BuildCameraLookAtMatrixLH(Vector3Df^ position, Vector3Df^ target, Vector3Df^ upVector)
	{
		LIME_ASSERT(position != nullptr);
		LIME_ASSERT(target != nullptr);
		LIME_ASSERT(upVector != nullptr);

		return gcnew Matrix(m_NativeValue->buildCameraLookAtMatrixLH(
			*position->m_NativeValue,
			*target->m_NativeValue,
			*upVector->m_NativeValue));
	}

	/// <summary>
	/// Builds a right-handed look-at matrix.
	/// </summary>
	Matrix^ BuildCameraLookAtMatrixRH(Vector3Df^ position, Vector3Df^ target, Vector3Df^ upVector)
	{
		LIME_ASSERT(position != nullptr);
		LIME_ASSERT(target != nullptr);
		LIME_ASSERT(upVector != nullptr);

		return gcnew Matrix(m_NativeValue->buildCameraLookAtMatrixRH(
			*position->m_NativeValue,
			*target->m_NativeValue,
			*upVector->m_NativeValue));
	}

	/// <summary>
	/// Builds a matrix which transforms a normalized Device Coordinate to Device Coordinates.
	/// Used to scale (-1,-1)(1,1) to viewport, for example from (-1,-1)(1,1) to the viewport (0,0)(0,640).
	/// </summary>
	Matrix^ BuildNDCToDCMatrix(Recti^ area, float zScale)
	{
		LIME_ASSERT(area != nullptr);

		return gcnew Matrix(m_NativeValue->buildNDCToDCMatrix(
			*area->m_NativeValue,
			zScale));
	}

	/// <summary>
	/// Builds a left-handed orthogonal projection matrix.
	/// </summary>
	/// <param name="zClipFromZero">Clipping of z can be projected from 0 to 1 when true (D3D style) and from -1 to 1 when false (OGL style). Default is true.</param>
	Matrix^ BuildProjectionMatrixOrthoLH(float widthOfViewVolume, float heightOfViewVolume, float zNear, float zFar, bool zClipFromZero)
	{
		return gcnew Matrix(m_NativeValue->buildProjectionMatrixOrthoLH(
			widthOfViewVolume, heightOfViewVolume, zNear, zFar, zClipFromZero));
	}

	/// <summary>
	/// Builds a left-handed orthogonal projection matrix.
	/// </summary>
	Matrix^ BuildProjectionMatrixOrthoLH(float widthOfViewVolume, float heightOfViewVolume, float zNear, float zFar)
	{
		return gcnew Matrix(m_NativeValue->buildProjectionMatrixOrthoLH(
			widthOfViewVolume, heightOfViewVolume, zNear, zFar));
	}

	/// <summary>
	/// Builds a right-handed orthogonal projection matrix.
	/// </summary>
	/// <param name="zClipFromZero">Clipping of z can be projected from 0 to 1 when true (D3D style) and from -1 to 1 when false (OGL style). Default is true.</param>
	Matrix^ BuildProjectionMatrixOrthoRH(float widthOfViewVolume, float heightOfViewVolume, float zNear, float zFar, bool zClipFromZero)
	{
		return gcnew Matrix(m_NativeValue->buildProjectionMatrixOrthoRH(
			widthOfViewVolume, heightOfViewVolume, zNear, zFar, zClipFromZero));
	}

	/// <summary>
	/// Builds a right-handed orthogonal projection matrix.
	/// </summary>
	Matrix^ BuildProjectionMatrixOrthoRH(float widthOfViewVolume, float heightOfViewVolume, float zNear, float zFar)
	{
		return gcnew Matrix(m_NativeValue->buildProjectionMatrixOrthoRH(
			widthOfViewVolume, heightOfViewVolume, zNear, zFar));
	}

	/// <summary>
	/// Builds a left-handed perspective projection matrix based on a field of view.
	/// </summary>
	/// <param name="zClipFromZero">Clipping of z can be projected from 0 to w when true (D3D style) and from -w to w when false (OGL style). Default is true.</param>
	Matrix^ BuildProjectionMatrixPerspectiveFovLH(float fieldOfViewRadians, float aspectRatio, float zNear, float zFar, bool zClipFromZero)
	{
		return gcnew Matrix(m_NativeValue->buildProjectionMatrixPerspectiveFovLH(
			fieldOfViewRadians, aspectRatio, zNear, zFar, zClipFromZero));
	}

	/// <summary>
	/// Builds a left-handed perspective projection matrix based on a field of view.
	/// </summary>
	Matrix^ BuildProjectionMatrixPerspectiveFovLH(float fieldOfViewRadians, float aspectRatio, float zNear, float zFar)
	{
		return gcnew Matrix(m_NativeValue->buildProjectionMatrixPerspectiveFovLH(
			fieldOfViewRadians, aspectRatio, zNear, zFar));
	}

	/// <summary>
	/// Builds a right-handed perspective projection matrix based on a field of view.
	/// </summary>
	/// <param name="zClipFromZero">Clipping of z can be projected from 0 to w when true (D3D style) and from -w to w when false (OGL style). Default is true.</param>
	Matrix^ BuildProjectionMatrixPerspectiveFovRH(float fieldOfViewRadians, float aspectRatio, float zNear, float zFar, bool zClipFromZero)
	{
		return gcnew Matrix(m_NativeValue->buildProjectionMatrixPerspectiveFovRH(
			fieldOfViewRadians, aspectRatio, zNear, zFar, zClipFromZero));
	}

	/// <summary>
	/// Builds a right-handed perspective projection matrix based on a field of view.
	/// </summary>
	Matrix^ BuildProjectionMatrixPerspectiveFovRH(float fieldOfViewRadians, float aspectRatio, float zNear, float zFar)
	{
		return gcnew Matrix(m_NativeValue->buildProjectionMatrixPerspectiveFovRH(
			fieldOfViewRadians, aspectRatio, zNear, zFar));
	}

	/// <summary>
	/// Builds a left-handed perspective projection matrix.
	/// </summary>
	/// <param name="zClipFromZero">Clipping of z can be projected from 0 to w when true (D3D style) and from -w to w when false (OGL style). Default is true.</param>
	Matrix^ BuildProjectionMatrixPerspectiveLH(float widthOfViewVolume, float heightOfViewVolume, float zNear, float zFar, bool zClipFromZero)
	{
		return gcnew Matrix(m_NativeValue->buildProjectionMatrixPerspectiveLH(
			widthOfViewVolume, heightOfViewVolume, zNear, zFar, zClipFromZero));
	}

	/// <summary>
	/// Builds a left-handed perspective projection matrix.
	/// </summary>
	Matrix^ BuildProjectionMatrixPerspectiveLH(float widthOfViewVolume, float heightOfViewVolume, float zNear, float zFar)
	{
		return gcnew Matrix(m_NativeValue->buildProjectionMatrixPerspectiveLH(
			widthOfViewVolume, heightOfViewVolume, zNear, zFar));
	}

	/// <summary>
	/// Builds a right-handed perspective projection matrix.
	/// </summary>
	/// <param name="zClipFromZero">Clipping of z can be projected from 0 to w when true (D3D style) and from -w to w when false (OGL style). Default is true.</param>
	Matrix^ BuildProjectionMatrixPerspectiveRH(float widthOfViewVolume, float heightOfViewVolume, float zNear, float zFar, bool zClipFromZero)
	{
		return gcnew Matrix(m_NativeValue->buildProjectionMatrixPerspectiveRH(
			widthOfViewVolume, heightOfViewVolume, zNear, zFar, zClipFromZero));
	}

	/// <summary>
	/// Builds a right-handed perspective projection matrix.
	/// </summary>
	Matrix^ BuildProjectionMatrixPerspectiveRH(float widthOfViewVolume, float heightOfViewVolume, float zNear, float zFar)
	{
		return gcnew Matrix(m_NativeValue->buildProjectionMatrixPerspectiveRH(
			widthOfViewVolume, heightOfViewVolume, zNear, zFar));
	}

	/// <summary>
	/// Builds a matrix that rotates from one vector to another.
	/// </summary>
	Matrix^ BuildRotateFromTo(Vector3Df^ from, Vector3Df^ to)
	{
		LIME_ASSERT(from != nullptr);
		LIME_ASSERT(to != nullptr);

		return gcnew Matrix(m_NativeValue->buildRotateFromTo(
			*from->m_NativeValue,
			*to->m_NativeValue));
	}

	/// <summary>
	/// Builds a matrix that flattens geometry into a plane.
	/// </summary>
	/// <param name="light">Light source.</param>
	/// <param name="plane">Plane into which the geometry if flattened into.</param>
	/// <param name="point">value between 0 and 1, describing the light source.
	/// If this is 1, it is a point light, if it is 0, it is a directional light. Default is 1.f.</param>
	Matrix^ BuildShadowMatrix(Vector3Df^ light, Plane3Df^ plane, float point)
	{
		LIME_ASSERT(light != nullptr);
		LIME_ASSERT(plane != nullptr);
		LIME_ASSERT(point >= 0.0f && point <= 1.0f);

		return gcnew Matrix(m_NativeValue->buildShadowMatrix(
			*light->m_NativeValue,
			*plane->m_NativeValue,
			point));
	}

	/// <summary>
	/// Builds a matrix that flattens geometry into a plane.
	/// </summary>
	/// <param name="light">Light source.</param>
	/// <param name="plane">Plane into which the geometry if flattened into.</param>
	Matrix^ BuildShadowMatrix(Vector3Df^ light, Plane3Df^ plane)
	{
		LIME_ASSERT(light != nullptr);
		LIME_ASSERT(plane != nullptr);

		return gcnew Matrix(m_NativeValue->buildShadowMatrix(
			*light->m_NativeValue,
			*plane->m_NativeValue));
	}

	/// <summary>
	/// Builds a texture transformation matrix with the given parameters.
	/// </summary>
	Matrix^ BuildTextureTransform(float rotateRad, Vector2Df^ rotateCenter, Vector2Df^ translate, Vector2Df^ scale)
	{
		LIME_ASSERT(rotateCenter != nullptr);
		LIME_ASSERT(translate != nullptr);
		LIME_ASSERT(scale != nullptr);

		return gcnew Matrix(m_NativeValue->buildTextureTransform(
			rotateRad,
			*rotateCenter->m_NativeValue,
			*translate->m_NativeValue,
			*scale->m_NativeValue));
	}

	/// <summary>
	/// Gets specific matrix element.
	/// </summary>
	/// <param name="row">Row index of the element. Must be in range of [0..3].</param>
	/// <param name="column">Column index of the element. Must be in range of [0..3].</param>
	float GetElement(int row, int column)
	{
		LIME_ASSERT(row >= 0 && row <= 3);
		LIME_ASSERT(column >= 0 && column <= 3);

		return (*m_NativeValue)(row, column);
	}

	/// <summary>
	/// Gets specific matrix element.
	/// </summary>
	/// <param name="index">Linear index of the element. Must be in range of [0..15].</param>
	float GetElement(int index)
	{
		LIME_ASSERT(index >= 0 && index <= 15);
		return (*m_NativeValue)[index];
	}

	/// <summary>
	/// Gets an interpolated matrix from this and other one.
	/// </summary>
	/// <param name="other">Other matrix to interpolate with.</param>
	/// <param name="time">Must be a value between 0 and 1.</param>
	Matrix^ GetInterpolated(Matrix^ other, float time)
	{
		LIME_ASSERT(other != nullptr);
		LIME_ASSERT(time >= 0.0f && time <= 1.0f);

		return gcnew Matrix(m_NativeValue->interpolate(
			*other->m_NativeValue,
			time));
	}

	/// <summary>
	/// Gets an inverted matrix.
	/// The inverse is calculated using Cramers rule.
	/// </summary>
	/// <returns>Inverse matrix or null the one doesn't exist.</returns>
	Matrix^ GetInverse()
	{
		core::matrix4 m;
		if (m_NativeValue->getInverse(m))
			return gcnew Matrix(m);

		return nullptr;
	}

	/// <summary>
	/// Inverts a primitive matrix which only contains a translation and a rotation.
	/// </summary>
	Matrix^ GetInversePrimitive()
	{
		core::matrix4 m;
		if (m_NativeValue->getInversePrimitive(m))
			return gcnew Matrix(m);

		return nullptr;
	}
	
	Vector3Df^ GetRotationDegrees(Vector3Df^ scale)
	{
		return gcnew Vector3Df(m_NativeValue->getRotationDegrees(*scale->m_NativeValue));
	}

	void GetTextureScale([Out] float% sx, [Out] float% sy)
	{
		float sx_;
		float sy_;
		m_NativeValue->getTextureScale(sx_, sy_);
		sx = sx_;
		sy = sy_;
	}

	void GetTextureTranslate([Out] float% x, [Out] float% y)
	{
		float x_;
		float y_;
		m_NativeValue->getTextureTranslate(x_, y_);
		x = x_;
		y = y_;
	}

	/// <summary>
	/// Rotate a vector by the inverse of the rotation part of this matrix.
	/// </summary>
	void InverseRotateVector(Vector3Df^% vect)
	{
		LIME_ASSERT(vect != nullptr);
		m_NativeValue->inverseRotateVect(*vect->m_NativeValue);
	}

	/// <summary>
	/// Translate a vector by the inverse of the translation part of this matrix.
	/// </summary>
	void InverseTranslateVector(Vector3Df^% vect)
	{
		LIME_ASSERT(vect != nullptr);
		m_NativeValue->inverseTranslateVect(*vect->m_NativeValue);
	}

	/// <summary>
	/// Set matrix to identity.
	/// </summary>
	/// <returns>This matrix after making it identity.</returns>
	Matrix^ MakeIdentity()
	{
		m_NativeValue->makeIdentity();
		return this;
	}

	/// <summary>
	/// Calculates inverse of matrix. Slow.
	/// </summary>
	/// <returns>This matrix after inverse or null if no inverse matrix.</returns>
	Matrix^ MakeInverse()
	{
		bool b = m_NativeValue->makeInverse();
		return b ? this : nullptr;
	}

	/// <summary>
	/// Multiplies this matrix by a 1x4 matrix.
	/// </summary>
	void MultiplyWith1x4Matrix(array<float>^% m1x4)
	{
		LIME_ASSERT(m1x4 != nullptr);
		LIME_ASSERT(m1x4->Length == 4);

		float f[4] = { m1x4[0], m1x4[1], m1x4[2], m1x4[3] };
		m_NativeValue->multiplyWith1x4Matrix(f);

		m1x4[0] = f[0];
		m1x4[1] = f[1];
		m1x4[2] = f[2];
		m1x4[3] = f[3];
	}

	/// <summary>
	/// Rotate a vector by the rotation part of this matrix.
	/// </summary>
	Vector3Df^ RotateVector(Vector3Df^ vect)
	{
		LIME_ASSERT(vect != nullptr);

		core::vector3df v;
		m_NativeValue->rotateVect(v, *vect->m_NativeValue);
		return gcnew Vector3Df(v);
	}

	/// <summary>
	/// Set this matrix to the product of two matrices.
	/// Calculate otherA * otherB.
	/// </summary>
	/// <returns>This matrix.</returns>
	Matrix^ SetByProduct(Matrix^ otherA, Matrix^ otherB)
	{
		LIME_ASSERT(otherA != nullptr);
		LIME_ASSERT(otherB != nullptr);

		m_NativeValue->setbyproduct(*otherA->m_NativeValue, *otherB->m_NativeValue);
		return this;
	}

	/// <summary>
	/// Set this matrix to the product of two matrices.
	/// Calculate otherA * otherB.
	/// No optimization used, use it if you know you never have an identity matrix.
	/// </summary>
	/// <returns>This matrix.</returns>
	Matrix^ SetByProductNoCheck(Matrix^ otherA, Matrix^ otherB)
	{
		LIME_ASSERT(otherA != nullptr);
		LIME_ASSERT(otherB != nullptr);

		m_NativeValue->setbyproduct_nocheck(*otherA->m_NativeValue, *otherB->m_NativeValue);
		return this;
	}

	/// <summary>
	/// Set value of the element of the matrix.
	/// </summary>
	/// <param name="row">Row of the element. Must be in range of [0..3].</param>
	/// <param name="column">Column of the element. Must be in range of [0..3].</param>
	/// <param name="value">Value to set.</param>
	void SetElement(int row, int column, float value)
	{
		LIME_ASSERT(row >= 0 && row <= 3);
		LIME_ASSERT(column >= 0 && column <= 3);

		(*m_NativeValue)(row, column) = value;
	}

	/// <summary>
	/// Set value of the element of the matrix.
	/// </summary>
	/// <param name="index">Linear index of the element. Must be in range of [0..15].</param>
	/// <param name="value">Value to set.</param>
	void SetElement(int index, float value)
	{
		LIME_ASSERT(index >= 0 && index <= 15);
		(*m_NativeValue)[index] = value;
	}

	/// <summary>
	/// Set all matrix elements at once.
	/// </summary>
	/// <param name="values">Array of elements to set. Array length must be at least 16.</param>
	void SetElementArray(array<float>^ values)
	{
		LIME_ASSERT(values != nullptr);
		LIME_ASSERT(values->Length >= 16);

		float p[16];

		for (int i = 0; i < 16; i++)
			p[i] = values[i];

		m_NativeValue->setM(p);
	}

	/// <summary>
	/// Make an inverted rotation matrix from Euler angles.
	/// The 4th row and column are unmodified.
	/// </summary>
	/// <returns>This matrix.</returns>
	Matrix^ SetInverseRotationDegrees(Vector3Df^ rotation)
	{
		LIME_ASSERT(rotation != nullptr);

		m_NativeValue->setInverseRotationDegrees(*rotation->m_NativeValue);
		return this;
	}

	/// <summary>
	/// Make an inverted rotation matrix from Euler angles.
	/// The 4th row and column are unmodified.
	/// </summary>
	/// <returns>This matrix.</returns>
	Matrix^ SetInverseRotationRadians(Vector3Df^ rotation)
	{
		LIME_ASSERT(rotation != nullptr);

		m_NativeValue->setInverseRotationRadians(*rotation->m_NativeValue);
		return this;
	}

	/// <summary>
	/// Set the inverse translation of the current matrix. Will erase any previous values.
	/// </summary>
	/// <returns>This matrix.</returns>
	Matrix^ SetInverseTranslation(Vector3Df^ translation)
	{
		LIME_ASSERT(translation != nullptr);

		m_NativeValue->setInverseTranslation(*translation->m_NativeValue);
		return this;
	}

	/// <summary>
	/// Builds a combined matrix which translates to a center before rotation and translates from origin afterwards.
	/// </summary>
	/// <param name="center">Position to rotate around.</param>
	/// <param name="translate">Translation applied after the rotation.</param>
	void SetRotationCenter(Vector3Df^ center, Vector3Df^ translate)
	{
		LIME_ASSERT(center != nullptr);
		LIME_ASSERT(translate != nullptr);

		m_NativeValue->setRotationCenter(
			*center->m_NativeValue,
			*translate->m_NativeValue);
	}

	/// <summary>
	/// Make a rotation matrix from angle and axis, assuming left handed rotation.
	/// The 4th row and column are unmodified.
	/// </summary>
	/// <returns>This matrix.</returns>
	Matrix^ SetRotationAxisRadians(float angle, Vector3Df^ axis)
	{
		LIME_ASSERT(axis != nullptr);

		m_NativeValue->setRotationAxisRadians(angle, *axis->m_NativeValue);
		return this;
	}

	/// <summary>
	/// Make a rotation matrix from Euler angles.
	/// The 4th row and column are unmodified.
	/// </summary>
	/// <returns>This matrix.</returns>
	Matrix^ SetRotationRadians(Vector3Df^ rotation)
	{
		LIME_ASSERT(rotation != nullptr);

		m_NativeValue->setRotationRadians(*rotation->m_NativeValue);
		return this;
	}

	/// <summary>
	/// Set texture transformation rotation.
	/// Rotate about z axis, recenter at (0.5,0.5). Doesn't clear other elements than those affected.
	/// </summary>
	/// <param name="radAngle">Angle in radians.</param>
	/// <returns>This matrix.</returns>
	Matrix^ SetTextureRotationCenter(float radAngle)
	{
		m_NativeValue->setTextureRotationCenter(radAngle);
		return this;
	}

	/// <summary>
	/// Set texture transformation scale.
	/// Doesn't clear other elements than those affected.
	/// </summary>
	/// <param name="sx">Scale factor on x axis.</param>
	/// <param name="sy">Scale factor on y axis.</param>
	/// <returns>This matrix.</returns>
	Matrix^ SetTextureScale(float sx, float sy)
	{
		m_NativeValue->setTextureScale(sx, sy);
		return this;
	}

	/// <summary>
	/// Set texture transformation scale, and recenter at (0.5,0.5).
	/// Doesn't clear other elements than those affected.
	/// </summary>
	/// <param name="sx">Scale factor on x axis.</param>
	/// <param name="sy">Scale factor on y axis.</param>
	/// <returns>This matrix.</returns>
	Matrix^ SetTextureScaleCenter(float sx, float sy)
	{
		m_NativeValue->setTextureScaleCenter(sx, sy);
		return this;
	}

	/// <summary>
	/// Set texture transformation translation.
	/// Doesn't clear other elements than those affected.
	/// </summary>
	/// <param name="x">Offset on x axis.</param>
	/// <param name="y">Offset on y axis.</param>
	/// <returns>This matrix.</returns>
	Matrix^ SetTextureTranslate(float x, float y)
	{
		m_NativeValue->setTextureTranslate(x, y);
		return this;
	}

	/// <summary>
	/// Set texture transformation translation, using a transposed representation.
	/// Doesn't clear other elements than those affected.
	/// </summary>
	/// <param name="x">Offset on x axis.</param>
	/// <param name="y">Offset on y axis.</param>
	/// <returns>This matrix.</returns>
	Matrix^ SetTextureTranslateTransposed(float x, float y)
	{
		m_NativeValue->setTextureTranslateTransposed(x, y);
		return this;
	}

	/// <summary>
	/// Returns array of all 16 elements of the matrix.
	/// </summary>
	array<float>^ ToArray()
	{
		array<float>^ m = gcnew array<float>(16);
		float* p = m_NativeValue->pointer();

		for (int i = 0; i < 16; i++)
			m[i] = p[i];

		return m;
	}

	[Obsolete("Deprecated as it's usually not what people need (regards only 2 corners, but other corners might be outside the box after transformation). Use TransformBoxEx instead.")]
	/// <summary>
	/// Transforms the edge-points of a bounding box.
	/// The result box of this operation may not be accurate at all. For correct results, use TransformBoxEx().
	/// </summary>
	void TransformBox(AABBox^% box)
	{
		LIME_ASSERT(box != nullptr);
		m_NativeValue->transformBox(*box->m_NativeValue);
	}

	/// <summary>
	/// Transforms an axis aligned bounding box.
	/// The result box of this operation should be accurate, but this operation is slower than TransformBox().
	/// </summary>
	void TransformBoxEx(AABBox^% box)
	{
		LIME_ASSERT(box != nullptr);
		m_NativeValue->transformBoxEx(*box->m_NativeValue);
	}

	/// <summary>
	/// Transforms a plane by this matrix.
	/// </summary>
	void TransformPlane(Plane3Df^% plane)
	{
		LIME_ASSERT(plane != nullptr);
		m_NativeValue->transformPlane(*plane->m_NativeValue);
	}

	/// <summary>
	/// Transforms a vector by this matrix.
	/// This operation is performed as if the vector was 4d with the 4th component =1.
	/// </summary>
	void TransformVector(Vector3Df^% vect)
	{
		LIME_ASSERT(vect != nullptr);
		m_NativeValue->transformVect(*vect->m_NativeValue);
	}

	/// <summary>
	/// Translates a vector by the translation part of this matrix.
	/// This operation is performed as if the vector was 4d with the 4th component =1.
	/// </summary>
	void TranslateVector(Vector3Df^% vect)
	{
		LIME_ASSERT(vect != nullptr);
		m_NativeValue->translateVect(*vect->m_NativeValue);
	}

	/// <summary>
	/// The matrix is definitely identity matrix.
	/// </summary>
	property bool IsDefinitelyIdentity
	{
		bool get() { return m_NativeValue->getDefinitelyIdentityMatrix(); }
		void set(bool value) { m_NativeValue->setDefinitelyIdentityMatrix(value); }
	}

	/// <summary>
	/// The matrix is identity matrix.
	/// </summary>
	property bool IsIdentity
	{
		bool get() { return m_NativeValue->isIdentity(); }
	}

	/// <summary>
	/// The matrix is identity matrix.
	/// </summary>
	property bool IsIdentityIntegerBase
	{
		bool get() { return m_NativeValue->isIdentity_integer_base(); }
	}

	/// <summary>
	/// The matrix is orthogonal matrix.
	/// </summary>
	property bool IsOrthogonal
	{
		bool get() { return m_NativeValue->isOrthogonal(); }
	}

	/// <summary>
	/// Current rotation of the matrix.
	/// </summary>
	property Vector3Df^ Rotation
	{
		Vector3Df^ get() { return gcnew Vector3Df(m_NativeValue->getRotationDegrees()); }
		void set(Vector3Df^ value) { LIME_ASSERT(value != nullptr); m_NativeValue->setRotationDegrees(*value->m_NativeValue); }
	}

	/// <summary>
	/// Current scale of the matrix.
	/// </summary>
	property Vector3Df^ Scale
	{
		Vector3Df^ get() { return gcnew Vector3Df(m_NativeValue->getScale()); }
		void set(Vector3Df^ value) { LIME_ASSERT(value != nullptr); m_NativeValue->setScale(*value->m_NativeValue); }
	}

	/// <summary>
	/// Current translation of the matrix.
	/// </summary>
	property Vector3Df^ Translation
	{
		Vector3Df^ get() { return gcnew Vector3Df(m_NativeValue->getTranslation()); }
		void set(Vector3Df^ value) { LIME_ASSERT(value != nullptr); m_NativeValue->setTranslation(*value->m_NativeValue); }
	}

	/// <summary>
	/// Transposed matrix.
	/// </summary>
	property Matrix^ Transposed
	{
		Matrix^ get() { return gcnew Matrix(m_NativeValue->getTransposed()); }
	}

internal:

	Matrix(const core::matrix4& other)
		: Lime::NativeValue<core::matrix4>(true)
	{
		m_NativeValue = new core::matrix4(other);
	}

	Matrix(core::matrix4* ref)
		: Lime::NativeValue<core::matrix4>(false)
	{
		LIME_ASSERT(ref != nullptr);
		m_NativeValue = ref;
	}
};

} // end namespace Core
} // end namespace IrrlichtLime
