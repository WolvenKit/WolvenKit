/****************************************************************************************

   Copyright (C) 2019 Autodesk, Inc.
   All rights reserved.

   Use of this software is subject to the terms of the Autodesk license agreement
   provided at the time of installation or download, or which otherwise accompanies
   this software in either electronic or hard copy form.

****************************************************************************************/

//! \file fbxiobase.h
#ifndef _FBXSDK_FILEIO_CALLBACKS_H_
#define _FBXSDK_FILEIO_CALLBACKS_H_

#include <fbxsdk/fbxsdk_def.h>
#include <fbxsdk/core/fbxclassid.h>
#include <fbxsdk/core/fbxobject.h>

#include <fbxsdk/fbxsdk_nsbegin.h>

#define FBXCALLBACK_FUNCTION(x) FbxHandle(x)
#define FBXCALLBACK_USERDATA(x) FbxHandle((void*)(x))
class FBXSDK_DLL FbxCallback : public FbxObject
{
    FBXSDK_ABSTRACT_OBJECT_DECLARE(FbxCallback, FbxObject);

public:
    enum State {
        eFailure = 0,      // The callback function failed for whatever reason
        eNotHandled = 1,   // The callback function did not handled the data
        eHandled = 2       // The callback function handled the data
    };

    /** Store an identifier of what data is processed. This is just a hint and the callback function may decide to use it or not
      * to figure out if it can handle the data.
      */
    void SetDataHint(FbxClassId pDataHint);

    /** Get the registered callback function pointer and user data.
      * \param pId Index in the Callback function list.
      * \param pFunction Callback function pointer
      * \param pUserData User data pointer associated to the callback function.
      * \return \c true if the requested data is available, \c false otherwise.
      */
    bool GetCallback(int pId, FbxHandle& pFunction, FbxHandle& pUserData);

protected:
    /** Register the callback function and user data.
    * \param pFunction Callback function address (use FBXCALLBACK_FUNCTION to cast the function pointer to an FbxHandle)
    * \param pUserData Pointer to user data passed to the Callback function (typically the owner of the function).
    * \return The index in the Callback functions list or -1 if it failed to add.
    * \remark Both parameters pointers are shared across FbxCallback objects therefore it is the caller responsability to
    *         ensure that the pointer remains valid while the object is in scope.
    * \remark Trying to re-add the same function will fail and the internal lists are left untouched.
    */
    int AddCallback(FbxHandle pFunction, FbxHandle pUserData = FBXCALLBACK_USERDATA(nullptr));

    /*****************************************************************************************************************************
    ** WARNING! Anything beyond these lines is for internal use, may not be documented and is subject to change without notice! **
    *****************************************************************************************************************************/
#ifndef DOXYGEN_SHOULD_SKIP_THIS
protected:
    FbxArray<FbxHandle>  mCallbackFunctions;
    FbxArray<FbxHandle>  mUserData;
    FbxClassId mDataHint;

    void Construct(const FbxObject* pFrom) override;
    void Destruct(bool pRecursive) override;
#endif
};

/** Callback to operate on the embedded data while it is processed.
  *
  * By default, the FbxExporter read the data to be embedded from a file on disk and the
  * FbxImporter will extract the embedded data in the FBX file to a file on disk. Passing
  * a properly initialized instance of this object to the FbxImporter and/or FbxExporter 
  * allows you to overwrite how the FBX SDK will access the embedded data if, for some
  * reason, you do not want to use this default behaviour.
  *
  * \remark This class only accepts one Read function and one Write function.
  *
  * Example of usage:
  * \code
  * class ModelImporter
  * {
  * public:
  *     ModelImporter(FbxManager* fbxManager) :
  *         m_fbxImporter(FbxImporter::Create(fbxManager, ""))
  *     {
  *         mCallback = FbxEmbeddedFileCallback::Create(fbxManager, "EmbeddedFileCallback");
  *         mCallback->RegisterReadFunction(OnEmbeddedFileRead, this);
  *     }
  *
  *     ~ModelImporter()
  *     {
  *         FbxEmbeddedFileCallback* cb = m_fbxImporter->GetEmbeddedFileReadCallback();
  *         cb->Destroy();
  *         m_fbxImporter->Destroy();
  *         m_fbxImporter = nullptr;
  *     }
  *
  *     void Import(FbxScene* fbxScene, const char* pFilename)
  *     {
  *         const bool lImportStatus = m_fbxImporter->Initialize(pFilename, -1, m_fbxImporter->GetIOSettings());
  *         if (lImportStatus)
  *         {
  *             // SetEmbeddedFileReadCallback needs to be called after Initialize() 
  *             // because the Reset() function will clear it (but before Import()).
  *             m_fbxImporter->SetEmbeddedFileReadCallback(mCallback);
  *             m_fbxImporter->Import(fbxScene);
  *         
  *             // TODO: do something with the scene
  *         }
  *     }
  *
  *     // Callback function
  *     static FbxCallback::State OnEmbeddedFileRead(void* pUserData, FbxClassId pDataHint,
  *         const char* pFileName, const void* pFileBuffer, size_t pSizeInBytes)
  *     {
  *         // we only want to process bitmaps, hence, the hint must be FbxVideo::ClassId
  *         // Any other type will be processd with the FBX SDK default behaviour.
  *         if (pDataHint != FbxVideo::ClassId)
  *             return FbxCallback::eNotHandled;
  *
  *         if (!pFileBuffer || pSizeInBytes == 0)
  *             return FbxCallback::eFailure;
  *
  *         ModelImporter* importer = reinterpret_cast<ModelImporter*>(pUserData);
  *         if (importer)
  *         {
  *             FbxString fn(pFileName);
  *             FbxSimpleMap<FbxString, FbxPair<char*, size_t>, FbxStringCompare>::Iterator it = importer->m_embeddedResources.Find(fn);
  *             if (it)
  *             {
  *                 // pFileName has already been added to the map!
  *                 return FbxCallback::eHandled;
  *             }
  *             // store the incoming bitmap buffer into our own memory space.
  *             const char* bufferSrc = (const char*)(pFileBuffer);
  *             char* bufferDst = (char*)FbxMalloc(pSizeInBytes);
  *             FbxPair<char*, size_t> item(bufferDst, pSizeInBytes);
  *
  *             memcpy(bufferDst, bufferSrc, pSizeInBytes);
  *
  *             importer->m_embeddedResources.Add(fn, item);
  *             return FbxCallback::eHandled;
  *         }
  *
  *         return FbxCallback::eFailure;
  *     }
  *
  * public:
  *     FbxSimpleMap<FbxString, FbxPair<char*, size_t>, FbxStringCompare> m_embeddedResources;
  *
  * private:
  *     FbxImporter* m_fbxImporter;
  *     FbxEmbeddedFileCallback* mCallback;
  * };
  *
  * ModelImporter* modelImporter = FbxNew<ModelImporter>(lSdkManager);
  * modelImporter->Import(lScene, lFilePath.Buffer());
  * FbxDelete<ModelImporter>(modelImporter);
  * \endcode
  */
class FBXSDK_DLL FbxEmbeddedFileCallback : public FbxCallback
{
    FBXSDK_OBJECT_DECLARE(FbxEmbeddedFileCallback, FbxCallback);

public:
    /** The read callback function prototype.
      * The read callback function is called while reading an FBX file, with embedded data, into memory.
      * \param pUserData Pointer to the callback owner.
      * \param pDataHint Hint describing what data object is processed.
      * \param pFileName Original file path of the embedded file.
      * \param pFileBuffer Pointer to the data of the embedded file.
      * \param pSizeInBytes Size of the file buffer.
      * \return \c eHandled if the function processed the incoming data.
      * \return \c eNotHandled if the function does not want to process the data (based on the hint).
      * \return \c eFailure in case of any error that prevents the function to successfully process the data.
      */
    typedef FbxCallback::State (*ReadCBFunction)(void* pUserData, FbxClassId pDataHint,
        const char* pFileName, const void* pFileBuffer, size_t pSizeInBytes);

    /** Register the Read callback function.
      * \param pFunction The callback function.
      * \param pUserData Pointer to the callback owner.
      * \return The index in the Callback functions list or -1 if it failed to register.
      * \remark If a function is already registered, \c pFunction will take its place.
      * \remark If \c pFunction is null, the function will fail.
      */
    int RegisterReadFunction(ReadCBFunction pFunction, void* pUserData = nullptr);

    /** Call the registered Read callback function passing the appropriated arguments.
      * Just before calling this function, the FBX SDK sets the DataHint with the classId of the processed object
      * (typically an FbxVideo or FbxAudio ClassId). This trigger is called when extracting embedded data from the FBX file.
      * \return The \c ReadCBFunction return value or \c eFailure if the callback function has not been set in this object.
      * \remark If the \c ReadCBFunction returns eNotHandled, the FBX SDK will behave the same as if no callback is
      *         specified and extracts the embedded data to a file on disk.
      */
    FbxCallback::State Trigger(const char* pFileName, const void* pFileBuffer, size_t pSizeInBytes);

    /** The write callback function prototype.
      * The write callback function is called during the write of an FBX file to disk to read the data to be embedded.
      * \param pUserData Pointer to the callback owner.
      * \param pDataHint Hint describing what data object is processed.
      * \param pFileName File path of the external file from which we retrieve the data to fill pFileBuffer.
      * \param pFileBuffer Buffer filled with data from \c pFileName.
      * \param pSizeInBytes Size of the buffer.
      * \return \c eHandled if the function processed the incoming data.
      * \return \c eNotHandled if the function does not want to process the data (based on the hint).
      * \return \c eFailure in case of any error that prevents the function to successfully process the data.
      * \remarks In the case that the \c pFileBuffer is allocated inside this function, it must be freed by the client after the FBX export
      *          process is completed. Since the client provides this function he also knows what memory allocator is used and will need 
      *          to call the appropriate memory free function.
      */
    typedef FbxCallback::State (*WriteCBFunction)(void* pUserData, FbxClassId pDataHint,
        const char* pFileName, const void** pFileBuffer, size_t* pSizeInBytes);

    /** Register the Write callback function.
      * \param pFunction The callback function.
      * \param pUserData Pointer to the callback owner.
      * \return The index in the Callback functions list or -1 if it failed to register.
      * \remark If a function is already registered, \c pFunction will take its place.
      * \remark If \c pFunction is null, the function will fail.
      */
    int RegisterWriteFunction(WriteCBFunction pFunction, void* pUserData = nullptr);

    /** Call the registered Write callback function passing the appropriated arguments.
      * Just before calling this function, the FBX SDK sets the DataHint with the classId of the container object
      * (for example, an FbxVideo for a bitmap buffer). This trigger is called when embedding data to an FBX file.
      * \return The \c WriteCBFunction return value or \c eFailure if the callback function has not been set in this object.
      * \remark If the \c WriteCBFunction returns eNotHandled, the FBX SDK will behave the same as if no callback is
      *         specified and reads the data to embed from the file on disk.
      */
    FbxCallback::State Trigger(const char* pFileName, const void** pFileBuffer, size_t* pSizeInBytes);

    /*****************************************************************************************************************************
    ** WARNING! Anything beyond these lines is for internal use, may not be documented and is subject to change without notice! **
    *****************************************************************************************************************************/
#ifndef DOXYGEN_SHOULD_SKIP_THIS
protected:
    void Construct(const FbxObject* pFrom) override;
private:
    int mReadFctId;
    int mWriteFctId;
public:
    FbxObject& Copy(const FbxObject& pObject) override;
#endif
};

#include <fbxsdk/fbxsdk_nsend.h>

#endif /* _FBXSDK_FILEIO_CALLBACKS_H_ */
