#if !defined(_REFCLASS_) || !defined(_WRAPCLASS_) || !defined(_WRAPTYPE_)
#error _REFCLASS_, _WRAPCLASS_ and _WRAPTYPE_ must be defined for this file to process.
#endif

/// <summary>
/// 3d vector class with lots of operators and methods.
/// This class is used in Irrlicht for three main purposes:
/// 1) As a direction vector (most of the methods assume this).
/// 2) As a position in 3d space (which is synonymous with a direction vector from the origin to this position).
/// 3) To hold three Euler rotations, where X is pitch, Y is yaw and Z is roll.
/// </summary>
public ref class _REFCLASS_ : Lime::NativeValue<_WRAPCLASS_>
{
	#include "Vector_common_template.h"

public:

	/// <summary>
	/// Constructor with three scalars.
	/// </summary>
	_REFCLASS_(_WRAPTYPE_ x, _WRAPTYPE_ y, _WRAPTYPE_ z)
		: Lime::NativeValue<_WRAPCLASS_>(true)
	{
		m_NativeValue = new _WRAPCLASS_(x, y, z);
	}

	/// <summary>
	/// Set this vector by three scalars.
	/// </summary>
	void Set(_WRAPTYPE_ x, _WRAPTYPE_ y, _WRAPTYPE_ z)
	{
		m_NativeValue->set(x, y, z);
	}

	/// <summary>
	/// Calculates the cross product with another vector.
	/// </summary>
	_REFCLASS_^ CrossProduct(_REFCLASS_^ other)
	{
		LIME_ASSERT(other != nullptr);
		return gcnew _REFCLASS_(m_NativeValue->crossProduct(*other->m_NativeValue));
	}

	/// <summary>
	/// Check if this vector equals the other one, taking floating point rounding errors into account.
	/// </summary>
	bool EqualsTo(_REFCLASS_^ other, _WRAPTYPE_ tolerance)
	{
		LIME_ASSERT(other != nullptr);
		return m_NativeValue->equals(*other->m_NativeValue, tolerance);
	}

	/// <summary>
	/// Fills an array of 3 values with the vector data.
	/// Useful for setting in shader constants for example.
	/// </summary>
	array<_WRAPTYPE_>^ ToArrayOf3()
	{
		_WRAPTYPE_ b[3];
		m_NativeValue->getAs3Values(b);

		array<_WRAPTYPE_>^ a = gcnew array<_WRAPTYPE_>(3);
		for (int i = 0; i < 3; i++)
			a[i] = b[i];

		return a;
	}

	/// <summary>
	/// Fills an array of 4 values with the vector data.
	/// Useful for setting in shader constants for example. The fourth value will always be 0.
	/// </summary>
	array<_WRAPTYPE_>^ ToArrayOf4()
	{
		_WRAPTYPE_ b[4];
		m_NativeValue->getAs4Values(b);

		array<_WRAPTYPE_>^ a = gcnew array<_WRAPTYPE_>(4);
		for (int i = 0; i < 4; i++)
			a[i] = b[i];

		return a;
	}

	/// <summary>
	/// Inverts this vector.
	/// </summary>
	/// <returns>This vector after inversion.</returns>
	_REFCLASS_^ Invert()
	{
		m_NativeValue->invert();
		return this;
	}

	

	/// <summary>
	/// Rotates this vector by a specified number of degrees around the Z axis and the specified center.
	/// </summary>
	/// <param name="center">The center of the rotation. Default is (0,0,0).</param>
	void RotateXYby(double degrees, _REFCLASS_^ center)
	{
		LIME_ASSERT(center != nullptr);
		m_NativeValue->rotateXYBy(degrees, *center->m_NativeValue);
	}

	/// <summary>
	/// Rotates this vector by a specified number of degrees around the Z axis and the specified center.
	/// </summary>
	void RotateXYby(double degrees)
	{
		m_NativeValue->rotateXYBy(degrees);
	}

	/// <summary>
	/// Rotates this vector by a specified number of degrees around the Y axis and the specified center.
	/// </summary>
	/// <param name="center">The center of the rotation. Default is (0,0,0).</param>
	void RotateXZby(double degrees, _REFCLASS_^ center)
	{
		LIME_ASSERT(center != nullptr);
		m_NativeValue->rotateXZBy(degrees, *center->m_NativeValue);
	}

	/// <summary>
	/// Rotates this vector by a specified number of degrees around the Y axis and the specified center.
	/// </summary>
	void RotateXZby(double degrees)
	{
		m_NativeValue->rotateXZBy(degrees);
	}

	/// <summary>
	/// Rotates this vector by a specified number of degrees around the X axis and the specified center.
	/// </summary>
	/// <param name="center">The center of the rotation. Default is (0,0,0).</param>
	void RotateYZby(double degrees, _REFCLASS_^ center)
	{
		LIME_ASSERT(center != nullptr);
		m_NativeValue->rotateYZBy(degrees, *center->m_NativeValue);
	}

	/// <summary>
	/// Rotates this vector by a specified number of degrees around the X axis and the specified center.
	/// </summary>
	void RotateYZby(double degrees)
	{
		m_NativeValue->rotateYZBy(degrees);
	}

	/// <summary>
	/// Builds a direction vector from (this) rotation vector.
	/// This vector is assumed to be a rotation vector composed of 3 Euler angle rotations, in degrees.
	/// The implementation performs the same calculations as using a matrix to do the rotation.
	/// </summary>
	/// <param name="forwards">The direction representing "forwards" which will be rotated by this vector. Default is (0,0,1).</param>
	/// <returns>A direction vector calculated by rotating the forwards direction by the 3 Euler angles (in degrees) represented by this vector.</returns>
	_REFCLASS_^ RotationToDirection(_REFCLASS_^ forwards)
	{
		LIME_ASSERT(forwards != nullptr);
		return gcnew _REFCLASS_(m_NativeValue->rotationToDirection(*forwards->m_NativeValue));
	}

	/// <summary>
	/// Builds a direction vector from (this) rotation vector.
	/// This vector is assumed to be a rotation vector composed of 3 Euler angle rotations, in degrees.
	/// The implementation performs the same calculations as using a matrix to do the rotation.
	/// </summary>
	/// <returns>A direction vector calculated by rotating the forwards direction by the 3 Euler angles (in degrees) represented by this vector.</returns>
	_REFCLASS_^ RotationToDirection()
	{
		return gcnew _REFCLASS_(m_NativeValue->rotationToDirection());
	}

	/// <summary>
	/// The rotations that would make a (0,0,1) direction vector point in the same direction as this direction vector.
	/// Thanks to Arras on the Irrlicht forums for this method. This utility method is very useful for orienting scene nodes towards specific targets.
	/// For example, if this vector represents the difference between two scene nodes, then applying the result of this property to one scene node
	/// will point it at the other one.
	/// </summary>
	property _REFCLASS_^ HorizontalAngle
	{
		_REFCLASS_^ get() { return gcnew _REFCLASS_(m_NativeValue->getHorizontalAngle()); }
	}

	/// <summary>
	/// The length of the vector.
	/// </summary>
	property _WRAPTYPE_ Length
	{
		_WRAPTYPE_ get() { return m_NativeValue->getLength(); }
		void set(_WRAPTYPE_ value) { m_NativeValue->setLength(value); }
	}

	/// <summary>
	/// The spherical coordinate angles.
	/// This returns Euler degrees for the point represented by this vector.
	/// The calculation assumes the pole at (0, 1, 0) and returns the angles in X and Y.
	/// </summary>
	property _REFCLASS_^ SphericalCoordinateAngles
	{
		_REFCLASS_^ get() { return gcnew _REFCLASS_(m_NativeValue->getSphericalCoordinateAngles()); }
	}

	/// <summary>
	/// Z coordinate of the vector.
	/// </summary>
	property _WRAPTYPE_ Z
	{
		_WRAPTYPE_ get() { return m_NativeValue->Z; }
		void set(_WRAPTYPE_ value) { m_NativeValue->Z = value; }
	}

	virtual String^ ToString() override
	{
		return String::Format("{0}, {1}, {2}", X, Y, Z);
	}
};
