/****************************************************************************************
 
   Copyright (C) 2019 Autodesk, Inc.
   All rights reserved.
 
   Use of this software is subject to the terms of the Autodesk license agreement
   provided at the time of installation or download, or which otherwise accompanies
   this software in either electronic or hard copy form.
 
****************************************************************************************/

//! \file fbxwriterfbx7.h
#ifndef _FBXSDK_FILEIO_FBX_WRITER_FBX7_H_
#define _FBXSDK_FILEIO_FBX_WRITER_FBX7_H_

#include <fbxsdk.h>

#include <fbxsdk/fbxsdk_nsbegin.h>

struct FbxWriterFbx7_Impl;

class FbxWriterFbx7 : public FbxWriter
{
public:
    typedef enum
    {
        eASCII,
        eBINARY,
        eENCRYPTED
    } EExportMode;

    FbxWriterFbx7(FbxManager& pManager, FbxExporter& pExporter, int pID, FbxStatus& pStatus);
    FbxWriterFbx7(FbxManager& pManager, FbxExporter& pExporter, EExportMode pMode, int pID, FbxStatus& pStatus);
    virtual ~FbxWriterFbx7();

    bool FileCreate(char* pFileName) override;
    bool FileCreate(FbxStream* pStream, void* pStreamData) override;
    bool FileClose() override;
    bool IsFileOpen() override;

    void GetWriteOptions() override;
    bool Write(FbxDocument* pDocument) override;
    bool PreprocessScene(FbxScene &pScene) override;
    bool PostprocessScene(FbxScene &pScene) override;
    virtual bool Write(FbxDocument* pDocument, FbxIO* pFbx);
#ifndef FBXSDK_ENV_WINSTORE
	void PluginWriteParameters(FbxObject& pParams) override;
#endif // FBXSDK_ENV_WINSTORE
    void SetProgressHandler(FbxProgress *pProgress) override;
    void SetEmbeddedFileCallback(FbxEmbeddedFileCallback* pCallback) override;
    void SetExportMode(EExportMode pMode);

	bool SupportsStreams() const  override		{ return true; }

private:
    // Declared, not defined.
    FbxWriterFbx7(const FbxWriterFbx7&);
    FbxWriterFbx7& operator=(const FbxWriterFbx7&);

    struct ModifiedPropertyInfo{ FbxObject* mObj; FbxString mPropName; };
    FbxArray<ModifiedPropertyInfo*> mModifiedProperties;
	void StoreUnsupportedProperty(FbxObject* pObject, FbxProperty& pProperty);

	void MakeNonSavableAndRemember(FbxObject* pObj);
	FbxArray<FbxObject*> mSwitchedToNonSavablesObjects;
	FbxArray<FbxAnimLayer*> mAnimLayerInternallyAdded;

private:
    FbxWriterFbx7_Impl* mImpl;
};

#include <fbxsdk/fbxsdk_nsend.h>

#endif /* _FBXSDK_FILEIO_FBX_WRITER_FBX7_H_ */
