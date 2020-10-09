#if !defined(_REFCLASS_) || !defined(_WRAPCLASS_)
#error _REFCLASS_ and _WRAPCLASS_ must be defined for this file to process.
#endif

public:

	/// <summary>
	/// Default constructor.
	/// Data is not initialized.
	/// </summary>
	_REFCLASS_()
		: Lime::NativeValue<_WRAPCLASS_>(true)
	{
		m_NativeValue = new _WRAPCLASS_();
	}

	/// <summary>
	/// Copy constructor.
	/// </summary>
	_REFCLASS_(_REFCLASS_^ copy)
		: Lime::NativeValue<_WRAPCLASS_>(true)
	{
		LIME_ASSERT(copy != nullptr);
		m_NativeValue = new _WRAPCLASS_(*copy->m_NativeValue);
	}

	/// <summary>
	/// Get interpolated vertex from other (d=0) to this (d=1) vertex.
	/// </summary>
	_REFCLASS_^ GetInterpolated(_REFCLASS_^ other, float d)
	{
		LIME_ASSERT(other != nullptr);
		LIME_ASSERT(d >= 0.0f && d <= 1.0f);

		return gcnew _REFCLASS_(m_NativeValue->getInterpolated(*other->m_NativeValue, d));
	}

	/// <summary>
	/// Position.
	/// </summary>
	property Vector3Df^ Position
	{
		Vector3Df^ get()
		{
			return gcnew Vector3Df(m_NativeValue->Pos);
		}
		void set(Vector3Df^ value)
		{
			LIME_ASSERT(value != nullptr);
			m_NativeValue->Pos = *value->m_NativeValue;
		}
	}

	/// <summary>
	/// Normal vector.
	/// </summary>
	property Vector3Df^ Normal
	{
		Vector3Df^ get()
		{
			return gcnew Vector3Df(m_NativeValue->Normal);
		}
		void set(Vector3Df^ value)
		{
			LIME_ASSERT(value != nullptr);
			m_NativeValue->Normal = *value->m_NativeValue;
		}
	}

	/// <summary>
	/// Color.
	/// </summary>
	property Video::Color^ Color
	{
		Video::Color^ get()
		{
			return gcnew Video::Color(m_NativeValue->Color);
		}
		void set(Video::Color^ value)
		{
			LIME_ASSERT(value != nullptr);
			m_NativeValue->Color = *value->m_NativeValue;
		}
	}

	/// <summary>
	/// Texture coordinates.
	/// </summary>
	property Vector2Df^ TCoords
	{
		Vector2Df^ get()
		{
			return gcnew Vector2Df(m_NativeValue->TCoords);
		}
		void set(Vector2Df^ value)
		{
			LIME_ASSERT(value != nullptr);
			m_NativeValue->TCoords = *value->m_NativeValue;
		}
	}

	/// <summary>
	/// Type of this vertex.
	/// </summary>
	property VertexType Type
	{
		VertexType get() { return (VertexType)m_NativeValue->getType(); }
	}

	virtual String^ ToString() override
	{
		return String::Format("Vertex3D: Type={0}; Position={1}", Type, Position);
	}

internal:

	_REFCLASS_(const _WRAPCLASS_& other)
		: Lime::NativeValue<_WRAPCLASS_>(true)
	{
		m_NativeValue = new _WRAPCLASS_(other);
	}
