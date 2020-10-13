// Copyright (C) 2002-2012 Nikolaus Gebhardt
// This file is part of the "Irrlicht Engine".
// For conditions of distribution and use, see copyright notice in irrlicht.h

#include "CAttributes.h"
#include "CAttributeImpl.h"
#include "ITexture.h"
#include "IXMLWriter.h"
#include "IVideoDriver.h"
#include "debug.h"

#ifndef _IRR_COMPILE_WITH_XML_
	#include "CXMLReader.h"	// for noXML
#endif

namespace irr
{
namespace io
{

CAttributes::CAttributes(video::IVideoDriver* driver)
: Driver(driver)
{
	#ifdef _DEBUG
	setDebugName("CAttributes");
	#endif

	if (Driver)
		Driver->grab();
}

CAttributes::~CAttributes()
{
	clear();

	if (Driver)
		Driver->drop();
}


//! Removes all attributes
void CAttributes::clear()
{
	for (u32 i=0; i<Attributes.size(); ++i)
		Attributes[i]->drop();

	Attributes.clear();
}


//! Sets a string attribute.
//! \param attributeName: Name for the attribute
//! \param value: Value for the attribute. Set this to 0 to delete the attribute
void CAttributes::setAttribute(const c8* attributeName, const c8* value)
{
	for (u32 i=0; i<Attributes.size(); ++i)
		if (Attributes[i]->Name == attributeName)
		{
			if (!value)
			{
				Attributes[i]->drop();
				Attributes.erase(i);
			}
			else
				Attributes[i]->setString(value);

			return;
		}

	if (value)
	{
		Attributes.push_back(DBG_NEW CStringAttribute(attributeName, value));
	}
}

//! Gets a string attribute.
//! \param attributeName: Name of the attribute to get.
//! \return Returns value of the attribute previously set by setStringAttribute()
//! or 0 if attribute is not set.
core::stringc CAttributes::getAttributeAsString(const c8* attributeName, const core::stringc& defaultNotFound) const
{
	IAttribute* att = getAttributeP(attributeName);
	if (att)
		return att->getString();
	else
		return defaultNotFound;
}

//! Gets a string attribute.
//! \param attributeName: Name of the attribute to get.
//! \param target: Buffer where the string is copied to.
void CAttributes::getAttributeAsString(const c8* attributeName, char* target) const
{
	IAttribute* att = getAttributeP(attributeName);
	if (att)
	{
		core::stringc str = att->getString();
		strcpy(target,str.c_str());
	}
	else
		target[0] = 0;
}

//! Returns string attribute value by index.
//! \param index: Index value, must be between 0 and getAttributeCount()-1.
core::stringc CAttributes::getAttributeAsString(s32 index) const
{
	core::stringc str;

	if ((u32)index < Attributes.size())
		return Attributes[index]->getString();

	return str;
}


//! Sets a string attribute.
//! \param attributeName: Name for the attribute
//! \param value: Value for the attribute. Set this to 0 to delete the attribute
void CAttributes::setAttribute(const c8* attributeName, const wchar_t* value)
{
	for (u32 i=0; i<Attributes.size(); ++i)
	{
		if (Attributes[i]->Name == attributeName)
		{
			if (!value)
			{
				Attributes[i]->drop();
				Attributes.erase(i);
			}
			else
				Attributes[i]->setString(value);

			return;
		}
	}

	if (value)
	{
		Attributes.push_back(DBG_NEW CStringAttribute(attributeName, value));
	}
}

//! Gets a string attribute.
//! \param attributeName: Name of the attribute to get.
//! \return Returns value of the attribute previously set by setStringAttribute()
//! or 0 if attribute is not set.
core::stringw CAttributes::getAttributeAsStringW(const c8* attributeName, const core::stringw& defaultNotFound) const
{
	IAttribute* att = getAttributeP(attributeName);
	if (att)
		return att->getStringW();
	else
		return defaultNotFound;
}

//! Gets a string attribute.
//! \param attributeName: Name of the attribute to get.
//! \param target: Buffer where the string is copied to.
void CAttributes::getAttributeAsStringW(const c8* attributeName, wchar_t* target) const
{
	IAttribute* att = getAttributeP(attributeName);
	if (att)
	{
		core::stringw str = att->getStringW();
		wcscpy(target,str.c_str());
	}
	else
		target[0] = 0;
}

//! Returns string attribute value by index.
//! \param index: Index value, must be between 0 and getAttributeCount()-1.
core::stringw CAttributes::getAttributeAsStringW(s32 index) const
{

	if ((u32)index < Attributes.size())
		return Attributes[index]->getStringW();
	else
		return core::stringw();
}


//! Adds an attribute as an array of wide strings
void CAttributes::addArray(const c8* attributeName, const core::array<core::stringw>& value)
{
	Attributes.push_back(DBG_NEW CStringWArrayAttribute(attributeName, value));
}

//! Sets an attribute value as an array of wide strings.
void CAttributes::setAttribute(const c8* attributeName, const core::array<core::stringw>& value)
{
	IAttribute* att = getAttributeP(attributeName);
	if (att)
		att->setArray(value);
	else
	{
		Attributes.push_back(DBG_NEW CStringWArrayAttribute(attributeName, value));
	}
}

//! Gets an attribute as an array of wide strings.
core::array<core::stringw> CAttributes::getAttributeAsArray(const c8* attributeName, const core::array<core::stringw>& defaultNotFound) const
{
	IAttribute* att = getAttributeP(attributeName);
	if (att)
		return att->getArray();
	else
		return defaultNotFound;
}

//! Returns attribute value as an array of wide strings by index.
core::array<core::stringw> CAttributes::getAttributeAsArray(s32 index) const
{
	core::array<core::stringw> ret;

	if (index >= 0 && index < (s32)Attributes.size())
		ret = Attributes[index]->getArray();

	return ret;
}

//! Sets an attribute as an array of wide strings
void CAttributes::setAttribute(s32 index, const core::array<core::stringw>& value)
{
	if (index >= 0 && index < (s32)Attributes.size() )
		Attributes[index]->setArray(value);
}




//! Returns attribute index from name, -1 if not found
s32 CAttributes::findAttribute(const c8* attributeName) const
{
	for (u32 i=0; i<Attributes.size(); ++i)
		if (Attributes[i]->Name == attributeName)
			return i;

	return -1;
}


IAttribute* CAttributes::getAttributeP(const c8* attributeName) const
{
	for (u32 i=0; i<Attributes.size(); ++i)
		if (Attributes[i]->Name == attributeName)
			return Attributes[i];

	return 0;
}


//! Sets a attribute as boolean value
void CAttributes::setAttribute(const c8* attributeName, bool value)
{
	IAttribute* att = getAttributeP(attributeName);
	if (att)
		att->setBool(value);
	else
	{
		Attributes.push_back(DBG_NEW CBoolAttribute(attributeName, value));
	}
}

//! Gets a attribute as boolean value
//! \param attributeName: Name of the attribute to get.
//! \return Returns value of the attribute previously set by setAttribute() as bool
//! or 0 if attribute is not set.
bool CAttributes::getAttributeAsBool(const c8* attributeName, bool defaultNotFound) const
{
	IAttribute* att = getAttributeP(attributeName);
	if (att)
		return att->getBool();
	else
		return defaultNotFound;
}

//! Sets a attribute as integer value
void CAttributes::setAttribute(const c8* attributeName, s32 value)
{
	IAttribute* att = getAttributeP(attributeName);
	if (att)
		att->setInt(value);
	else
	{
		Attributes.push_back(DBG_NEW CIntAttribute(attributeName, value));
	}
}

//! Gets a attribute as integer value
//! \param attributeName: Name of the attribute to get.
//! \return Returns value of the attribute previously set by setAttribute() as integer
//! or 0 if attribute is not set.
s32 CAttributes::getAttributeAsInt(const c8* attributeName, irr::s32 defaultNotFound) const
{
	IAttribute* att = getAttributeP(attributeName);
	if (att)
		return att->getInt();
	else
		return defaultNotFound;
}

//! Sets a attribute as float value
void CAttributes::setAttribute(const c8* attributeName, f32 value)
{
	IAttribute* att = getAttributeP(attributeName);
	if (att)
		att->setFloat(value);
	else
		Attributes.push_back(DBG_NEW CFloatAttribute(attributeName, value));
}

//! Gets a attribute as integer value
//! \param attributeName: Name of the attribute to get.
//! \return Returns value of the attribute previously set by setAttribute() as float value
//! or 0 if attribute is not set.
f32 CAttributes::getAttributeAsFloat(const c8* attributeName, irr::f32 defaultNotFound) const
{
	IAttribute* att = getAttributeP(attributeName);
	if (att)
		return att->getFloat();

	return defaultNotFound;
}

//! Sets a attribute as color
void CAttributes::setAttribute(const c8* attributeName, video::SColor value)
{
	IAttribute* att = getAttributeP(attributeName);
	if (att)
		att->setColor(value);
	else
		Attributes.push_back(DBG_NEW CColorAttribute(attributeName, value));
}

//! Gets an attribute as color
//! \param attributeName: Name of the attribute to get.
//! \return Returns value of the attribute previously set by setAttribute()
video::SColor CAttributes::getAttributeAsColor(const c8* attributeName, const video::SColor& defaultNotFound) const
{
	IAttribute* att = getAttributeP(attributeName);
	if (att)
		return att->getColor();
	else
		return defaultNotFound;
}

//! Sets a attribute as floating point color
void CAttributes::setAttribute(const c8* attributeName, video::SColorf value)
{
	IAttribute* att = getAttributeP(attributeName);
	if (att)
		att->setColor(value);
	else
		Attributes.push_back(DBG_NEW CColorfAttribute(attributeName, value));
}

//! Gets an attribute as floating point color
//! \param attributeName: Name of the attribute to get.
//! \return Returns value of the attribute previously set by setAttribute()
video::SColorf CAttributes::getAttributeAsColorf(const c8* attributeName, const video::SColorf& defaultNotFound) const
{
	IAttribute* att = getAttributeP(attributeName);
	if (att)
		return att->getColorf();
	else
		return defaultNotFound;
}

//! Sets a attribute as 2d position
void CAttributes::setAttribute(const c8* attributeName, const core::position2di& value)
{
	IAttribute* att = getAttributeP(attributeName);
	if (att)
		att->setPosition(value);
	else
		Attributes.push_back(DBG_NEW CPosition2DAttribute(attributeName, value));
}

//! Gets an attribute as 2d position
//! \param attributeName: Name of the attribute to get.
//! \return Returns value of the attribute previously set by setAttribute()
core::position2di CAttributes::getAttributeAsPosition2d(const c8* attributeName, const core::position2di& defaultNotFound) const
{
	IAttribute* att = getAttributeP(attributeName);
	if (att)
		return att->getPosition();
	else
		return defaultNotFound;
}

//! Sets a attribute as rectangle
void CAttributes::setAttribute(const c8* attributeName, const core::rect<s32>& value)
{
	IAttribute* att = getAttributeP(attributeName);
	if (att)
		att->setRect(value);
	else
		Attributes.push_back(DBG_NEW CRectAttribute(attributeName, value));
}

//! Gets an attribute as rectangle
//! \param attributeName: Name of the attribute to get.
//! \return Returns value of the attribute previously set by setAttribute()
core::rect<s32> CAttributes::getAttributeAsRect(const c8* attributeName, const core::rect<s32>& defaultNotFound) const
{
	IAttribute* att = getAttributeP(attributeName);
	if (att)
		return att->getRect();
	else
		return defaultNotFound;
}

//! Sets a attribute as dimension2d
void CAttributes::setAttribute(const c8* attributeName, const core::dimension2d<u32>& value)
{
	IAttribute* att = getAttributeP(attributeName);
	if (att)
		att->setDimension2d(value);
	else
		Attributes.push_back(DBG_NEW CDimension2dAttribute(attributeName, value));
}

//! Gets an attribute as dimension2d
//! \param attributeName: Name of the attribute to get.
//! \return Returns value of the attribute previously set by setAttribute()
core::dimension2d<u32> CAttributes::getAttributeAsDimension2d(const c8* attributeName, const core::dimension2d<u32>& defaultNotFound) const
{
	IAttribute* att = getAttributeP(attributeName);
	if (att)
		return att->getDimension2d();
	else
		return defaultNotFound;
}

//! Sets a attribute as vector
void CAttributes::setAttribute(const c8* attributeName, const core::vector3df& value)
{
	IAttribute* att = getAttributeP(attributeName);
	if (att)
		att->setVector(value);
	else
		Attributes.push_back(DBG_NEW CVector3DAttribute(attributeName, value));
}

//! Sets a attribute as vector
void CAttributes::setAttribute(const c8* attributeName, const core::vector2df& value)
{
	IAttribute* att = getAttributeP(attributeName);
	if (att)
		att->setVector2d(value);
	else
		Attributes.push_back(DBG_NEW CVector2DAttribute(attributeName, value));
}

//! Gets an attribute as vector
//! \param attributeName: Name of the attribute to get.
//! \return Returns value of the attribute previously set by setAttribute()
core::vector3df CAttributes::getAttributeAsVector3d(const c8* attributeName, const core::vector3df& defaultNotFound) const
{
	IAttribute* att = getAttributeP(attributeName);
	if (att)
		return att->getVector();
	else
		return defaultNotFound;
}

//! Gets an attribute as vector
core::vector2df CAttributes::getAttributeAsVector2d(const c8* attributeName, const core::vector2df& defaultNotFound) const
{
	IAttribute* att = getAttributeP(attributeName);
	if (att)
		return att->getVector2d();
	else
		return defaultNotFound;
}

//! Sets an attribute as binary data
void CAttributes::setAttribute(const c8* attributeName, void* data, s32 dataSizeInBytes )
{
	IAttribute* att = getAttributeP(attributeName);
	if (att)
		att->setBinary(data, dataSizeInBytes);
	else
		Attributes.push_back(DBG_NEW CBinaryAttribute(attributeName, data, dataSizeInBytes));
}

//! Gets an attribute as binary data
//! \param attributeName: Name of the attribute to get.
void CAttributes::getAttributeAsBinaryData(const c8* attributeName, void* outData, s32 maxSizeInBytes) const
{
	IAttribute* att = getAttributeP(attributeName);
	if (att)
		att->getBinary(outData, maxSizeInBytes);
}

//! Sets an attribute as enumeration
void CAttributes::setAttribute(const c8* attributeName, const char* enumValue, const char* const* enumerationLiterals)
{
	IAttribute* att = getAttributeP(attributeName);
	if (att)
		att->setEnum(enumValue, enumerationLiterals);
	else
		Attributes.push_back(DBG_NEW CEnumAttribute(attributeName, enumValue, enumerationLiterals));
}

//! Gets an attribute as enumeration
//! \param attributeName: Name of the attribute to get.
//! \return Returns value of the attribute previously set by setAttribute()
const char* CAttributes::getAttributeAsEnumeration(const c8* attributeName, const c8* defaultNotFound) const
{
	IAttribute* att = getAttributeP(attributeName);
	if (att)
		return att->getEnum();
	else
		return defaultNotFound;
}

//! Gets an attribute as enumeration
s32 CAttributes::getAttributeAsEnumeration(const c8* attributeName, const char* const* enumerationLiteralsToUse, s32 defaultNotFound) const
{
	IAttribute* att = getAttributeP(attributeName);

	if (enumerationLiteralsToUse && att)
	{
		const char* value = att->getEnum();
		if (value)
		{
			for (s32 i=0; enumerationLiteralsToUse[i]; ++i)
				if (!strcmp(value, enumerationLiteralsToUse[i]))
					return i;
		}
	}

	return defaultNotFound;
}

//! Gets the list of enumeration literals of an enumeration attribute
//! \param attributeName: Name of the attribute to get.
void CAttributes::getAttributeEnumerationLiteralsOfEnumeration(const c8* attributeName, core::array<core::stringc>& outLiterals) const
{
	IAttribute* att = getAttributeP(attributeName);

	if (att && att->getType() == EAT_ENUM)
		outLiterals = ((CEnumAttribute*)att)->EnumLiterals;
}

//! Sets an attribute as texture reference
void CAttributes::setAttribute(const c8* attributeName, video::ITexture* value, const io::path& filename)
{
	IAttribute* att = getAttributeP(attributeName);
	if (att)
		att->setTexture(value, filename);
	else
		Attributes.push_back(DBG_NEW CTextureAttribute(attributeName, value, Driver, filename));
}


//! Gets an attribute as texture reference
//! \param attributeName: Name of the attribute to get.
video::ITexture* CAttributes::getAttributeAsTexture(const c8* attributeName, video::ITexture* defaultNotFound) const
{
	IAttribute* att = getAttributeP(attributeName);
	if (att)
		return att->getTexture();
	else
		return defaultNotFound;
}

//! Gets an attribute as texture reference
//! \param index: Index value, must be between 0 and getAttributeCount()-1.
video::ITexture* CAttributes::getAttributeAsTexture(s32 index) const
{
	if ((u32)index < Attributes.size())
		return Attributes[index]->getTexture();
	else
		return 0;
}


//! Returns amount of string attributes set in this scene manager.
u32 CAttributes::getAttributeCount() const
{
	return Attributes.size();
}

//! Returns string attribute name by index.
//! \param index: Index value, must be between 0 and getStringAttributeCount()-1.
const c8* CAttributes::getAttributeName(s32 index) const
{
	if ((u32)index >= Attributes.size())
		return 0;

	return Attributes[index]->Name.c_str();
}

//! Returns the type of an attribute
E_ATTRIBUTE_TYPE CAttributes::getAttributeType(const c8* attributeName) const
{
	E_ATTRIBUTE_TYPE ret = EAT_UNKNOWN;

	IAttribute* att = getAttributeP(attributeName);
	if (att)
		ret = att->getType();

	return ret;
}

//! Returns attribute type by index.
//! \param index: Index value, must be between 0 and getAttributeCount()-1.
E_ATTRIBUTE_TYPE CAttributes::getAttributeType(s32 index) const
{
	if ((u32)index >= Attributes.size())
		return EAT_UNKNOWN;

	return Attributes[index]->getType();
}

//! Returns the type of an attribute
const wchar_t* CAttributes::getAttributeTypeString(const c8* attributeName, const wchar_t* defaultNotFound) const
{
	IAttribute* att = getAttributeP(attributeName);
	if (att)
		return att->getTypeString();
	else
		return defaultNotFound;
}

//! Returns attribute type string by index.
//! \param index: Index value, must be between 0 and getAttributeCount()-1.
const wchar_t* CAttributes::getAttributeTypeString(s32 index, const wchar_t* defaultNotFound) const
{
	if ((u32)index >= Attributes.size())
		return defaultNotFound;

	return Attributes[index]->getTypeString();
}

//! Gets an attribute as boolean value
//! \param index: Index value, must be between 0 and getAttributeCount()-1.
bool CAttributes::getAttributeAsBool(s32 index) const
{
	bool ret = false;

	if ((u32)index < Attributes.size())
		ret = Attributes[index]->getBool();

	return ret;
}

//! Gets an attribute as integer value
//! \param index: Index value, must be between 0 and getAttributeCount()-1.
s32 CAttributes::getAttributeAsInt(s32 index) const
{
	if ((u32)index < Attributes.size())
		return Attributes[index]->getInt();
	else
		return 0;
}

//! Gets an attribute as float value
//! \param index: Index value, must be between 0 and getAttributeCount()-1.
f32 CAttributes::getAttributeAsFloat(s32 index) const
{
	if ((u32)index < Attributes.size())
		return Attributes[index]->getFloat();
	else
		return 0.f;
}

//! Gets an attribute as color
//! \param index: Index value, must be between 0 and getAttributeCount()-1.
video::SColor CAttributes::getAttributeAsColor(s32 index) const
{
	video::SColor ret(0);

	if ((u32)index < Attributes.size())
		ret = Attributes[index]->getColor();

	return ret;
}

//! Gets an attribute as floating point color
//! \param index: Index value, must be between 0 and getAttributeCount()-1.
video::SColorf CAttributes::getAttributeAsColorf(s32 index) const
{
	if ((u32)index < Attributes.size())
		return Attributes[index]->getColorf();

	return video::SColorf();
}

//! Gets an attribute as 3d vector
//! \param index: Index value, must be between 0 and getAttributeCount()-1.
core::vector3df CAttributes::getAttributeAsVector3d(s32 index) const
{
	if ((u32)index < Attributes.size())
		return Attributes[index]->getVector();
	else
		return core::vector3df();
}

//! Gets an attribute as 2d vector
core::vector2df CAttributes::getAttributeAsVector2d(s32 index) const
{
	if ((u32)index < Attributes.size())
		return Attributes[index]->getVector2d();
	else
		return core::vector2df();
}

//! Gets an attribute as position2d
//! \param index: Index value, must be between 0 and getAttributeCount()-1.
core::position2di CAttributes::getAttributeAsPosition2d(s32 index) const
{
	if ((u32)index < Attributes.size())
		return Attributes[index]->getPosition();
	else
		return core::position2di();
}

//! Gets an attribute as rectangle
//! \param index: Index value, must be between 0 and getAttributeCount()-1.
core::rect<s32>  CAttributes::getAttributeAsRect(s32 index) const
{
	if ((u32)index < Attributes.size())
		return Attributes[index]->getRect();
	else
		return core::rect<s32>();
}

//! Gets an attribute as dimension2d
//! \param index: Index value, must be between 0 and getAttributeCount()-1.
core::dimension2d<u32>  CAttributes::getAttributeAsDimension2d(s32 index) const
{
	if ((u32)index < Attributes.size())
		return Attributes[index]->getDimension2d();
	else
		return core::dimension2d<u32>();
}


//! Gets an attribute as binary data
///! \param index: Index value, must be between 0 and getAttributeCount()-1.
void CAttributes::getAttributeAsBinaryData(s32 index, void* outData, s32 maxSizeInBytes) const
{
	if ((u32)index < Attributes.size())
		Attributes[index]->getBinary(outData, maxSizeInBytes);
}


//! Gets an attribute as enumeration
//! \param index: Index value, must be between 0 and getAttributeCount()-1.
const char* CAttributes::getAttributeAsEnumeration(s32 index) const
{
	if ((u32)index < Attributes.size())
		return Attributes[index]->getEnum();
	else
		return 0;
}


//! Gets an attribute as enumeration
//! \param index: Index value, must be between 0 and getAttributeCount()-1.
s32 CAttributes::getAttributeAsEnumeration(s32 index, const char* const* enumerationLiteralsToUse, s32 defaultNotFound) const
{
	if ((u32)index < Attributes.size())
	{
		IAttribute* att = Attributes[index];

		if (enumerationLiteralsToUse && att)
		{
			const char* value = att->getEnum();
			if (value)
			{
				for (s32 i=0; enumerationLiteralsToUse[i]; ++i)
					if (!strcmp(value, enumerationLiteralsToUse[i]))
						return i;
			}
		}
	}

	return defaultNotFound;
}

//! Gets the list of enumeration literals of an enumeration attribute
//! \param index: Index value, must be between 0 and getAttributeCount()-1.
void CAttributes::getAttributeEnumerationLiteralsOfEnumeration(s32 index, core::array<core::stringc>& outLiterals) const
{
	if ((u32)index < Attributes.size() &&
			Attributes[index]->getType() == EAT_ENUM)
		outLiterals = ((CEnumAttribute*)Attributes[index])->EnumLiterals;
}


//! Adds an attribute as integer
void CAttributes::addInt(const c8* attributeName, s32 value)
{
	Attributes.push_back(DBG_NEW CIntAttribute(attributeName, value));
}

//! Adds an attribute as float
void CAttributes::addFloat(const c8* attributeName, f32 value)
{
	Attributes.push_back(DBG_NEW CFloatAttribute(attributeName, value));
}

//! Adds an attribute as string
void CAttributes::addString(const c8* attributeName, const char* value)
{
	Attributes.push_back(DBG_NEW CStringAttribute(attributeName, value));
}

//! Adds an attribute as wchar string
void CAttributes::addString(const c8* attributeName, const wchar_t* value)
{
	Attributes.push_back(DBG_NEW CStringAttribute(attributeName, value));
}

//! Adds an attribute as bool
void CAttributes::addBool(const c8* attributeName, bool value)
{
	Attributes.push_back(DBG_NEW CBoolAttribute(attributeName, value));
}

//! Adds an attribute as enum
void CAttributes::addEnum(const c8* attributeName, const char* enumValue, const char* const* enumerationLiterals)
{
	Attributes.push_back(DBG_NEW CEnumAttribute(attributeName, enumValue, enumerationLiterals));
}

//! Adds an attribute as enum
void CAttributes::addEnum(const c8* attributeName, s32 enumValue, const char* const* enumerationLiterals)
{
	addEnum(attributeName, "", enumerationLiterals);
	Attributes.getLast()->setInt(enumValue);
}

//! Adds an attribute as color
void CAttributes::addColor(const c8* attributeName, video::SColor value)
{
	Attributes.push_back(DBG_NEW CColorAttribute(attributeName, value));
}

//! Adds an attribute as floating point color
void CAttributes::addColorf(const c8* attributeName, video::SColorf value)
{
	Attributes.push_back(DBG_NEW CColorfAttribute(attributeName, value));
}

//! Adds an attribute as 3d vector
void CAttributes::addVector3d(const c8* attributeName, const core::vector3df& value)
{
	Attributes.push_back(DBG_NEW CVector3DAttribute(attributeName, value));
}

//! Adds an attribute as 2d vector
void CAttributes::addVector2d(const c8* attributeName, const core::vector2df& value)
{
	Attributes.push_back(DBG_NEW CVector2DAttribute(attributeName, value));
}


//! Adds an attribute as 2d position
void CAttributes::addPosition2d(const c8* attributeName, const core::position2di& value)
{
	Attributes.push_back(DBG_NEW CPosition2DAttribute(attributeName, value));
}

//! Adds an attribute as rectangle
void CAttributes::addRect(const c8* attributeName, const core::rect<s32>& value)
{
	Attributes.push_back(DBG_NEW CRectAttribute(attributeName, value));
}

//! Adds an attribute as dimension2d
void CAttributes::addDimension2d(const c8* attributeName, const core::dimension2d<u32>& value)
{
	Attributes.push_back(DBG_NEW CDimension2dAttribute(attributeName, value));
}

//! Adds an attribute as binary data
void CAttributes::addBinary(const c8* attributeName, void* data, s32 dataSizeInBytes)
{
	Attributes.push_back(DBG_NEW CBinaryAttribute(attributeName, data, dataSizeInBytes));
}

//! Adds an attribute as texture reference
void CAttributes::addTexture(const c8* attributeName, video::ITexture* texture, const io::path& filename)
{
	Attributes.push_back(DBG_NEW CTextureAttribute(attributeName, texture, Driver, filename));
}

//! Returns if an attribute with a name exists
bool CAttributes::existsAttribute(const c8* attributeName) const
{
	return getAttributeP(attributeName) != 0;
}

//! Sets an attribute value as string.
//! \param attributeName: Name for the attribute
void CAttributes::setAttribute(s32 index, const c8* value)
{
	if ((u32)index < Attributes.size())
		Attributes[index]->setString(value);
}

//! Sets an attribute value as string.
//! \param attributeName: Name for the attribute
void CAttributes::setAttribute(s32 index, const wchar_t* value)
{
	if ((u32)index < Attributes.size())
		Attributes[index]->setString(value);
}

//! Sets an attribute as boolean value
void CAttributes::setAttribute(s32 index, bool value)
{
	if ((u32)index < Attributes.size())
		Attributes[index]->setBool(value);
}

//! Sets an attribute as integer value
void CAttributes::setAttribute(s32 index, s32 value)
{
	if ((u32)index < Attributes.size())
		Attributes[index]->setInt(value);
}

//! Sets a attribute as float value
void CAttributes::setAttribute(s32 index, f32 value)
{
	if ((u32)index < Attributes.size())
		Attributes[index]->setFloat(value);
}

//! Sets a attribute as color
void CAttributes::setAttribute(s32 index, video::SColor color)
{
	if ((u32)index < Attributes.size())
		Attributes[index]->setColor(color);
}

//! Sets a attribute as floating point color
void CAttributes::setAttribute(s32 index, video::SColorf color)
{
	if ((u32)index < Attributes.size())
		Attributes[index]->setColor(color);
}

//! Sets a attribute as vector
void CAttributes::setAttribute(s32 index, const core::vector3df& v)
{
	if ((u32)index < Attributes.size())
		Attributes[index]->setVector(v);
}

//! Sets a attribute as vector
void CAttributes::setAttribute(s32 index, const core::vector2df& v)
{
	if ((u32)index < Attributes.size())
		Attributes[index]->setVector2d(v);
}

//! Sets a attribute as position
void CAttributes::setAttribute(s32 index, const core::position2di& v)
{
	if ((u32)index < Attributes.size())
		Attributes[index]->setPosition(v);
}

//! Sets a attribute as rectangle
void CAttributes::setAttribute(s32 index, const core::rect<s32>& v)
{
	if ((u32)index < Attributes.size())
		Attributes[index]->setRect(v);
}

//! Sets a attribute as dimension2d
void CAttributes::setAttribute(s32 index, const core::dimension2d<u32>& v)
{
	if ((u32)index < Attributes.size())
		Attributes[index]->setDimension2d(v);
}

//! Sets an attribute as binary data
void CAttributes::setAttribute(s32 index, void* data, s32 dataSizeInBytes )
{
	if ((u32)index < Attributes.size())
		Attributes[index]->setBinary(data, dataSizeInBytes);
}


//! Sets an attribute as enumeration
void CAttributes::setAttribute(s32 index, const char* enumValue, const char* const* enumerationLiterals)
{
	if ((u32)index < Attributes.size())
		Attributes[index]->setEnum(enumValue, enumerationLiterals);
}


//! Sets an attribute as texture reference
void CAttributes::setAttribute(s32 index, video::ITexture* texture, const io::path& filename)
{
	if ((u32)index < Attributes.size())
		Attributes[index]->setTexture(texture, filename);
}


//! Adds an attribute as matrix
void CAttributes::addMatrix(const c8* attributeName, const core::matrix4& v)
{
	Attributes.push_back(DBG_NEW CMatrixAttribute(attributeName, v));
}


//! Sets an attribute as matrix
void CAttributes::setAttribute(const c8* attributeName, const core::matrix4& v)
{
	IAttribute* att = getAttributeP(attributeName);
	if (att)
		att->setMatrix(v);
	else
		Attributes.push_back(DBG_NEW CMatrixAttribute(attributeName, v));
}

//! Gets an attribute as a matrix4
core::matrix4 CAttributes::getAttributeAsMatrix(const c8* attributeName, const core::matrix4& defaultNotFound) const
{
	IAttribute* att = getAttributeP(attributeName);
	if (att)
		return att->getMatrix();
	else
		return defaultNotFound;

}

//! Gets an attribute as matrix
core::matrix4 CAttributes::getAttributeAsMatrix(s32 index) const
{
	if ((u32)index < Attributes.size())
		return Attributes[index]->getMatrix();
	else
		return core::matrix4();
}

//! Sets an attribute as matrix
void CAttributes::setAttribute(s32 index, const core::matrix4& v)
{
	if ((u32)index < Attributes.size())
		Attributes[index]->setMatrix(v);
}


//! Adds an attribute as quaternion
void CAttributes::addQuaternion(const c8* attributeName, const core::quaternion& v)
{
	Attributes.push_back(DBG_NEW CQuaternionAttribute(attributeName, v));
}


//! Sets an attribute as quaternion
void CAttributes::setAttribute(const c8* attributeName, const core::quaternion& v)
{
	IAttribute* att = getAttributeP(attributeName);
	if (att)
		att->setQuaternion(v);
	else
	{
		Attributes.push_back(DBG_NEW CQuaternionAttribute(attributeName, v));
	}
}

//! Gets an attribute as a quaternion
core::quaternion CAttributes::getAttributeAsQuaternion(const c8* attributeName, const core::quaternion& defaultNotFound) const
{
	IAttribute* att = getAttributeP(attributeName);
	if (att)
		return att->getQuaternion();
	else
		return defaultNotFound;
}

//! Gets an attribute as quaternion
core::quaternion CAttributes::getAttributeAsQuaternion(s32 index) const
{
	core::quaternion ret(0,1,0, 0);

	if (index >= 0 && index < (s32)Attributes.size())
		ret = Attributes[index]->getQuaternion();

	return ret;
}

//! Sets an attribute as quaternion
void CAttributes::setAttribute(s32 index, const core::quaternion& v)
{
if (index >= 0 && index < (s32)Attributes.size() )
		Attributes[index]->setQuaternion(v);
}

//! Adds an attribute as axis aligned bounding box
void CAttributes::addBox3d(const c8* attributeName, const core::aabbox3df& v)
{
	Attributes.push_back(DBG_NEW CBBoxAttribute(attributeName, v));
}

//! Sets an attribute as axis aligned bounding box
void CAttributes::setAttribute(const c8* attributeName, const core::aabbox3df& v)
{
	IAttribute* att = getAttributeP(attributeName);
	if (att)
		att->setBBox(v);
	else
	{
		Attributes.push_back(DBG_NEW CBBoxAttribute(attributeName, v));
	}
}

//! Gets an attribute as a axis aligned bounding box
core::aabbox3df CAttributes::getAttributeAsBox3d(const c8* attributeName, const core::aabbox3df& defaultNotFound) const
{
	IAttribute* att = getAttributeP(attributeName);
	if (att)
		return att->getBBox();
	else
		return defaultNotFound;
}

//! Gets an attribute as axis aligned bounding box
core::aabbox3df CAttributes::getAttributeAsBox3d(s32 index) const
{
	core::aabbox3df ret(0,0,0, 0,0,0);

	if (index >= 0 && index < (s32)Attributes.size())
		ret = Attributes[index]->getBBox();

	return ret;
}

//! Sets an attribute as axis aligned bounding box
void CAttributes::setAttribute(s32 index, const core::aabbox3df& v)
{
if (index >= 0 && index < (s32)Attributes.size() )
		Attributes[index]->setBBox(v);
}

//! Adds an attribute as 3d plane
void CAttributes::addPlane3d(const c8* attributeName, const core::plane3df& v)
{
	Attributes.push_back(DBG_NEW CPlaneAttribute(attributeName, v));
}

//! Sets an attribute as 3d plane
void CAttributes::setAttribute(const c8* attributeName, const core::plane3df& v)
{
	IAttribute* att = getAttributeP(attributeName);
	if (att)
		att->setPlane(v);
	else
	{
		Attributes.push_back(DBG_NEW CPlaneAttribute(attributeName, v));
	}
}

//! Gets an attribute as a 3d plane
core::plane3df CAttributes::getAttributeAsPlane3d(const c8* attributeName, const core::plane3df& defaultNotFound) const
{
	IAttribute* att = getAttributeP(attributeName);
	if (att)
		return att->getPlane();
	else
		return defaultNotFound;
}

//! Gets an attribute as 3d plane
core::plane3df CAttributes::getAttributeAsPlane3d(s32 index) const
{
	core::plane3df ret(0,0,0, 0,1,0);

	if (index >= 0 && index < (s32)Attributes.size())
		ret = Attributes[index]->getPlane();

	return ret;
}

//! Sets an attribute as 3d plane
void CAttributes::setAttribute(s32 index, const core::plane3df& v)
{
	if (index >= 0 && index < (s32)Attributes.size() )
		Attributes[index]->setPlane(v);
}

//! Adds an attribute as 3d triangle
void CAttributes::addTriangle3d(const c8* attributeName, const core::triangle3df& v)
{
	Attributes.push_back(DBG_NEW CTriangleAttribute(attributeName, v));
}

//! Sets an attribute as 3d triangle
void CAttributes::setAttribute(const c8* attributeName, const core::triangle3df& v)
{
	IAttribute* att = getAttributeP(attributeName);
	if (att)
		att->setTriangle(v);
	else
	{
		Attributes.push_back(DBG_NEW CTriangleAttribute(attributeName, v));
	}
}

//! Gets an attribute as a 3d triangle
core::triangle3df CAttributes::getAttributeAsTriangle3d(const c8* attributeName, const core::triangle3df& defaultNotFound) const
{
	IAttribute* att = getAttributeP(attributeName);
	if (att)
		return att->getTriangle();
	else
		return defaultNotFound;
}

//! Gets an attribute as 3d triangle
core::triangle3df CAttributes::getAttributeAsTriangle3d(s32 index) const
{
	core::triangle3df ret;
	ret.pointA = ret.pointB = ret.pointC = core::vector3df(0,0,0);

	if (index >= 0 && index < (s32)Attributes.size())
		ret = Attributes[index]->getTriangle();

	return ret;
}

//! Sets an attribute as 3d triangle
void CAttributes::setAttribute(s32 index, const core::triangle3df& v)
{
	if (index >= 0 && index < (s32)Attributes.size() )
		Attributes[index]->setTriangle(v);
}

//! Adds an attribute as a 2d line
void CAttributes::addLine2d(const c8* attributeName, const core::line2df& v)
{
	Attributes.push_back(DBG_NEW CLine2dAttribute(attributeName, v));
}

//! Sets an attribute as a 2d line
void CAttributes::setAttribute(const c8* attributeName, const core::line2df& v)
{
	IAttribute* att = getAttributeP(attributeName);
	if (att)
		att->setLine2d(v);
	else
	{
		Attributes.push_back(DBG_NEW CLine2dAttribute(attributeName, v));
	}
}

//! Gets an attribute as a 2d line
core::line2df CAttributes::getAttributeAsLine2d(const c8* attributeName, const core::line2df& defaultNotFound) const
{
	IAttribute* att = getAttributeP(attributeName);
	if (att)
		return att->getLine2d();
	else
		return defaultNotFound;
}

//! Gets an attribute as a 2d line
core::line2df CAttributes::getAttributeAsLine2d(s32 index) const
{
	core::line2df ret(0,0, 0,0);

	if (index >= 0 && index < (s32)Attributes.size())
		ret = Attributes[index]->getLine2d();

	return ret;
}

//! Sets an attribute as a 2d line
void CAttributes::setAttribute(s32 index, const core::line2df& v)
{
	if (index >= 0 && index < (s32)Attributes.size() )
		Attributes[index]->setLine2d(v);
}

//! Adds an attribute as a 3d line
void CAttributes::addLine3d(const c8* attributeName, const core::line3df& v)
{
	Attributes.push_back(DBG_NEW CLine3dAttribute(attributeName, v));
}

//! Sets an attribute as a 3d line
void CAttributes::setAttribute(const c8* attributeName, const core::line3df& v)
{
	IAttribute* att = getAttributeP(attributeName);
	if (att)
		att->setLine3d(v);
	else
	{
		Attributes.push_back(DBG_NEW CLine3dAttribute(attributeName, v));
	}
}

//! Gets an attribute as a 3d line
core::line3df CAttributes::getAttributeAsLine3d(const c8* attributeName, const core::line3df& defaultNotFound) const
{
	IAttribute* att = getAttributeP(attributeName);
	if (att)
		return att->getLine3d();
	else
		return defaultNotFound;
}

//! Gets an attribute as a 3d line
core::line3df CAttributes::getAttributeAsLine3d(s32 index) const
{
	core::line3df ret(0,0,0, 0,0,0);

	if (index >= 0 && index < (s32)Attributes.size())
		ret = Attributes[index]->getLine3d();

	return ret;
}

//! Sets an attribute as a 3d line
void CAttributes::setAttribute(s32 index, const core::line3df& v)
{
	if (index >= 0 && index < (s32)Attributes.size() )
		Attributes[index]->setLine3d(v);

}


//! Adds an attribute as user pointer
void CAttributes::addUserPointer(const c8* attributeName, void* userPointer)
{
	Attributes.push_back(DBG_NEW CUserPointerAttribute(attributeName, userPointer));
}

//! Sets an attribute as user pointer
void CAttributes::setAttribute(const c8* attributeName, void* userPointer)
{
	IAttribute* att = getAttributeP(attributeName);
	if (att)
		att->setUserPointer(userPointer);
	else
	{
		Attributes.push_back(DBG_NEW CUserPointerAttribute(attributeName, userPointer));
	}
}

//! Gets an attribute as user pointer
//! \param attributeName: Name of the attribute to get.
void* CAttributes::getAttributeAsUserPointer(const c8* attributeName, void* defaultNotFound) const
{
	IAttribute* att = getAttributeP(attributeName);
	if (att)
		return att->getUserPointer();
	else
		return defaultNotFound;
}

//! Gets an attribute as user pointer
//! \param index: Index value, must be between 0 and getAttributeCount()-1.
void* CAttributes::getAttributeAsUserPointer(s32 index) const
{
	void* value = 0;

	if (index >= 0 && index < (s32)Attributes.size())
        value = Attributes[index]->getUserPointer();

	return value;
}

//! Sets an attribute as user pointer
void CAttributes::setAttribute(s32 index, void* userPointer)
{
	if (index >= 0 && index < (s32)Attributes.size() )
		Attributes[index]->setUserPointer(userPointer);
}


//! Reads attributes from a xml file.
//! \param readCurrentElementOnly: If set to true, reading only works if current element has the name 'attributes'.
//! IF set to false, the first appearing list attributes are read.
bool CAttributes::read(io::IXMLReader* reader, bool readCurrentElementOnly,
					    const wchar_t* nonDefaultElementName)
{
#ifdef _IRR_COMPILE_WITH_XML_
	if (!reader)
		return false;

	clear();

	core::stringw elementName = L"attributes";
	if (nonDefaultElementName)
		elementName = nonDefaultElementName;

	if (readCurrentElementOnly)
	{
		if (elementName != reader->getNodeName())
			return false;
	}

	while(reader->read())
	{
		switch(reader->getNodeType())
		{
		case io::EXN_ELEMENT:
			readAttributeFromXML(reader);
			break;
		case io::EXN_ELEMENT_END:
			if (elementName == reader->getNodeName())
				return true;
			break;
		default:
			break;
		}
	}

	return true;
#else
	noXML();
	return false;
#endif
}


void CAttributes::readAttributeFromXML(io::IXMLReader* reader)
{
#ifdef _IRR_COMPILE_WITH_XML_
	core::stringw element = reader->getNodeName();
	core::stringc name = reader->getAttributeValue(L"name");

	if (element == L"enum")
	{
		addEnum(name.c_str(), 0, 0);
		Attributes.getLast()->setString(reader->getAttributeValue(L"value"));
	}
	else
	if (element == L"binary")
	{
		addBinary(name.c_str(), 0, 0);
		Attributes.getLast()->setString(reader->getAttributeValue(L"value"));
	}
	else
	if (element == L"color")
	{
		addColor(name.c_str(), video::SColor());
		Attributes.getLast()->setString(reader->getAttributeValue(L"value"));
	}
	else
	if (element == L"colorf")
	{
		addColorf(name.c_str(), video::SColorf());
		Attributes.getLast()->setString(reader->getAttributeValue(L"value"));
	}
	else
	if (element == L"float")
	{
		addFloat(name.c_str(), 0);
		Attributes.getLast()->setString(reader->getAttributeValue(L"value"));
	}
	else
	if (element == L"int")
	{
		addInt(name.c_str(), 0);
		Attributes.getLast()->setString(reader->getAttributeValue(L"value"));
	}
	else
	if (element == L"bool")
	{
		addBool(name.c_str(), 0);
		Attributes.getLast()->setString(reader->getAttributeValue(L"value"));
	}
	else
	if (element == L"string")
	{
		addString(name.c_str(), L"");
		Attributes.getLast()->setString(reader->getAttributeValue(L"value"));
	}
	else
	if (element == L"texture")
	{
		addTexture(name.c_str(), 0);
		Attributes.getLast()->setString(reader->getAttributeValue(L"value"));
	}
	else
	if (element == L"vector3d")
	{
		addVector3d(name.c_str(), core::vector3df());
		Attributes.getLast()->setString(reader->getAttributeValue(L"value"));
	}
	else
	if (element == L"vector2d")
	{
		addVector2d(name.c_str(), core::vector2df());
		Attributes.getLast()->setString(reader->getAttributeValue(L"value"));
	}
	else
	if (element == L"position")
	{
		addPosition2d(name.c_str(), core::position2di());
		Attributes.getLast()->setString(reader->getAttributeValue(L"value"));
	}
	else
	if (element == L"rect")
	{
		addRect(name.c_str(), core::rect<s32>());
		Attributes.getLast()->setString(reader->getAttributeValue(L"value"));
	}
	else
	if (element == L"matrix")
	{
		addMatrix(name.c_str(), core::matrix4());
		Attributes.getLast()->setString(reader->getAttributeValue(L"value"));
	}
	else
	if (element == L"quaternion")
	{
		addQuaternion(name.c_str(), core::quaternion());
		Attributes.getLast()->setString(reader->getAttributeValue(L"value"));
	}
	else
	if (element == L"box3d")
	{
		addBox3d(name.c_str(), core::aabbox3df());
		Attributes.getLast()->setString(reader->getAttributeValue(L"value"));
	}
	else
	if (element == L"plane")
	{
		addPlane3d(name.c_str(), core::plane3df());
		Attributes.getLast()->setString(reader->getAttributeValue(L"value"));
	}
	else
	if (element == L"triangle")
	{
		addTriangle3d(name.c_str(), core::triangle3df());
		Attributes.getLast()->setString(reader->getAttributeValue(L"value"));
	}
	else
	if (element == L"line2d")
	{
		addLine2d(name.c_str(), core::line2df());
		Attributes.getLast()->setString(reader->getAttributeValue(L"value"));
	}
	else
	if (element == L"line3d")
	{
		addLine3d(name.c_str(), core::line3df());
		Attributes.getLast()->setString(reader->getAttributeValue(L"value"));
	}
	else
	if (element == L"stringwarray")
	{
		core::array<core::stringw> tmpArray;

		s32 count = reader->getAttributeValueAsInt(L"count");
		s32 n=0;
		const core::stringw tmpName(L"value");
		for (; n<count; ++n)
		{
			tmpArray.push_back(reader->getAttributeValue((tmpName+core::stringw(n)).c_str()));
		}
		addArray(name.c_str(),tmpArray);
	}
	else
	if (element == L"userPointer")
	{
		// It's debatable if a pointer should be set or not, but it's more likely that adding it now would wreck user-applications.
		// Also it probably doesn't makes sense setting this to a value when it comes from file.
	}
	else
	if (element == L"dimension2d")
	{
		addDimension2d(name.c_str(), core::dimension2d<u32>());
		Attributes.getLast()->setString(reader->getAttributeValue(L"value"));
	}
#else
	noXML();
#endif
}

//! Write these attributes into a xml file
bool CAttributes::write(io::IXMLWriter* writer, bool writeXMLHeader,
						const wchar_t* nonDefaultElementName)
{
#ifdef _IRR_COMPILE_WITH_XML_
	if (!writer)
		return false;

	if (writeXMLHeader)
		writer->writeXMLHeader();

	core::stringw elementName = L"attributes";
	if (nonDefaultElementName)
		elementName = nonDefaultElementName;

	writer->writeElement(elementName.c_str(), false);
	writer->writeLineBreak();

	s32 i=0;
	for (; i<(s32)Attributes.size(); ++i)
	{
		if ( Attributes[i]->getType() == EAT_STRINGWARRAY )
		{
			core::array<core::stringw> arraynames, arrayvalues;
			core::array<core::stringw> arrayinput = Attributes[i]->getArray();

			// build arrays

			// name
			arraynames.push_back(core::stringw(L"name"));
			arrayvalues.push_back(core::stringw(Attributes[i]->Name.c_str()) );

			// count
			arraynames.push_back(core::stringw(L"count"));
			arrayvalues.push_back(core::stringw((s32)arrayinput.size()));

			// array...
			u32 n=0;
			const core::stringw tmpName(L"value");
			for (; n < arrayinput.size(); ++n)
			{
				arraynames.push_back((tmpName+core::stringw(n)).c_str());
				arrayvalues.push_back(arrayinput[n]);
			}

			// write them
			writer->writeElement( Attributes[i]->getTypeString(), true, arraynames, arrayvalues);
		}
		else
		{
			writer->writeElement(
				Attributes[i]->getTypeString(), true,
				L"name", core::stringw(Attributes[i]->Name.c_str()).c_str(),
				L"value", Attributes[i]->getStringW().c_str() );
		}

		writer->writeLineBreak();
	}

	writer->writeClosingTag(elementName.c_str());
	writer->writeLineBreak();

	return true;
#else
	noXML();
	return false;
#endif
}


} // end namespace io
} // end namespace irr

