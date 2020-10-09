#include "stdafx.h"
#include "Attributes.h"
#include "ReferenceCounted.h"
#include "Texture.h"

using namespace irr;
using namespace System;
using namespace IrrlichtLime::Core;

namespace IrrlichtLime {
namespace IO {

AttributeType Attributes::GetAttributeTypeFromValue(Object^ value)
{
	LIME_ASSERT(value != nullptr);
	
	Type^ t = value->GetType();
	if (t == int::typeid) return AttributeType::Int;
	else if (t == float::typeid) return AttributeType::Float;
	else if (t == String::typeid) return AttributeType::String;
	else if (t == bool::typeid) return AttributeType::Bool;
	else if (t->IsEnum) return AttributeType::Enum;
	else if (t == Video::Color::typeid) return AttributeType::Color;
	else if (t == Vector3Df::typeid) return AttributeType::Vector3Df;
	else if (t == Vector2Di::typeid) return AttributeType::Vector2Di;
	else if (t == Vector2Df::typeid) return AttributeType::Vector2Df;
	else if (t == Recti::typeid) return AttributeType::Recti;
	else if (t == Matrix::typeid) return AttributeType::Matrix;
	else if (t == Quaternion::typeid) return AttributeType::Quaternion;
	else if (t == AABBox::typeid) return AttributeType::AABBox;
	else if (t == Plane3Df::typeid) return AttributeType::Plane3Df;
	else if (t == Triangle3Df::typeid) return AttributeType::Triangle3Df;
	else if (t == Line3Df::typeid) return AttributeType::Line3Df;
	else if (t == array<String^>::typeid) return AttributeType::StringArray;
	else if (t == array<Byte>::typeid) return AttributeType::ByteArray;
	else if (t == Video::Texture::typeid) return AttributeType::Texture;
	else return AttributeType::Unknown;
}

Attributes^ Attributes::Wrap(io::IAttributes* ref)
{
	if (ref == nullptr)
		return nullptr;

	return gcnew Attributes(ref);
}

Attributes::Attributes(io::IAttributes* ref)
	: ReferenceCounted(ref)
{
	m_Attributes = ref;
}

void Attributes::AddValue(String^ attributeName, Object^ value)
{
	LIME_ASSERT(attributeName != nullptr);
	LIME_ASSERT(GetIndex(attributeName) == -1);
	LIME_ASSERT(GetAttributeTypeFromValue(value) != AttributeType::Unknown);

	core::stringc n = Lime::StringToStringC(attributeName);

	switch (GetAttributeTypeFromValue(value))
	{
	case AttributeType::Int:
		m_Attributes->addInt(n.c_str(), (int)value);
		return;

	case AttributeType::Float:
		m_Attributes->addFloat(n.c_str(), (float)value);
		return;

	case AttributeType::String:
		m_Attributes->addString(n.c_str(), LIME_SAFESTRINGTOSTRINGW_C_STR((String^)value));
		return;

	case AttributeType::Bool:
		m_Attributes->addBool(n.c_str(), (bool)value);
		return;

	case AttributeType::Enum:
		{
			// Curretnly i disable ability to add values as enums, since i don't have clear solution for it.

			LIME_ASSERT2(
				GetAttributeTypeFromValue(value) != AttributeType::Enum,
				"Sorry but you cannot add attributes of Enum type. Please use Int instead.");

			return;

			// Code below works just fine, but there is a problem with Irrlicht' enums,
			// for example, E_MATERIAL_TYPE, which has special array sBuiltInMaterialTypeNames defined.
			// P.S.: some kind of mapping is required, OR internal Irrlicht won't be able to read values.

			/*
			LIME_ASSERT(value->GetType()->IsEnum);

			System::Array^ arr1 = Enum::GetValues(value->GetType());
			int l = arr1->Length;

			c8** arr2 = new c8*[l + 1];
			for (int i = 0; i < l; i++)
			{
				core::stringc s = Lime::StringToStringC(arr1->GetValue(i)->ToString());
				arr2[i] = new c8[s.size() + 1];
				strcpy_s(arr2[i], s.size() + 1, s.c_str());
			}
			arr2[l] = nullptr; // ending null

			core::stringc c = Lime::StringToStringC(value->ToString());
			m_Attributes->addEnum(n.c_str(), c.c_str(), arr2);

			for (int i = 0; i < l; i++)
				delete arr2[i];

			delete arr2;

			return;
			*/
		}

	case AttributeType::Color:
		m_Attributes->addColor(n.c_str(), *((Video::Color^)value)->m_NativeValue);
		return;

	case AttributeType::Colorf:
		m_Attributes->addColorf(n.c_str(), *((Video::Colorf^)value)->m_NativeValue);
		return;

	case AttributeType::Vector3Df:
		m_Attributes->addVector3d(n.c_str(), *((Vector3Df^)value)->m_NativeValue);
		return;

	case AttributeType::Vector2Di:
		m_Attributes->addPosition2d(n.c_str(), *((Vector2Di^)value)->m_NativeValue);
		return;

	case AttributeType::Vector2Df:
		m_Attributes->addVector2d(n.c_str(), *((Vector2Df^)value)->m_NativeValue);
		return;

	case AttributeType::Recti:
		m_Attributes->addRect(n.c_str(), *((Recti^)value)->m_NativeValue);
		return;

	case AttributeType::Matrix:
		m_Attributes->addMatrix(n.c_str(), *((Matrix^)value)->m_NativeValue);
		return;

	case AttributeType::Quaternion:
		m_Attributes->addQuaternion(n.c_str(), *((Quaternion^)value)->m_NativeValue);
		return;

	case AttributeType::AABBox:
		m_Attributes->addBox3d(n.c_str(), *((AABBox^)value)->m_NativeValue);
		return;

	case AttributeType::Plane3Df:
		m_Attributes->addPlane3d(n.c_str(), *((Plane3Df^)value)->m_NativeValue);
		return;

	case AttributeType::Triangle3Df:
		m_Attributes->addTriangle3d(n.c_str(), *((Triangle3Df^)value)->m_NativeValue);
		return;

	case AttributeType::Line3Df:
		m_Attributes->addLine3d(n.c_str(), *((Line3Df^)value)->m_NativeValue);
		return;

	case AttributeType::StringArray:
		{
			array<String^>^ m = (array<String^>^)value;

			core::array<core::stringw> a;
			for (int i = 0; i < m->Length; i++)
			{
				LIME_ASSERT(m[i] != nullptr);
				a.push_back(Lime::StringToStringW(m[i]));
			}

			m_Attributes->addArray(n.c_str(), a);

			return;
		}

	case AttributeType::ByteArray:
		{
			array<Byte>^ m = (array<Byte>^)value;

			unsigned char* b = new unsigned char[m->Length];
			for (int i = 0; i < m->Length; i++)
				b[i] = m[i];

			m_Attributes->addBinary(n.c_str(), b, m->Length);

			delete[] b;
			return;
		}

	case AttributeType::Texture:
		m_Attributes->addTexture(n.c_str(), ((Video::Texture^)value)->m_Texture);
		return;
	}
}

void Attributes::Clear()
{
	m_Attributes->clear();
}

bool Attributes::Exists(String^ attributeName)
{
	LIME_ASSERT(attributeName != nullptr);
	return m_Attributes->existsAttribute(LIME_SAFESTRINGTOSTRINGC_C_STR(attributeName));
}

int Attributes::GetIndex(String^ attributeName)
{
	LIME_ASSERT(attributeName != nullptr);
	return m_Attributes->findAttribute(LIME_SAFESTRINGTOSTRINGC_C_STR(attributeName));
}

String^ Attributes::GetName(int attributeIndex)
{
	LIME_ASSERT(attributeIndex >= 0 && attributeIndex < Count);
	return gcnew String(m_Attributes->getAttributeName(attributeIndex));
}

AttributeType Attributes::GetType(String^ attributeName)
{
	LIME_ASSERT(attributeName != nullptr);
	return (AttributeType)m_Attributes->getAttributeType(LIME_SAFESTRINGTOSTRINGC_C_STR(attributeName));
}

AttributeType Attributes::GetType(int attributeIndex)
{
	LIME_ASSERT(attributeIndex >= 0 && attributeIndex < Count);
	return (AttributeType)m_Attributes->getAttributeType(attributeIndex);
}

String^ Attributes::GetTypeString(String^ attributeName)
{
	LIME_ASSERT(attributeName != nullptr);
	return gcnew String(m_Attributes->getAttributeTypeString(LIME_SAFESTRINGTOSTRINGC_C_STR(attributeName)));
}

String^ Attributes::GetTypeString(int attributeIndex)
{
	LIME_ASSERT(attributeIndex >= 0 && attributeIndex < Count);
	return gcnew String(m_Attributes->getAttributeTypeString(attributeIndex));
}

Object^ Attributes::GetValue(String^ attributeName)
{
	LIME_ASSERT(attributeName != nullptr);
	LIME_ASSERT(GetIndex(attributeName) >= 0);
	LIME_ASSERT(GetType(attributeName) != AttributeType::Unknown);

	return GetValue(GetIndex(attributeName));
}

Object^ Attributes::GetValue(int attributeIndex)
{
	LIME_ASSERT(attributeIndex >= 0 && attributeIndex < Count);
	LIME_ASSERT(GetType(attributeIndex) != AttributeType::Unknown);

	switch (GetType(attributeIndex))
	{
	case AttributeType::Int:
		return m_Attributes->getAttributeAsInt(attributeIndex);

	case AttributeType::Float:
		return m_Attributes->getAttributeAsFloat(attributeIndex);

	case AttributeType::String:
		// !!! i read wide-string here. indeed i don't know how to check what certain string to read, since EAT_STRING used for both types :(
		return gcnew String(m_Attributes->getAttributeAsStringW(attributeIndex).c_str());

	case AttributeType::Bool:
		return m_Attributes->getAttributeAsBool(attributeIndex);

	case AttributeType::Enum:
		// i return enum as string because Enum values are read-only accessed for Lime for now
		return gcnew String(m_Attributes->getAttributeAsEnumeration(attributeIndex));

	case AttributeType::Color:
		return gcnew Video::Color(m_Attributes->getAttributeAsColor(attributeIndex));

	case AttributeType::Colorf:
		return gcnew Video::Colorf(m_Attributes->getAttributeAsColorf(attributeIndex));

	case AttributeType::Vector3Df:
		return gcnew Vector3Df(m_Attributes->getAttributeAsVector3d(attributeIndex));

	case AttributeType::Vector2Di:
		return gcnew Vector2Di(m_Attributes->getAttributeAsPosition2d(attributeIndex));

	case AttributeType::Vector2Df:
		return gcnew Vector2Df(m_Attributes->getAttributeAsVector2d(attributeIndex));

	case AttributeType::Recti:
		return gcnew Recti(m_Attributes->getAttributeAsRect(attributeIndex));

	case AttributeType::Matrix:
		return gcnew Matrix(m_Attributes->getAttributeAsMatrix(attributeIndex));

	case AttributeType::Quaternion:
		return gcnew Quaternion(m_Attributes->getAttributeAsQuaternion(attributeIndex));

	case AttributeType::AABBox:
		return gcnew AABBox(m_Attributes->getAttributeAsBox3d(attributeIndex));

	case AttributeType::Plane3Df:
		return gcnew Plane3Df(m_Attributes->getAttributeAsPlane3d(attributeIndex));

	case AttributeType::Triangle3Df:
		return gcnew Triangle3Df(m_Attributes->getAttributeAsTriangle3d(attributeIndex));

	case AttributeType::Line3Df:
		return gcnew Line3Df(m_Attributes->getAttributeAsLine3d(attributeIndex));

	case AttributeType::StringArray:
		{
			core::array<core::stringw> w = m_Attributes->getAttributeAsArray(attributeIndex);

			array<String^>^ a = gcnew array<String^>(w.size());
			for (int i = 0; i < (int)w.size(); i++)
				a[i] = gcnew String(w[i].c_str());

			return a;
		}

	case AttributeType::ByteArray:
		{
			unsigned char* b = new unsigned char[MaxByteArraySize];

			memset(b, 0, MaxByteArraySize);
			m_Attributes->getAttributeAsBinaryData(attributeIndex, b, MaxByteArraySize);

			array<Byte>^ a = gcnew array<Byte>(MaxByteArraySize);
			for (int i = 0; i < MaxByteArraySize; i++)
				a[i] = b[i];

			delete[] b;
			return a;
		}

	case AttributeType::Texture:
		return Video::Texture::Wrap(m_Attributes->getAttributeAsTexture(attributeIndex));
	}

	return nullptr;
}

void Attributes::SetValue(String^ attributeName, Object^ value)
{
	LIME_ASSERT(attributeName != nullptr);

	int i = GetIndex(attributeName);
	if (i >= 0)
	{
		SetValue(i, value);
	}
	else
	{
		AddValue(attributeName, value);
	}
}

void Attributes::SetValue(int attributeIndex, Object^ value)
{
	LIME_ASSERT(attributeIndex >= 0 && attributeIndex < Count);
	LIME_ASSERT(GetType(attributeIndex) != AttributeType::Unknown);
	LIME_ASSERT(GetType(attributeIndex) == GetAttributeTypeFromValue(value));

	switch (GetAttributeTypeFromValue(value))
	{
	case AttributeType::Int:
		m_Attributes->setAttribute(attributeIndex, (int)value);
		return;

	case AttributeType::Float:
		m_Attributes->setAttribute(attributeIndex, (float)value);
		return;

	case AttributeType::String:
		m_Attributes->setAttribute(attributeIndex, LIME_SAFESTRINGTOSTRINGW_C_STR((String^)value));
		return;

	case AttributeType::Bool:
		m_Attributes->setAttribute(attributeIndex, (bool)value);
		return;

	case AttributeType::Enum:
		{
			// Currently i disable ability to modify values of enum type, since i don't have clear solution for it.

			LIME_ASSERT2(
				GetAttributeTypeFromValue(value) != AttributeType::Enum,
				"Sorry but you cannot modify attributes of Enum type.");

			return;
		}

	case AttributeType::Color:
		m_Attributes->setAttribute(attributeIndex, *((Video::Color^)value)->m_NativeValue);
		return;

	case AttributeType::Colorf:
		m_Attributes->setAttribute(attributeIndex, *((Video::Colorf^)value)->m_NativeValue);
		return;

	case AttributeType::Vector3Df:
		m_Attributes->setAttribute(attributeIndex, *((Vector3Df^)value)->m_NativeValue);
		return;

	case AttributeType::Vector2Di:
		m_Attributes->setAttribute(attributeIndex, *((Vector2Di^)value)->m_NativeValue);
		return;

	case AttributeType::Vector2Df:
		m_Attributes->setAttribute(attributeIndex, *((Vector2Df^)value)->m_NativeValue);
		return;

	case AttributeType::Recti:
		m_Attributes->setAttribute(attributeIndex, *((Recti^)value)->m_NativeValue);
		return;

	case AttributeType::Matrix:
		m_Attributes->setAttribute(attributeIndex, *((Matrix^)value)->m_NativeValue);
		return;

	case AttributeType::Quaternion:
		m_Attributes->setAttribute(attributeIndex, *((Quaternion^)value)->m_NativeValue);
		return;

	case AttributeType::AABBox:
		m_Attributes->setAttribute(attributeIndex, *((AABBox^)value)->m_NativeValue);
		return;

	case AttributeType::Plane3Df:
		m_Attributes->setAttribute(attributeIndex, *((Plane3Df^)value)->m_NativeValue);
		return;

	case AttributeType::Triangle3Df:
		m_Attributes->setAttribute(attributeIndex, *((Triangle3Df^)value)->m_NativeValue);
		return;

	case AttributeType::Line3Df:
		m_Attributes->setAttribute(attributeIndex, *((Line3Df^)value)->m_NativeValue);
		return;

	case AttributeType::StringArray:
		{
			array<String^>^ m = (array<String^>^)value;

			core::array<core::stringw> a;
			for (int i = 0; i < m->Length; i++)
			{
				LIME_ASSERT(m[i] != nullptr);
				a.push_back(Lime::StringToStringW(m[i]));
			}

			m_Attributes->setAttribute(attributeIndex, a);

			return;
		}

	case AttributeType::ByteArray:
		{
			array<Byte>^ m = (array<Byte>^)value;

			unsigned char* b = new unsigned char[m->Length];
			for (int i = 0; i < m->Length; i++)
				b[i] = m[i];

			m_Attributes->setAttribute(attributeIndex, b, m->Length);

			delete[] b;
			return;
		}

	case AttributeType::Texture:
		m_Attributes->setAttribute(attributeIndex, ((Video::Texture^)value)->m_Texture);
		return;
	}
}

int Attributes::Count::get()
{
	return m_Attributes->getAttributeCount();
}

Dictionary<String^, Object^>^ Attributes::List::get()
{
	Dictionary<String^, Object^>^ d = gcnew Dictionary<String^, Object^>();

	for (int i = 0; i < Count; i++)
		d->Add(GetName(i), GetValue(i));

	return d;
}

String^ Attributes::ToString()
{
	return String::Format("Attributes: Count={0}", Count);
}

} // end namespace IO
} // end namespace IrrlichtLime