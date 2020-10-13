/****************************************************************************************

   Copyright (C) 2015 Autodesk, Inc.
   All rights reserved.

   Use of this software is subject to the terms of the Autodesk license agreement
   provided at the time of installation or download, or which otherwise accompanies
   this software in either electronic or hard copy form.

****************************************************************************************/

//! \file fbxhik2fbxcharacter.h
#ifndef _FBXSDK_SCENE_CONSTRAINT_HIK_TO_FBXCHARACTER_H_
#define _FBXSDK_SCENE_CONSTRAINT_HIK_TO_FBXCHARACTER_H_

#include <fbxsdk/fbxsdk_def.h>

#include <fbxsdk/scene/constraint/fbxcharacter.h>

#include <fbxsdk/fbxsdk_nsbegin.h>

class FbxCharacterPropertyInfo
{
public:
	const char*					mHIKPropertyName;
	const char*					mFbxCharacterPropertyModeName;
	const char*					mFbxCharacterPropertyName;
	int							mIndex;
	FbxCharacter::EPropertyUnit	mUnit;
};

// Changed gHIK2FbxCharacterPropertyBridge from static to extern to reduce final binary
// size. This table is ~8Kb so multiple copies in 20+ translation units soon add up.
extern FBXSDK_DLL const FbxCharacterPropertyInfo gHIK2FbxCharacterPropertyBridge[];
extern FBXSDK_DLL const size_t                   gHIK2FbxCharacterPropertyBridgeSize;

class HIK2FbxCharacterPropertyBridge
{
public:
	static inline const FbxCharacterPropertyInfo& GetAt(int i) { return gHIK2FbxCharacterPropertyBridge[i]; }

	static inline const FbxCharacterPropertyInfo* GetPropertyInfoFromFbxCharacterProperty(const char* pCharacterPropertyName)
	{
		for (int lCounter = 0; lCounter < static_cast<int>(gHIK2FbxCharacterPropertyBridgeSize); lCounter++)
		{
			if (GetAt(lCounter).mFbxCharacterPropertyName && !strcmp(GetAt(lCounter).mFbxCharacterPropertyName, pCharacterPropertyName))
			{
				return &GetAt(lCounter);
			}
		}
		return NULL;
	}

	static inline const FbxCharacterPropertyInfo* GetPropertyInfoFromHIKProperty(const char* pHIKPropertyName)
	{
		for (int lCounter = 0; lCounter < static_cast<int>(gHIK2FbxCharacterPropertyBridgeSize); lCounter++)
		{
			if (!strcmp(GetAt(lCounter).mHIKPropertyName, pHIKPropertyName))
			{
				return &GetAt(lCounter);
			}
		}
		return NULL;
	}
};

#include <fbxsdk/fbxsdk_nsend.h>

#endif /* _FBXSDK_SCENE_CONSTRAINT_HIK_TO_FBXCHARACTER_H_ */
