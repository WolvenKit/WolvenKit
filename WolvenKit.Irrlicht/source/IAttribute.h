// Copyright (C) 2002-2012 Nikolaus Gebhardt
// This file is part of the "Irrlicht Engine".
// For conditions of distribution and use, see copyright notice in irrlicht.h

#ifndef __I_ATTRIBUTE_H_INCLUDED__
#define __I_ATTRIBUTE_H_INCLUDED__

#include "IReferenceCounted.h"
#include "SColor.h"
#include "vector3d.h"
#include "vector2d.h"
#include "line2d.h"
#include "line3d.h"
#include "triangle3d.h"
#include "position2d.h"
#include "rect.h"
#include "dimension2d.h"
#include "matrix4.h"
#include "quaternion.h"
#include "plane3d.h"
#include "triangle3d.h"
#include "line2d.h"
#include "line3d.h"
#include "irrString.h"
#include "irrArray.h"
#include "EAttributes.h"


namespace irr
{
namespace io
{

// All derived attribute types implement at least getter/setter for their own type (like CBoolAttribute will have setBool/getBool).
// Simple types will also implement getStringW and setString, but don't expect it to work for all types.
// String serialization makes no sense for some attribute-types (like stringw arrays or pointers), but is still useful for many types.
// (Note: I do _not_ know yet why the default string serialization is asymmetric with char* in set and wchar_t* in get).
// Additionally many attribute types will implement conversion functions like CBoolAttribute has p.E. getInt/setInt().
// The reason for conversion functions is likely to make reading old formats easier which have changed in the meantime. For example
// an old xml can contain a bool attribute which is an int in a newer format. You can still call getInt() even thought the attribute has the wrong type.
// And please do _not_ confuse these attributes here with the ones used in the xml-reader (aka SAttribute which is just a key-value pair).

class IAttribute : public virtual IReferenceCounted
{
public:

	virtual ~IAttribute() {};

	virtual s32 getInt() const				 { return 0; }
	virtual f32 getFloat() const			 { return 0; }
	virtual video::SColorf getColorf() const { return video::SColorf(1.0f,1.0f,1.0f,1.0f); }
	virtual video::SColor getColor() const	 { return video::SColor(255,255,255,255); }
	virtual core::stringc getString() const	 { return core::stringc(getStringW().c_str()); }
	virtual core::stringw getStringW() const { return core::stringw(); }
	virtual core::array<core::stringw> getArray() const { return core::array<core::stringw>(); };
	virtual bool getBool() const			{ return false; }
	virtual void getBinary(void* outdata, s32 maxLength) const {};
	virtual core::vector3df getVector() const      { return core::vector3df(); }
	virtual core::position2di getPosition()	const  { return core::position2di(); }
	virtual core::rect<s32> getRect() const	       { return core::rect<s32>(); }
	virtual core::quaternion getQuaternion() const { return core::quaternion(); }
	virtual core::matrix4 getMatrix() const	      { return core::matrix4(); }
	virtual core::triangle3df getTriangle() const { return core::triangle3df(); }
	virtual core::vector2df getVector2d() const	  { return core::vector2df(); }
	virtual core::vector2di getVector2di() const  { return core::vector2di(); }
	virtual core::line2df getLine2d() const  { return core::line2df(); }
	virtual core::line2di getLine2di() const { return core::line2di(); }
	virtual core::line3df getLine3d() const  { return core::line3df(); }
	virtual core::line3di getLine3di() const { return core::line3di(); }
	virtual core::dimension2du getDimension2d() const { return core::dimension2du(); }
	virtual core::aabbox3d<f32> getBBox() const	{ return core::aabbox3d<f32>(); }
	virtual core::plane3df getPlane() const	    { return core::plane3df(); }

	virtual video::ITexture* getTexture() const	{ return 0; }
	virtual const char* getEnum() const	 { return 0; }
	virtual void* getUserPointer() const { return 0; }

	virtual void setInt(s32 intValue)		{};
	virtual void setFloat(f32 floatValue)		{};
	virtual void setString(const char* text)	{};
	virtual void setString(const wchar_t* text){ setString(core::stringc(text).c_str()); };
	virtual void setArray(const core::array<core::stringw>& arr )	{};
	virtual void setColor(video::SColorf color)	{};
	virtual void setColor(video::SColor color)	{};
	virtual void setBool(bool boolValue)		{};
	virtual void setBinary(void* data, s32 maxLength) {};
	virtual void setVector(const core::vector3df& v)	{};
	virtual void setPosition(const core::position2di& v)	{};
	virtual void setRect(const core::rect<s32>& v)		{};
	virtual void setQuaternion(const core::quaternion& v) {};
	virtual void setMatrix(const core::matrix4& v) {};
	virtual void setTriangle(const core::triangle3df& v) {};
	virtual void setVector2d(const core::vector2df& v) {};
	virtual void setVector2d(const core::vector2di& v) {};
	virtual void setLine2d(const core::line2df& v) {};
	virtual void setLine2d(const core::line2di& v) {};
	virtual void setLine3d(const core::line3df& v) {};
	virtual void setLine3d(const core::line3di& v) {};
	virtual void setDimension2d(const core::dimension2du& v) {};
	virtual void setBBox(const core::aabbox3d<f32>& v) {};
	virtual void setPlane(const core::plane3df& v) {};
	virtual void setUserPointer(void* v)	{};

	virtual void setEnum(const char* enumValue, const char* const* enumerationLiterals) {};
	virtual void setTexture(video::ITexture*, const path& filename)	{};

	core::stringc Name;

	virtual E_ATTRIBUTE_TYPE getType() const = 0;
	virtual const wchar_t* getTypeString() const = 0;
};

} // end namespace io
} // end namespace irr

#endif
