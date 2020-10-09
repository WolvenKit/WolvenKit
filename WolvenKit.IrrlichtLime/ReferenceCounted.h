#pragma once

#include "stdafx.h"

using namespace irr;
using namespace System;
using namespace IrrlichtLime::Core;

namespace IrrlichtLime {

/// <summary>
/// Base class of most objects of the Irrlicht Engine.
/// This class provides reference counting through the methods Grab() and Drop().
/// It also is able to store a debug string for every instance of an object.
/// Most objects of the Irrlicht Engine are derived from ReferenceCounted, and so they are reference counted.
/// <para>When you create an object in the Irrlicht engine, calling a method which starts with "Create", an object is created,
/// and you get a pointer to the new object. If you no longer need the object, you have to call Drop().
/// This will destroy the object, if Grab() was not called in another part of your program, because this part still needs the object.
/// Note, that you only need to call Drop() to the object, if you created it, and the method had a "Create" in it.</para>
/// </summary>
public ref class ReferenceCounted
{
public:

	/// <summary>
	/// Equality operator.
	/// </summary>
	static bool operator == (ReferenceCounted^ v1, ReferenceCounted^ v2);

	/// <summary>
	/// Inequality operator.
	/// </summary>
	static bool operator != (ReferenceCounted^ v1, ReferenceCounted^ v2);

	/// <summary>
	/// Drops the object. Decrements the reference counter by one.
	/// Note, that you only need to call Drop() if you created the object
	/// (e.g. you get the object by calling method with "Create" in its name).
	/// </summary>
	/// <returns>True, if the object was deleted.</returns>
	bool Drop();

	/// <summary>
	/// Grabs the object. Increments the reference counter by one.
	/// Someone who calls Grab() to an object, should later also call Drop() to it.
	/// If an object never gets as much Drop() as Grab() calls, it will never be destroyed.
	/// </summary>
	void Grab();

	/// <summary>
	/// The debug name of the object.
	/// This value may only be set and changed by the object itself.
	/// This value should only be used in Debug mode.
	/// </summary>
	property String^ DebugName { String^ get(); }

	/// <summary>
	/// Current value of the reference counter.
	/// </summary>
	property int ReferenceCount { int get(); }

internal:

	ReferenceCounted(irr::IReferenceCounted* referenceCounted_or_null);

	irr::IReferenceCounted* m_ReferenceCounted;
};

} // end namespace IrrlichtLime
