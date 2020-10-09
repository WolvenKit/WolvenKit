#if !defined(_REFCLASS_) || !defined(_WRAPCLASS_) || !defined(_WRAPTYPE_)
#error _REFCLASS_, _WRAPCLASS_ and _WRAPTYPE_ must be defined for this file to process.
#endif

public:

	// operators

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
	/// &gt; operator.
	/// </summary>
	static bool operator > (_REFCLASS_^ v1, _REFCLASS_^ v2)
	{
		LIME_ASSERT(v1 != nullptr);
		LIME_ASSERT(v2 != nullptr);

		return (*v1->m_NativeValue) > (*v2->m_NativeValue);
	}

	/// <summary>
	/// &gt;= operator.
	/// </summary>
	static bool operator >= (_REFCLASS_^ v1, _REFCLASS_^ v2)
	{
		LIME_ASSERT(v1 != nullptr);
		LIME_ASSERT(v2 != nullptr);

		return (*v1->m_NativeValue) >= (*v2->m_NativeValue);
	}

	/// <summary>
	/// &lt; operator.
	/// </summary>
	static bool operator < (_REFCLASS_^ v1, _REFCLASS_^ v2)
	{
		LIME_ASSERT(v1 != nullptr);
		LIME_ASSERT(v2 != nullptr);

		return (*v1->m_NativeValue) < (*v2->m_NativeValue);
	}

	/// <summary>
	/// &lt;= operator.
	/// </summary>
	static bool operator <= (_REFCLASS_^ v1, _REFCLASS_^ v2)
	{
		LIME_ASSERT(v1 != nullptr);
		LIME_ASSERT(v2 != nullptr);

		return (*v1->m_NativeValue) <= (*v2->m_NativeValue);
	}

	/// <summary>
	/// Add two vectors.
	/// </summary>
	static _REFCLASS_^ operator + (_REFCLASS_^ v1, _REFCLASS_^ v2)
	{
		LIME_ASSERT(v1 != nullptr);
		LIME_ASSERT(v2 != nullptr);

		return gcnew _REFCLASS_((*v1->m_NativeValue) + (*v2->m_NativeValue));
	}

	/// <summary>
	/// Add vector and scalar.
	/// </summary>
	static _REFCLASS_^ operator + (_REFCLASS_^ v1, _WRAPTYPE_ v2)
	{
		LIME_ASSERT(v1 != nullptr);
		return gcnew _REFCLASS_((*v1->m_NativeValue) + v2);
	}

	/// <summary>
	/// Subtract two vectors.
	/// </summary>
	static _REFCLASS_^ operator - (_REFCLASS_^ v1, _REFCLASS_^ v2)
	{
		LIME_ASSERT(v1 != nullptr);
		LIME_ASSERT(v2 != nullptr);

		return gcnew _REFCLASS_((*v1->m_NativeValue) - (*v2->m_NativeValue));
	}

	/// <summary>
	/// Subtract vector and scalar.
	/// </summary>
	static _REFCLASS_^ operator - (_REFCLASS_^ v1, _WRAPTYPE_ v2)
	{
		LIME_ASSERT(v1 != nullptr);
		return gcnew _REFCLASS_((*v1->m_NativeValue) - v2);
	}

	/// <summary>
	/// Negative vector.
	/// </summary>
	static _REFCLASS_^ operator - (_REFCLASS_^ v1)
	{
		LIME_ASSERT(v1 != nullptr);
		return gcnew _REFCLASS_(-(*v1->m_NativeValue));
	}


	/// <summary>
	/// Multiple two vectors.
	/// </summary>
	static _REFCLASS_^ operator * (_REFCLASS_^ v1, _REFCLASS_^ v2)
	{
		LIME_ASSERT(v1 != nullptr);
		LIME_ASSERT(v2 != nullptr);

		return gcnew _REFCLASS_((*v1->m_NativeValue) * (*v2->m_NativeValue));
	}

	/// <summary>
	/// Multiple vector and scalar.
	/// </summary>
	static _REFCLASS_^ operator * (_REFCLASS_^ v1, _WRAPTYPE_ v2)
	{
		LIME_ASSERT(v1 != nullptr);
		return gcnew _REFCLASS_((*v1->m_NativeValue) * v2);
	}

	/// <summary>
	/// Divide two vectors.
	/// </summary>
	static _REFCLASS_^ operator / (_REFCLASS_^ v1, _REFCLASS_^ v2)
	{
		LIME_ASSERT(v1 != nullptr);
		LIME_ASSERT(v2 != nullptr);

		return gcnew _REFCLASS_((*v1->m_NativeValue) / (*v2->m_NativeValue));
	}

	/// <summary>
	/// Divide vector and scalar.
	/// </summary>
	static _REFCLASS_^ operator / (_REFCLASS_^ v1, _WRAPTYPE_ v2)
	{
		LIME_ASSERT(v1 != nullptr);
		return gcnew _REFCLASS_((*v1->m_NativeValue) / v2);
	}

	// constructors

	/// <summary>
	/// Copy constructor.
	/// </summary>
	_REFCLASS_(_REFCLASS_^ copy) : Lime::NativeValue<_WRAPCLASS_>(true)
	{
		LIME_ASSERT(copy != nullptr);
		m_NativeValue = new _WRAPCLASS_(*copy->m_NativeValue);
	}

	/// <summary>
	/// Construct vector with all component same.
	/// </summary>
	_REFCLASS_(_WRAPTYPE_ all)
		: Lime::NativeValue<_WRAPCLASS_>(true)
	{
		m_NativeValue = new _WRAPCLASS_(all);
	}

	/// <summary>
	/// Default constructor. Set all components to 0.
	/// </summary>
	_REFCLASS_()
		: Lime::NativeValue<_WRAPCLASS_>(true)
	{
		m_NativeValue = new _WRAPCLASS_();
	}

	// Set()

	/// <summary>
	/// Set this vector to another one.
	/// </summary>
	void Set(_REFCLASS_^ copy)
	{
		LIME_ASSERT(copy != nullptr);
		m_NativeValue = new _WRAPCLASS_(*copy->m_NativeValue);
	}

	// other common methods

	/// <summary>
	/// Get the dot product with another vector.
	/// </summary>
	_WRAPTYPE_ DotProduct(_REFCLASS_^ other)
	{
		LIME_ASSERT(other != nullptr);
		return m_NativeValue->dotProduct(*other->m_NativeValue);
	}

	/// <summary>
	/// Check if this vector equals the other one, taking floating point rounding errors into account.
	/// </summary>
	bool EqualsTo(_REFCLASS_^ other)
	{
		LIME_ASSERT(other != nullptr);
		return m_NativeValue->equals(*other->m_NativeValue);
	}

	/// <summary>
	/// Get distance from another point.
	/// Here, the vector is interpreted as point in space.
	/// </summary>
	_WRAPTYPE_ GetDistanceFrom(_REFCLASS_^ other)
	{
		LIME_ASSERT(other != nullptr);
		return m_NativeValue->getDistanceFrom(*other->m_NativeValue);
	}

	/// <summary>
	/// Get squared distance from another point.
	/// Here, the vector is interpreted as point in space.
	/// </summary>
	_WRAPTYPE_ GetDistanceFromSQ(_REFCLASS_^ other)
	{
		LIME_ASSERT(other != nullptr);
		return m_NativeValue->getDistanceFromSQ(*other->m_NativeValue);
	}

	/// <summary>
	/// Creates an interpolated vector between this vector and another vector.
	/// </summary>
	/// <param name="other">The other vector to interpolate with.</param>
	/// <param name="d">Interpolation value between 0.0f (all the other vector) and 1.0f (all this vector).
	/// Note that this is the opposite direction of interpolation to <c>GetInterpolatedQuadratic()</c>.</param>
	/// <returns>An interpolated vector. This vector is not modified.</returns>
	_REFCLASS_^ GetInterpolated(_REFCLASS_^ other, double d)
	{
		LIME_ASSERT(other != nullptr);
		return gcnew _REFCLASS_(m_NativeValue->getInterpolated(*other->m_NativeValue, d));
	}

	/// <summary>
	/// Creates a quadratically interpolated vector between this and two other vectors.
	/// </summary>
	/// <param name="v2">Second vector to interpolate with.</param>
	/// <param name="v3">Third vector to interpolate with (maximum at 1.0f).</param>
	/// <param name="d">Interpolation value between 0.0f (all this vector) and 1.0f (all the 3rd vector).
	/// Note that this is the opposite direction of interpolation to <c>GetInterpolatedQuadratic()</c> and <c>Interpolate()</c>.</param>
	/// <returns>An interpolated vector. This vector is not modified.</returns>
	_REFCLASS_^ GetInterpolatedQuadratic(_REFCLASS_^ v2, _REFCLASS_^ v3, double d)
	{
		LIME_ASSERT(v2 != nullptr);
		LIME_ASSERT(v3 != nullptr);

		return gcnew _REFCLASS_(m_NativeValue->getInterpolated_quadratic(*v2->m_NativeValue, *v3->m_NativeValue, d));
	}

	/// <summary>
	/// Sets this vector to the linearly interpolated vector between a and b.
	/// </summary>
	/// <param name="a">First vector to interpolate with, maximum at 1.0f.</param>
	/// <param name="b">Second vector to interpolate with, maximum at 0.0f.</param>
	/// <param name="d">Interpolation value between 0.0f (all vector b) and 1.0f (all vector a).
	/// Note that this is the opposite direction of interpolation to <c>GetInterpolatedQuadratic()</c>.</param>
	/// <returns>This vector.</returns>
	_REFCLASS_^ Interpolate(_REFCLASS_^ a, _REFCLASS_^ b, double d)
	{
		LIME_ASSERT(a != nullptr);
		LIME_ASSERT(b != nullptr);

		m_NativeValue->interpolate(*a->m_NativeValue, *b->m_NativeValue, d);
		return this;
	}

	/// <summary>
	/// Check if this vector interpreted as a point is on a line between two other points.
	/// It is assumed that the point is on the line.
	/// </summary>
	/// <param name="begin">Beginning vector to compare between.</param>
	/// <param name="end">Ending vector to compare between.</param>
	/// <returns>True if this vector is between begin and end, false if not.</returns>
	bool IsBetweenPoints(_REFCLASS_^ begin, _REFCLASS_^ end)
	{
		LIME_ASSERT(begin != nullptr);
		LIME_ASSERT(end != nullptr);

		return m_NativeValue->isBetweenPoints(*begin->m_NativeValue, *end->m_NativeValue);
	}

	/// <summary>
	/// Normalizes the vector.
	/// In case of the 0 vector the result is still 0, otherwise the length of the vector will be 1.
	/// </summary>
	/// <returns>This vector after normalization.</returns>
	_REFCLASS_^ Normalize()
	{
		m_NativeValue->normalize();
		return this;
	}

	// properties

	/// <summary>
	/// Squared length of the vector.
	/// This is useful because it is much faster than <c>Length</c>.
	/// </summary>
	property _WRAPTYPE_ LengthSQ
	{
		_WRAPTYPE_ get() { return m_NativeValue->getLengthSQ(); }
	}

	/// <summary>
	/// X coordinate of the vector.
	/// </summary>
	property _WRAPTYPE_ X
	{
		_WRAPTYPE_ get() { return m_NativeValue->X; }
		void set(_WRAPTYPE_ value) { m_NativeValue->X = value; }
	}

	/// <summary>
	/// Y coordinate of the vector.
	/// </summary>
	property _WRAPTYPE_ Y
	{
		_WRAPTYPE_ get() { return m_NativeValue->Y; }
		void set(_WRAPTYPE_ value) { m_NativeValue->Y = value; }
	}

internal:

	_REFCLASS_(const _WRAPCLASS_& other)
		: Lime::NativeValue<_WRAPCLASS_>(true)
	{
		m_NativeValue = new _WRAPCLASS_(other);
	}
