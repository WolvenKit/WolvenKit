#if !defined(_REFCLASS_) || !defined(_WRAPCLASS_) || !defined(_WRAPTYPE_) || !defined(_OTHERTYPE1_) || !defined(_OTHERTYPE2_)
#error _REFCLASS_, _WRAPCLASS_, _WRAPTYPE_, _OTHERTYPE1_ and _OTHERTYPE2_ must be defined for this file to process.
#endif

/// <summary>
/// Rectangle template.
/// Mostly used by 2D GUI elements and for 2D drawing methods.
/// It has 2 positions instead of position and dimension and a fast method for collision detection with other rectangles and points.
/// Coordinates are (0,0) for top-left corner, and increasing to the right and to the bottom.
/// </summary>
public ref class _REFCLASS_ : Lime::NativeValue<_WRAPCLASS_>
{
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
	/// Add two rectangles.
	/// </summary>
	static _REFCLASS_^ operator + (_REFCLASS_^ v1, _OTHERTYPE1_^ v2)
	{
		LIME_ASSERT(v1 != nullptr);
		LIME_ASSERT(v2 != nullptr);

		return gcnew _REFCLASS_((*v1->m_NativeValue) + (*v2->m_NativeValue));
	}

	/// <summary>
	/// Subtract one rectangle from another.
	/// </summary>
	static _REFCLASS_^ operator - (_REFCLASS_^ v1, _OTHERTYPE1_^ v2)
	{
		LIME_ASSERT(v1 != nullptr);
		LIME_ASSERT(v2 != nullptr);

		return gcnew _REFCLASS_((*v1->m_NativeValue) - (*v2->m_NativeValue));
	}

	/// <summary>
	/// Default constructor creating empty rectangle at (0, 0).
	/// </summary>
	_REFCLASS_()
		: Lime::NativeValue<_WRAPCLASS_>(true)
	{
		m_NativeValue = new _WRAPCLASS_();
	}

	/// <summary>
	/// Constructor with two corners.
	/// </summary>
	_REFCLASS_(_WRAPTYPE_ x1, _WRAPTYPE_ y1, _WRAPTYPE_ x2, _WRAPTYPE_ y2)
		: Lime::NativeValue<_WRAPCLASS_>(true)
	{
		m_NativeValue = new _WRAPCLASS_(x1, y1, x2, y2);
	}

	/// <summary>
	/// Constructor with two corners.
	/// </summary>
	_REFCLASS_(_OTHERTYPE1_^ upperLeft, _OTHERTYPE1_^ lowerRight)
		: Lime::NativeValue<_WRAPCLASS_>(true)
	{
		LIME_ASSERT(upperLeft != nullptr);
		LIME_ASSERT(lowerRight != nullptr);

		m_NativeValue = new _WRAPCLASS_(*upperLeft->m_NativeValue, *lowerRight->m_NativeValue);
	}

	/// <summary>
	/// Constructor with upper left corner and dimension.
	/// </summary>
	_REFCLASS_(_OTHERTYPE1_^ pos, _OTHERTYPE2_^ size)
		: Lime::NativeValue<_WRAPCLASS_>(true)
	{
		LIME_ASSERT(pos != nullptr);
		LIME_ASSERT(size != nullptr);
		LIME_ASSERT(size->Width >= 0);
		LIME_ASSERT(size->Height >= 0);

		m_NativeValue = new _WRAPCLASS_(*pos->m_NativeValue, *size->m_NativeValue);
	}

	/// <summary>
	/// If the lower right corner of the rect is smaller then the upper left, the points are swapped.
	/// </summary>
	void Repair()
	{
		m_NativeValue->repair();
	}

	/// <summary>
	/// Adds a point to the bounding rectangle.
	/// Causes the rectangle to grow bigger if point is outside of the box.
	/// </summary>
	void AddInternalPoint(_WRAPTYPE_ x, _WRAPTYPE_ y)
	{
		m_NativeValue->addInternalPoint(x, y);
	}

	/// <summary>
	/// Adds a point to the bounding rectangle.
	/// Causes the rectangle to grow bigger if point is outside of the box.
	/// </summary>
	void AddInternalPoint(_OTHERTYPE1_^ point)
	{
		LIME_ASSERT(point != nullptr);
		m_NativeValue->addInternalPoint(*point->m_NativeValue);
	}

	/// <summary>
	/// Moves each corner coordinate of the rectagle by given amount.
	/// </summary>
	void Adjust(_WRAPTYPE_ x1, _WRAPTYPE_ y1, _WRAPTYPE_ x2, _WRAPTYPE_ y2)
	{
		m_NativeValue->UpperLeftCorner.X += x1;
		m_NativeValue->UpperLeftCorner.Y += y1;
		m_NativeValue->LowerRightCorner.X += x2;
		m_NativeValue->LowerRightCorner.Y += y2;
	}

	/// <summary>
	/// Clips this rectangle with another one.
	/// </summary>
	void ClipAgainst(_REFCLASS_^ other)
	{
		LIME_ASSERT(other != nullptr);
		return m_NativeValue->clipAgainst(*other->m_NativeValue);
	}

	/// <summary>
	/// Moves this rectangle to fit inside another one.
	/// </summary>
	/// <returns>True on success, false if not possible.</returns>
	bool ConstrainTo(_REFCLASS_^ other)
	{
		LIME_ASSERT(other != nullptr);
		return m_NativeValue->constrainTo(*other->m_NativeValue);
	}

	/// <summary>
	/// Inflates rectangle by given width and height.
	/// </summary>
	void Inflate(_WRAPTYPE_ width, _WRAPTYPE_ height)
	{
		_WRAPTYPE_ w2 = width / 2;
		_WRAPTYPE_ h2 = height / 2;

		m_NativeValue->UpperLeftCorner.X -= w2;
		m_NativeValue->UpperLeftCorner.Y -= h2;
		m_NativeValue->LowerRightCorner.X += w2;
		m_NativeValue->LowerRightCorner.Y += h2;
	}

	/// <summary>
	/// Check if a point is within this rectangle.
	/// </summary>
	bool IsPointInside(_OTHERTYPE1_^ pos)
	{
		LIME_ASSERT(pos != nullptr);
		return m_NativeValue->isPointInside(*pos->m_NativeValue);
	}

	/// <summary>
	/// Check if a point is within this rectangle.
	/// </summary>
	bool IsPointInside(_WRAPTYPE_ x, _WRAPTYPE_ y)
	{
		return m_NativeValue->isPointInside(core::vector2d<_WRAPTYPE_>(x, y));
	}

	/// <summary>
	/// Check if the rectangle collides with another rectangle.
	/// </summary>
	bool IsRectCollided(_REFCLASS_^ other)
	{
		LIME_ASSERT(other != nullptr);
		return m_NativeValue->isRectCollided(*other->m_NativeValue);
	}

	/// <summary>
	/// Moves rectangle by given x and y.
	/// </summary>
	void Offset(_WRAPTYPE_ x, _WRAPTYPE_ y)
	{
		m_NativeValue->UpperLeftCorner.X += x;
		m_NativeValue->UpperLeftCorner.Y += y;
		m_NativeValue->LowerRightCorner.X += x;
		m_NativeValue->LowerRightCorner.Y += y;
	}

	/// <summary>
	/// True if the rect is valid to draw.
	/// It would be invalid if the UpperLeftCorner is lower or more right than the LowerRightCorner.
	/// </summary>
	property bool IsValid
	{
		bool get() { return m_NativeValue->isValid(); }
	}

	/// <summary>
	/// Width of the rectangle.
	/// </summary>
	property _WRAPTYPE_ Width
	{
		_WRAPTYPE_ get() { return m_NativeValue->getWidth(); }
	}

	/// <summary>
	/// Height of the rectangle.
	/// </summary>
	property _WRAPTYPE_ Height
	{
		_WRAPTYPE_ get() { return m_NativeValue->getHeight(); }
	}

	/// <summary>
	/// Area of the rectangle.
	/// </summary>
	property _WRAPTYPE_ Area
	{
		_WRAPTYPE_ get() { return m_NativeValue->getArea(); }
	}

	/// <summary>
	/// Dimensions of the rectangle.
	/// </summary>
	property _OTHERTYPE2_^ Size
	{
		_OTHERTYPE2_^ get() { return gcnew _OTHERTYPE2_(m_NativeValue->getSize()); }
	}

	/// <summary>
	/// Center of the rectangle.
	/// </summary>
	property _OTHERTYPE1_^ Center
	{
		_OTHERTYPE1_^ get() { return gcnew _OTHERTYPE1_(m_NativeValue->getCenter()); }
	}

	/// <summary>
	/// Upper left corner of the rectangle.
	/// </summary>
	property _OTHERTYPE1_^ UpperLeftCorner
	{
		_OTHERTYPE1_^ get() { return gcnew _OTHERTYPE1_(m_NativeValue->UpperLeftCorner); }
		void set(_OTHERTYPE1_^ value) { LIME_ASSERT(value != nullptr); m_NativeValue->UpperLeftCorner = *value->m_NativeValue; }
	}

	/// <summary>
	/// Lower right corner of the rectangle.
	/// </summary>
	property _OTHERTYPE1_^ LowerRightCorner
	{
		_OTHERTYPE1_^ get() { return gcnew _OTHERTYPE1_(m_NativeValue->LowerRightCorner); }
		void set(_OTHERTYPE1_^ value) { LIME_ASSERT(value != nullptr); m_NativeValue->LowerRightCorner = *value->m_NativeValue; }
	}

	virtual String^ ToString() override
	{
		return String::Format("({0}) :: ({1})", UpperLeftCorner, LowerRightCorner);
	}

internal:

	_REFCLASS_(const _WRAPCLASS_& value)
		: Lime::NativeValue<_WRAPCLASS_>(true)
	{
		m_NativeValue = new _WRAPCLASS_(value);
	}
};
