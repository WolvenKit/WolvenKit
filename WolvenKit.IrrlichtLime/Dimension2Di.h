#if !defined(_REFCLASS_) || !defined(_WRAPCLASS_) || !defined(_WRAPTYPE_)
#error _REFCLASS_, _WRAPCLASS_ and _WRAPTYPE_ must be defined for this file to process.
#endif

/// <summary>
/// Specifies a 2 dimensional size.
/// </summary>
public ref class _REFCLASS_ : Lime::NativeValue<_WRAPCLASS_>
{
#include "Dimension2D_template.h"

internal:

	_REFCLASS_(const core::dimension2du& value)
		: Lime::NativeValue<_WRAPCLASS_>(true)
	{
		LIME_ASSERT(value.Width <= 0x7fffffff);
		LIME_ASSERT(value.Height <= 0x7fffffff);

		m_NativeValue = new _WRAPCLASS_((_WRAPCLASS_&)value);
	}
};
