#if !defined(_REFCLASS_) || !defined(_WRAPCLASS_) || !defined(_WRAPTYPE_)
#error _REFCLASS_, _WRAPCLASS_ and _WRAPTYPE_ must be defined for this file to process.
#endif

/// <summary>
/// 2d vector class with lots of operators and methods.
/// </summary>
public ref class _REFCLASS_ : Lime::NativeValue<_WRAPCLASS_>
{
	#include "Vector_common_template.h"

public:

	/// <summary>
	/// Constructor with two scalars.
	/// </summary>
	_REFCLASS_(_WRAPTYPE_ x, _WRAPTYPE_ y)
		: Lime::NativeValue<_WRAPCLASS_>(true)
	{
		m_NativeValue = new _WRAPCLASS_(x, y);
	}

	/// <summary>
	/// Set this vector by two scalars.
	/// </summary>
	void Set(_WRAPTYPE_ x, _WRAPTYPE_ y)
	{
		m_NativeValue->set(x, y);
	}

	/// <summary>
	/// Calculates the angle between this vector and another one in degree.
	/// </summary>
	double GetAngleWith(_REFCLASS_^ other)
	{
		LIME_ASSERT(other != nullptr);
		return m_NativeValue->getAngleWith(*other->m_NativeValue);
	}

	/// <summary>
	/// Rotates the point anticlockwise around a center by an amount of degrees.
	/// </summary>
	/// <param name="center">The center of the rotation. Default is (0,0).</param>
	/// <returns>This vector after transformation.</returns>
	_REFCLASS_^ RotateBy(double degrees, _REFCLASS_^ center)
	{
		LIME_ASSERT(center != nullptr);

		m_NativeValue->rotateBy(degrees, *center->m_NativeValue);
		return this;
	}

	/// <summary>
	/// Rotates the point anticlockwise around a center by an amount of degrees.
	/// </summary>
	/// <returns>This vector after transformation.</returns>
	_REFCLASS_^ RotateBy(double degrees)
	{
		m_NativeValue->rotateBy(degrees);
		return this;
	}

	/// <summary>
	/// The angle of this vector in degrees in the counter trigonometric sense.
	/// 0 is to the right (3 o'clock), values increase clockwise.
	/// </summary>
	property double Angle
	{
		double get() { return m_NativeValue->getAngle(); }
	}

	/// <summary>
	/// The angle of this vector in degrees in the trigonometric sense.
	/// 0 is to the right (3 o'clock), values increase counter-clockwise.
	/// </summary>
	property double AngleTrig
	{
		double get() { return m_NativeValue->getAngleTrig(); }
	}

	/// <summary>
	/// The length of the vector.
	/// </summary>
	property _WRAPTYPE_ Length
	{
		_WRAPTYPE_ get() { return m_NativeValue->getLength(); }
	}

	virtual String^ ToString() override
	{
		return String::Format("{0}, {1}", X, Y);
	}
};
