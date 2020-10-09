#pragma once

#include "stdafx.h"

using namespace irr;
using namespace System;

namespace IrrlichtLime {
namespace Core {

/// <summary>
/// Quaternion class for representing rotations.
/// It provides cheap combinations and avoids gimbal locks.
/// Also useful for interpolations.
/// </summary>
public ref class Quaternion : Lime::NativeValue<core::quaternion>
{
public:

	/// <summary>
	/// Identity quaternion.
	/// </summary>
	static property Quaternion^ Identity { Quaternion^ get() { return gcnew Quaternion(); } }

	/// <summary>
	/// Equality operator.
	/// </summary>
	static bool operator == (Quaternion^ q1, Quaternion^ q2)
	{
		bool q1n = Object::ReferenceEquals(q1, nullptr);
		bool q2n = Object::ReferenceEquals(q2, nullptr);

		if (q1n && q2n)
			return true;

		if (q1n || q2n)
			return false;

		return (*q1->m_NativeValue) == (*q2->m_NativeValue);
	}

	/// <summary>
	/// Inequality operator.
	/// </summary>
	static bool operator != (Quaternion^ q1, Quaternion^ q2)
	{
		return !(q1 == q2);
	}

	/// <summary>
	/// Add operator.
	/// </summary>
	static Quaternion^ operator + (Quaternion^ q1, Quaternion^ q2)
	{
		LIME_ASSERT(q1 != nullptr);
		LIME_ASSERT(q2 != nullptr);

		return gcnew Quaternion((*q1->m_NativeValue) + (*q2->m_NativeValue));
	}

	/// <summary>
	/// Multiplication operator.
	/// Be careful, unfortunately the operator order here is opposite of that in <c>Matrix.operator*()</c>.
	/// </summary>
	static Quaternion^ operator * (Quaternion^ q1, Quaternion^ q2)
	{
		LIME_ASSERT(q1 != nullptr);
		LIME_ASSERT(q2 != nullptr);

		return gcnew Quaternion((*q1->m_NativeValue) * (*q2->m_NativeValue));
	}

	/// <summary>
	/// Multiplication operator.
	/// </summary>
	static Quaternion^ operator * (Quaternion^ q, Vector3Df^ v)
	{
		LIME_ASSERT(q != nullptr);
		LIME_ASSERT(v != nullptr);

		return gcnew Quaternion((*q->m_NativeValue) * (*v->m_NativeValue));
	}

	/// <summary>
	/// Multiplication operator with scalar.
	/// </summary>
	static Quaternion^ operator * (Quaternion^ q, float a)
	{
		LIME_ASSERT(q != nullptr);
		return gcnew Quaternion((*q->m_NativeValue) * a);
	}

	/// <summary>
	/// Constructs identity quaternion.
	/// </summary>
	Quaternion()
		: Lime::NativeValue<core::quaternion>(true)
	{
		m_NativeValue = new core::quaternion();
	}

	/// <summary>
	/// Copy constructor.
	/// </summary>
	/// <param name="copy">Other quaternion.</param>
	Quaternion(Quaternion^ copy)
		: Lime::NativeValue<core::quaternion>(true)
	{
		LIME_ASSERT(copy != nullptr);

		m_NativeValue = new core::quaternion();
		m_NativeValue->set(*copy->m_NativeValue);
	}

	/// <summary>
	/// Constructs quaternion directly by given imaginary part (x, y, z) and real part (w).
	/// </summary>
	Quaternion(float x, float y, float z, float w)
		: Lime::NativeValue<core::quaternion>(true)
	{
		m_NativeValue = new core::quaternion(x, y, z, w);
	}

	/// <summary>
	/// Constructor which converts a matrix to a quaternion.
	/// </summary>
	Quaternion(Matrix^ mat)
		: Lime::NativeValue<core::quaternion>(true)
	{
		LIME_ASSERT(mat != nullptr);
		m_NativeValue = new core::quaternion(*mat->m_NativeValue);
	}

	/// <summary>
	/// Constructor which converts Euler angles (radians) to a quaternion.
	/// </summary>
	Quaternion(Vector3Df^ eulerAngles)
		: Lime::NativeValue<core::quaternion>(true)
	{
		LIME_ASSERT(eulerAngles != nullptr);
		m_NativeValue = new core::quaternion(*eulerAngles->m_NativeValue);
	}

	/// <summary>
	/// Constructor which converts Euler angles (radians) to a quaternion.
	/// </summary>
	Quaternion(float eulerAngleX, float eulerAngleY, float eulerAngleZ)
		: Lime::NativeValue<core::quaternion>(true)
	{
		m_NativeValue = new core::quaternion(eulerAngleX, eulerAngleY, eulerAngleZ);
	}

	/// <summary>
	/// Set this quaternion from other quaternion.
	/// </summary>
	void Set(Quaternion^ newQuat)
	{
		LIME_ASSERT(newQuat != nullptr);
		m_NativeValue->set(*newQuat->m_NativeValue);
	}

	/// <summary>
	/// Constructor which converts Euler angles (radians) to a quaternion.
	/// </summary>
	void Set(Vector3Df^ eulerAngles)
	{
		LIME_ASSERT(eulerAngles != nullptr);
		m_NativeValue->set(*eulerAngles->m_NativeValue);
	}

	/// <summary>
	/// Set this quaternion directly by given imaginary part (x, y, z) and real part (w).
	/// </summary>
	void Set(float newX, float newY, float newZ, float newW)
	{
		m_NativeValue->set(newX, newY, newZ, newW);
	}

	/// <summary>
	/// Set this quaternion based on Euler angles (radians).
	/// </summary>
	void Set(float eulerAngleX, float eulerAngleY, float eulerAngleZ)
	{
		m_NativeValue->set(eulerAngleX, eulerAngleY, eulerAngleZ);
	}

	/// <summary>
	/// Calculates the dot product.
	/// </summary>
	float DotProduct(Quaternion^ other)
	{
		LIME_ASSERT(other != nullptr);
		return m_NativeValue->dotProduct(*other->m_NativeValue);
	}

	/// <summary>
	/// Checks if this quaternion equals the other one, taking floating point rounding errors into account.
	/// </summary>
	bool EqualsTo(Quaternion^ other)
	{
		LIME_ASSERT(other != nullptr);
		return m_NativeValue->equals(*other->m_NativeValue);
	}

	/// <summary>
	/// Gets the rotation matrix from this quaternion.
	/// </summary>
	Matrix^ GetMatrix()
	{
		return gcnew Matrix(m_NativeValue->getMatrix());
	}

	/// <summary>
	/// Gets the rotation matrix from this quaternion.
	/// </summary>
	/// <param name="translation">Default is (0,0,0).</param>
	Matrix^ GetMatrix(Vector3Df^ translation)
	{
		LIME_ASSERT(translation != nullptr);

		Matrix^ m = gcnew Matrix();
		m_NativeValue->getMatrix(*m->m_NativeValue, *translation->m_NativeValue);

		return m;
	}

	/// <summary>
	/// Faster method to create a rotation matrix, you should normalize the quaternion before!
	/// </summary>
	Matrix^ GetMatrixFast()
	{
		Matrix^ m = gcnew Matrix();
		m_NativeValue->getMatrixFast(*m->m_NativeValue);
		return m;
	}

	/// <summary>
	/// Creates a matrix from this quaternion.
	/// </summary>
	Matrix^ GetMatrixCenter(Vector3Df^ center, Vector3Df^ translation)
	{
		LIME_ASSERT(center != nullptr);
		LIME_ASSERT(translation != nullptr);

		Matrix^ m = gcnew Matrix();
		m_NativeValue->getMatrixCenter(*m->m_NativeValue, *center->m_NativeValue, *translation->m_NativeValue);

		return m;
	}

	/// <summary>
	/// Set this quaternion to the result of the linear interpolation between two quaternions.
	/// </summary>
	/// <returns>This quaternion.</returns>
	Quaternion^ Lerp(Quaternion^ q1, Quaternion^ q2, float time)
	{
		LIME_ASSERT(q1 != nullptr);
		LIME_ASSERT(q2 != nullptr);

		m_NativeValue->lerp(*q1->m_NativeValue, *q2->m_NativeValue, time);
		return this;
	}

	/// <summary>
	/// Set this quaternion to identity.
	/// </summary>
	/// <returns>This quaternion.</returns>
	Quaternion^ MakeIdentity()
	{
		m_NativeValue->makeIdentity();
		return this;
	}

	/// <summary>
	/// Inverts this quaternion.
	/// </summary>
	/// <returns>This quaternion.</returns>
	Quaternion^ MakeInverse()
	{
		m_NativeValue->makeInverse();
		return this;
	}

	/// <summary>
	/// Set this quaternion to represent a rotation from one vector to another.
	/// </summary>
	/// <returns>This quaternion.</returns>
	Quaternion^ MakeRotation(Vector3Df^ from, Vector3Df^ to)
	{
		LIME_ASSERT(from != nullptr);
		LIME_ASSERT(to != nullptr);

		m_NativeValue->rotationFromTo(*from->m_NativeValue, *to->m_NativeValue);
		return this;
	}

	/// <summary>
	/// Set this quaternion to represent a rotation from angle and axis.
	/// Axis must be unit length, angle in radians.
	/// The quaternion representing the rotation is q = cos(A/2) + sin(A/2) * (x*i + y*j + z*k).
	/// </summary>
	/// <returns>This quaternion.</returns>
	Quaternion^ MakeRotation(float angle, Vector3Df^ axis)
	{
		LIME_ASSERT(axis != nullptr);

		m_NativeValue->fromAngleAxis(angle, *axis->m_NativeValue);
		return this;
	}

	/// <summary>
	/// Normalizes this quaternion.
	/// </summary>
	/// <returns>This quaternion.</returns>
	Quaternion^ Normalize()
	{
		m_NativeValue->normalize();
		return this;
	}

	/// <summary>
	/// Set this quaternion to the result of the spherical interpolation between two quaternions.
	/// </summary>
	/// <param name="q1">First quaternion to be interpolated.</param>
	/// <param name="q2">Second quaternion to be interpolated.</param>
	/// <param name="time">Progress of interpolation. For time=0 the result is q1, for time=1 the result is q2. Otherwise interpolation between q1 and q2.</param>
	/// <param name="threshold">To avoid inaccuracies at the end (time=1) the interpolation switches to linear interpolation at some point.
	/// This value defines how much of the remaining interpolation will be calculated with <c>Lerp()</c>.
	/// Everything from 1-threshold up will be linear interpolation. Default is .05f.</param>
	/// <returns>This quaternion.</returns>
	Quaternion^ Slerp(Quaternion^ q1, Quaternion^ q2, float time, float threshold)
	{
		LIME_ASSERT(q1 != nullptr);
		LIME_ASSERT(q2 != nullptr);

		m_NativeValue->slerp(*q1->m_NativeValue, *q2->m_NativeValue, time, threshold);
		return this;
	}

	/// <summary>
	/// Set this quaternion to the result of the spherical interpolation between two quaternions.
	/// </summary>
	/// <param name="q1">First quaternion to be interpolated.</param>
	/// <param name="q2">Second quaternion to be interpolated.</param>
	/// <param name="time">Progress of interpolation. For time=0 the result is q1, for time=1 the result is q2. Otherwise interpolation between q1 and q2.</param>
	/// <returns>This quaternion.</returns>
	Quaternion^ Slerp(Quaternion^ q1, Quaternion^ q2, float time)
	{
		LIME_ASSERT(q1 != nullptr);
		LIME_ASSERT(q2 != nullptr);

		m_NativeValue->slerp(*q1->m_NativeValue, *q2->m_NativeValue, time);
		return this;
	}

	/// <summary>
	/// Fills an angle (radians) around an axis (unit vector).
	/// </summary>
	void ToAngleAxis([Out] float% angle, [Out] Vector3Df^% axis)
	{
		LIME_ASSERT(axis != nullptr);

		float a;
		m_NativeValue->toAngleAxis(a, *axis->m_NativeValue);
		angle = a;
	}

	/// <summary>
	/// Euler angle (radians).
	/// </summary>
	Vector3Df^ ToEuler()
	{
		core::vector3df v;
		m_NativeValue->toEuler(v);

		return gcnew Vector3Df(v);
	}

	/// <summary>
	/// Real part.
	/// </summary>
	property float W
	{
		float get() { return m_NativeValue->W; }
		void set(float value) { m_NativeValue->W = value; }
	}

	/// <summary>
	/// X coordinate of the vectorial (imaginary) part.
	/// </summary>
	property float X
	{
		float get() { return m_NativeValue->X; }
		void set(float value) { m_NativeValue->X = value; }
	}

	/// <summary>
	/// Y coordinate of the vectorial (imaginary) part.
	/// </summary>
	property float Y
	{
		float get() { return m_NativeValue->Y; }
		void set(float value) { m_NativeValue->Y = value; }
	}

	/// <summary>
	/// Z coordinate of the vectorial (imaginary) part.
	/// </summary>
	property float Z
	{
		float get() { return m_NativeValue->Z; }
		void set(float value) { m_NativeValue->Z = value; }
	}

	virtual String^ ToString() override
	{
		return String::Format("({0}) W={1}", gcnew Vector3Df(X, Y, Z), W);
	}

internal:

	Quaternion(const core::quaternion& value)
		: Lime::NativeValue<core::quaternion>(true)
	{
		m_NativeValue = new core::quaternion(value);
	}
};

} // end namespace Core
} // end namespace IrrlichtLime
