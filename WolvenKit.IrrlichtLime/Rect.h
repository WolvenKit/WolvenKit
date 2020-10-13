#pragma once

#if defined(_REFCLASS_) || defined(_WRAPCLASS_) || defined(_WRAPTYPE_) || defined(_OTHERTYPE1_) || defined(_OTHERTYPE2_)
#error _REFCLASS_, _WRAPCLASS_, _WRAPTYPE_ , _OTHERTYPE1_ and _OTHERTYPE2_ must be undefined for this file to process.
#endif

#include "stdafx.h"

using namespace irr;
using namespace System;

namespace IrrlichtLime {
namespace Core {

#define _REFCLASS_ Recti
#define _WRAPCLASS_ core::recti
#define _WRAPTYPE_ int
#define _OTHERTYPE1_ Vector2Di
#define _OTHERTYPE2_ Dimension2Di
#include "Rect_template.h"
#undef _OTHERTYPE2_
#undef _OTHERTYPE1_
#undef _WRAPTYPE_
#undef _WRAPCLASS_
#undef _REFCLASS_

#define _REFCLASS_ Rectf
#define _WRAPCLASS_ core::rectf
#define _WRAPTYPE_ float
#define _OTHERTYPE1_ Vector2Df
#define _OTHERTYPE2_ Dimension2Df
#include "Rect_template.h"
#undef _OTHERTYPE2_
#undef _OTHERTYPE1_
#undef _WRAPTYPE_
#undef _WRAPCLASS_
#undef _REFCLASS_

#define _REFCLASS_ Rectd
#define _WRAPCLASS_ core::rect<double>
#define _WRAPTYPE_ double
#define _OTHERTYPE1_ Vector2Dd
#define _OTHERTYPE2_ Dimension2Dd
#include "Rect_template.h"
#undef _OTHERTYPE2_
#undef _OTHERTYPE1_
#undef _WRAPTYPE_
#undef _WRAPCLASS_
#undef _REFCLASS_

} // end namespace Core
} // end namespace IrrlichtLime
