#if !defined(_REFCLASS_) || !defined(_WRAPCLASS_) || !defined(_WRAPTYPE_)
#error _REFCLASS_, _WRAPCLASS_ and _WRAPTYPE_ must be defined for this file to process.
#endif

public:

	/// <summary>
	/// Equality operator.
	/// </summary>
	static bool operator == (_REFCLASS_^ v1, _REFCLASS_^ v2)
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
	static bool operator != (_REFCLASS_^ v1, _REFCLASS_^ v2)
	{
		return !(v1 == v2);
	}

	/// <summary>
	/// Add two dimensions.
	/// </summary>
	static _REFCLASS_^ operator + (_REFCLASS_^ v1, _REFCLASS_^ v2)
	{
		LIME_ASSERT(v1 != nullptr);
		LIME_ASSERT(v2 != nullptr);

		return gcnew _REFCLASS_((*v1->m_NativeValue) + (*v2->m_NativeValue));
	}

	/// <summary>
	/// Subtract one dimension from another.
	/// </summary>
	static _REFCLASS_^ operator - (_REFCLASS_^ v1, _REFCLASS_^ v2)
	{
		LIME_ASSERT(v1 != nullptr);
		LIME_ASSERT(v2 != nullptr);

		return gcnew _REFCLASS_((*v1->m_NativeValue) - (*v2->m_NativeValue));
	}

	/// <summary>
	/// Multiply width and height by scalar.
	/// </summary>
	static _REFCLASS_^ operator * (_REFCLASS_^ v1, _WRAPTYPE_ v2)
	{
		LIME_ASSERT(v1 != nullptr);
		return gcnew _REFCLASS_((*v1->m_NativeValue) * v2);
	}

	/// <summary>
	/// Divide width and height by scalar.
	/// </summary>
	static _REFCLASS_^ operator / (_REFCLASS_^ v1, _WRAPTYPE_ v2)
	{
		LIME_ASSERT(v1 != nullptr);
		return gcnew _REFCLASS_((*v1->m_NativeValue) / v2);
	}

	/// <summary>
	/// Default constructor.
	/// Initializes empty dimension (0x0).
	/// </summary>
	_REFCLASS_()
		: Lime::NativeValue<_WRAPCLASS_>(true)
	{
		m_NativeValue = new _WRAPCLASS_();
	}

	/// <summary>
	/// Copy constructor.
	/// </summary>
	/// <param name="copy">Other dimension.</param>
	_REFCLASS_(_REFCLASS_^ copy)
		: Lime::NativeValue<_WRAPCLASS_>(true)
	{
		LIME_ASSERT(copy != nullptr);
		m_NativeValue = new _WRAPCLASS_(*copy->m_NativeValue);
	}

	/// <summary>
	/// Constructor with same width and height.
	/// </summary>
	/// <param name="widthAndHeight">Value for width and height.</param>
	_REFCLASS_(_WRAPTYPE_ widthAndHeight)
		: Lime::NativeValue<_WRAPCLASS_>(true)
	{
		m_NativeValue = new _WRAPCLASS_(widthAndHeight, widthAndHeight);
	}

	/// <summary>
	/// Constructor with width and height.
	/// </summary>
	/// <param name="width">Width value.</param>
	/// <param name="height">Height value.</param>
	_REFCLASS_(_WRAPTYPE_ width, _WRAPTYPE_ height)
		: Lime::NativeValue<_WRAPCLASS_>(true)
	{
		m_NativeValue = new _WRAPCLASS_(width, height);
	}

	/// <summary>
	/// Sets this dimension to a new dimension.
	/// </summary>
	/// <param name="copy">Other dimension.</param>
	void Set(_REFCLASS_^ copy)
	{
		LIME_ASSERT(copy != nullptr);
		m_NativeValue->set(copy->m_NativeValue->Width, copy->m_NativeValue->Height);
	}

	/// <summary>
	/// Sets this dimension to new values.
	/// </summary>
	/// <param name="width">New width.</param>
	/// <param name="height">New height.</param>
	void Set(_WRAPTYPE_ width, _WRAPTYPE_ height)
	{
		m_NativeValue->set(width, height);
	}

	/// <summary>
	/// Get the interpolated dimension.
	/// </summary>
	/// <param name="other">Other dimension to interpolate with.</param>
	/// <param name="d">Value between 0.0f and 1.0f. d=0 returns other, d=1 returns this, values between interpolate.</param>
	/// <returns>Interpolated dimension.</returns>
	_REFCLASS_^ GetInterpolated(_REFCLASS_^ other, float d)
	{
		LIME_ASSERT(other != nullptr);
		return gcnew _REFCLASS_(m_NativeValue->getInterpolated(*other->m_NativeValue, d));
	}

	/// <summary>
	/// Get the optimal size according to some properties.
	/// This function often used for texture dimension calculations.
	/// The function returns the next larger or smaller dimension which is a power-of-two dimension (2^n, 2^m) and/or square (Width = Height).
	/// </summary>
	/// <param name="requirePowerOfTwo">Forces the result to use only powers of two as values. Default is true.</param>
	/// <param name="requireSquare">Makes width == height in the result. Default is false.</param>
	/// <param name="larger">Choose whether the result is larger or smaller than the current dimension.
	/// If one dimension need not be changed it is kept with any value of larger. Default is true.</param>
	/// <param name="maxValue">Maximum texturesize. If value > 0 size is clamped to maxValue. Default is 0.</param>
	/// <returns>The optimal dimension under the given constraints.</returns>
	_REFCLASS_^ GetOptimalSize(bool requirePowerOfTwo, bool requireSquare, bool larger, unsigned int maxValue)
	{
		return gcnew _REFCLASS_(m_NativeValue->getOptimalSize(requirePowerOfTwo, requireSquare, larger, maxValue));
	}

	/// <summary>
	/// Get the optimal size according to some properties.
	/// This function often used for texture dimension calculations.
	/// The function returns the next larger or smaller dimension which is a power-of-two dimension (2^n, 2^m) and/or square (Width = Height).
	/// </summary>
	/// <param name="requirePowerOfTwo">Forces the result to use only powers of two as values. Default is true.</param>
	/// <param name="requireSquare">Makes width == height in the result. Default is false.</param>
	/// <param name="larger">Choose whether the result is larger or smaller than the current dimension.
	/// If one dimension need not be changed it is kept with any value of larger. Default is true.</param>
	/// <returns>The optimal dimension under the given constraints.</returns>
	_REFCLASS_^ GetOptimalSize(bool requirePowerOfTwo, bool requireSquare, bool larger)
	{
		return gcnew _REFCLASS_(m_NativeValue->getOptimalSize(requirePowerOfTwo, requireSquare, larger));
	}

	/// <summary>
	/// Get the optimal size according to some properties.
	/// This function often used for texture dimension calculations.
	/// The function returns the next larger or smaller dimension which is a power-of-two dimension (2^n, 2^m) and/or square (Width = Height).
	/// </summary>
	/// <param name="requirePowerOfTwo">Forces the result to use only powers of two as values. Default is true.</param>
	/// <param name="requireSquare">Makes width == height in the result. Default is false.</param>
	/// <returns>The optimal dimension under the given constraints.</returns>
	_REFCLASS_^ GetOptimalSize(bool requirePowerOfTwo, bool requireSquare)
	{
		return gcnew _REFCLASS_(m_NativeValue->getOptimalSize(requirePowerOfTwo, requireSquare));
	}

	/// <summary>
	/// Get the optimal size according to some properties.
	/// This function often used for texture dimension calculations.
	/// The function returns the next larger or smaller dimension which is a power-of-two dimension (2^n, 2^m) and/or square (Width = Height).
	/// </summary>
	/// <param name="requirePowerOfTwo">Forces the result to use only powers of two as values. Default is true.</param>
	/// <returns>The optimal dimension under the given constraints.</returns>
	_REFCLASS_^ GetOptimalSize(bool requirePowerOfTwo)
	{
		return gcnew _REFCLASS_(m_NativeValue->getOptimalSize(requirePowerOfTwo));
	}

	/// <summary>
	/// Get the optimal size according to some properties.
	/// This function often used for texture dimension calculations.
	/// The function returns the next larger or smaller dimension which is a power-of-two dimension (2^n, 2^m) and/or square (Width = Height).
	/// </summary>
	/// <returns>The optimal dimension under the given constraints.</returns>
	_REFCLASS_^ GetOptimalSize()
	{
		return gcnew _REFCLASS_(m_NativeValue->getOptimalSize());
	}

	/// <summary>
	/// Inflates width and height by given values.
	/// </summary>
	/// <param name="width">Value to inflate width by.</param>
	/// <param name="height">Value to inflate height by.</param>
	void Inflate(_WRAPTYPE_ width, _WRAPTYPE_ height)
	{
		m_NativeValue->Width += width;
		m_NativeValue->Height += height;
	}

	/// <summary>
	/// Area of the dimension (width x height).
	/// </summary>
	property _WRAPTYPE_ Area
	{
		_WRAPTYPE_ get() { return m_NativeValue->getArea(); }
	}

	/// <summary>
	/// Width of the dimension.
	/// </summary>
	property _WRAPTYPE_ Width
	{
		_WRAPTYPE_ get() { return m_NativeValue->Width; }
		void set(_WRAPTYPE_ value) { m_NativeValue->Width = value; }
	}

	/// <summary>
	/// Height of the dimension.
	/// </summary>
	property _WRAPTYPE_ Height
	{
		_WRAPTYPE_ get() { return m_NativeValue->Height; }
		void set(_WRAPTYPE_ value) { m_NativeValue->Height = value; }
	}

	virtual String^ ToString() override
	{
		return String::Format("{0} x {1}", Width, Height);
	}

internal:

	_REFCLASS_(const _WRAPCLASS_& value)
		: Lime::NativeValue<_WRAPCLASS_>(true)
	{
		m_NativeValue = new _WRAPCLASS_(value);
	}
