/****************************************************************************************
 
   Copyright (C) 2017 Autodesk, Inc.
   All rights reserved.
 
   Use of this software is subject to the terms of the Autodesk license agreement
   provided at the time of installation or download, or which otherwise accompanies
   this software in either electronic or hard copy form.
 
****************************************************************************************/

//! \file fbxarray.h
#ifndef _FBXSDK_CORE_BASE_ARRAY_H_
#define _FBXSDK_CORE_BASE_ARRAY_H_

#include <fbxsdk/fbxsdk_def.h>

#include <fbxsdk/fbxsdk_nsbegin.h>

#if defined(FBXSDK_COMPILER_MSC)
    #pragma warning( push )
    #pragma warning( disable : 4201 ) // nonstandard extension used: nameless struct/union
#endif

/** Class for array of basic elements such as pointers and basic types. This class will not
* call constructor and destructor for elements, thus it is not suitable for object references.
* Memory allocations are always done in a single contiguous memory region. */
template <class T, const int Alignment = 16> class FbxArray
{
protected:
    struct tData {
        union {
            struct {
                int    mSize;
                int    mCapacity;
            };
            char Padding[Alignment];
        };
        T    mArray[15];        //!< 15 represent only the number of items to see debug
    } *mData;
public:
    //! Element compare function pointer definition
    typedef int (*CompareFunc)(const void*, const void*);

    //! Constructor.
    FbxArray() : mData(NULL){}

    //! Reserve constructor.
    FbxArray(const int pCapacity) : mData(NULL){ if( pCapacity > 0 ) Reserve(pCapacity); }

    //! Copy constructor.
    FbxArray(const FbxArray& pArray) : mData(NULL){ *this = pArray; }

    /** Destructor.
    * \remark The destructor for each element will not be called. */
    ~FbxArray(){ Clear(); }

    /** Insert an element at the given position, growing the array if capacity is not sufficient.
    * \param pIndex Position where to insert the element. Must be a positive value.
    * \param pElement Element to insert in the array.
    * \param pCompact If \c true and capacity is exceeded, grow capacity by one, otherwise double capacity (default).
    * \return -1 if insert failed, otherwise the position of the inserted element in the array.
    * \remark If the given index is greater than Size(), the element is appended at the end. Use compact mode only if you need to save memory. */
    inline int InsertAt(const int pIndex, const T& pElement, bool pCompact=false)
    {
        FBX_ASSERT_RETURN_VALUE(pIndex >= 0, -1);
        int lIndex = FbxMin(pIndex, GetSize());
        if( GetSize() >= GetCapacity() )
        {
            T lElement = pElement;    //Copy element because we might move memory
            int lNewCapacity = FbxMax(pCompact ? GetCapacity() + 1 : GetCapacity() * 2, 1);    //We always double capacity when not compacting
            Allocate(lNewCapacity);
            FBX_ASSERT_RETURN_VALUE(mData, -1);
            mData->mCapacity = lNewCapacity;
            return InsertAt(pIndex, lElement);    //Insert copied element because reference might be moved
        }

        if( lIndex < GetSize() )    //Move elements to leave a space open to insert the new element
        {
            //If pElement is inside memmove range, copy element and insert copy instead
            if( (&pElement >= &GetArray()[lIndex]) && (&pElement < &GetArray()[GetSize()]) )
            {
                T lElement = pElement;
                return InsertAt(pIndex, lElement);
            }
            memmove(&GetArray()[lIndex + 1], &GetArray()[lIndex], (GetSize() - lIndex) * sizeof(T));
        }

        memcpy(&GetArray()[lIndex], &pElement, sizeof(T));
        mData->mSize++;

        return lIndex;
    }

    /** Append an element at the end of the array, doubling the array if capacity is not sufficient.
    * \param pElement Element to append to the array.
    * \return -1 if add failed, otherwise the position of the added element in the array. */
    inline int Add(const T& pElement)
    {
        return InsertAt(GetSize(), pElement);
    }

    /** Append an element at the end of array, if not already present, doubling the array if capacity is not sufficient.
    * \param pElement Element to append to the array.
    * \return -1 if add failed, otherwise the position of the added element in the array. */
    inline int AddUnique(const T& pElement)
    {
        int lIndex = Find(pElement);
        return ( lIndex == -1 ) ? Add(pElement) : lIndex;
    }

    /** Append an element at the end of the array, growing the array by one element if capacity is not sufficient.
    * \param pElement Element to append to the array.
    * \return -1 if add failed, otherwise the position of the added element in the array. */
    inline int AddCompact(const T& pElement)
    {
        return InsertAt(GetSize(), pElement, true);
    }

    /** Retrieve the number of element contained in the array. To increase the capacity without increasing the size, please use Reserve().
    * \return The number of element in the array.
    * \remark The size of the array cannot exceed its capacity. */
    inline int Size() const { return GetSize(); }

    /** Retrieve the current allocated memory capacity of the array.
    * \return The capacity of the array in number of element.
    * \remark The capacity will always be greater or equal to its size. */
    inline int Capacity() const { return GetCapacity(); }

    /** Retrieve a reference of the element at given index position in the array.
    * \param pIndex Position of element in the array.
    * \return A reference to the element at the specified position in the array.
    * \remark No error will be thrown if the index is out of bounds. */
    inline T& operator[](const int pIndex) const
    {
        if (pIndex < 0)
        {
            throw std::runtime_error("Index is out of range!");
        }

        if (pIndex >= GetSize())
        {
            if (pIndex < GetCapacity())
            {
                throw std::runtime_error("Index is out of range, but not outside of capacity! Call SetAt() to use reserved memory.");
            }

            throw std::runtime_error("Index is out of range!");
        }

        return GetArray()[pIndex];
    }

    /** Retrieve a copy of the element at given index position in the array.
    * \param pIndex Position of element in the array.
    * \return The value of the element at the specified position in the array.
    * \remark No error will be thrown if the index is out of bounds. */
    inline T GetAt(const int pIndex) const
    {
        return operator[](pIndex);
    }

    /** Retrieve a copy of the first element.
    * \return Copy of the first element.
    * \remark The array should have at least one element and no error will be thrown if the array is empty. */
    inline T GetFirst() const
    {
        const int size = GetSize();

        if (size <= 0)
        {
            throw std::runtime_error("FbxArray is empty");
        }

        return GetAt(0);
    }

    /** Retrieve a copy of the last element.
    * \return Copy of the last element.
    * \remark The array should have at least one element and no error will be thrown if the array is empty. */
    inline T GetLast() const
    {
        const int size = GetSize();

        if (size <= 0)
        {
            throw std::runtime_error("FbxArray is empty");
        }

        return GetAt(size - 1);
    }

    /** Find first matching element, from first to last.
    * \param pElement The element to be compared to each of the elements.
    * \param pStartIndex The position to start searching from.
    * \return Position of first matching element or -1 if there is no matching element. */
    inline int Find(const T& pElement, const int pStartIndex = 0) const
    {
        const int size = GetSize();

        FBX_ASSERT_RETURN_VALUE(pStartIndex >= 0, -1);
        FBX_ASSERT_RETURN_VALUE(size >= 0, -1);

        for (int i = pStartIndex; i < size; ++i)
        {
            if (operator[](i) == pElement) return i;
        }
        return -1;
    }

    /** Find first matching element, from last to first.
    * \param pElement The element to be compared to each of the elements.
    * \param pStartIndex The position to start searching from.
    * \return Position of first matching element or -1 if there is no matching element. */
    inline int FindReverse(const T& pElement, const int pStartIndex = FBXSDK_INT_MAX) const
    {
        const int size = GetSize();

        FBX_ASSERT_RETURN_VALUE(size > 0, -1);

        for (int i = FbxMin(pStartIndex, size - 1); i >= 0; --i)
        {
            if (operator[](i) == pElement) return i;
        }
        return -1;
    }

    /** Request for allocation of additional memory without inserting new elements. After the memory has been reserved, please use SetAt() to initialize elements.
    * \param pCapacity The number of additional element memory allocation requested.
    * \return \c true if the memory allocation succeeded or if the capacity is unchanged, \c false otherwise.
    * \remark If the requested capacity is less than or equal to the current capacity, this call has no effect. In either case, Size() is unchanged. */
    inline bool Reserve(const int pCapacity)
    {
        FBX_ASSERT_RETURN_VALUE(pCapacity > 0, false);
        if( pCapacity > GetCapacity() )
        {
            Allocate(pCapacity);
            FBX_ASSERT_RETURN_VALUE(mData, false);
            mData->mCapacity = pCapacity;

            //Initialize new memory to zero
            memset(&GetArray()[GetSize()], 0, (GetCapacity() - GetSize()) * sizeof(T));
        }
        return true;
    }

    /** Set the element at given position in the array.
    * \param pIndex Position of element in the array.
    * \param pElement The new element.
    * \remark If the index is outside range, and outside capacity, this call has no effect. However, if index is
    * within capacity range, element count is increased such that Size() will become pIndex + 1. */
    inline void SetAt(const int pIndex, const T& pElement)
    {
        FBX_ASSERT_RETURN(pIndex >= 0 && pIndex < GetCapacity());
        if( pIndex >= GetSize() ) mData->mSize = pIndex + 1;

        T* const array = GetArray();
        if (array) memcpy(&array[pIndex], &pElement, sizeof(T));
    }

    /** Set the value of the first element.
    * \param pElement The new value of the last element.
    * \remark The array should have at least one element and no error will be thrown if the array is empty. */
    inline void SetFirst(const T& pElement)
    {
        const int size = GetSize();

        if (size <= 0)
        {
            throw std::runtime_error("FbxArray is empty");
        }

        SetAt(0, pElement);
    }

    /** Set the value of the last element.
    * \param pElement The new value of the last element.
    * \remark The array should have at least one element and no error will be thrown if the array is empty. */
    inline void SetLast(const T& pElement)
    {
        const int size = GetSize();

        if (size <= 0)
        {
            throw std::runtime_error("FbxArray is empty");
        }

        SetAt(size - 1, pElement);
    }

    /** Remove an element at the given position in the array.
    * \param pIndex Position of the element to remove.
    * \return Removed element.
    * \remark No error will be thrown if the index is out of bounds. */
    inline T RemoveAt(const int pIndex)
    {
        const int size = GetSize();

        if (pIndex < 0 || pIndex >= size)
        {
            throw std::runtime_error("Index is out of range!");
        }

        T lElement = GetAt(pIndex);
        if (pIndex + 1 < size)
        {
            memmove(&GetArray()[pIndex], &GetArray()[pIndex + 1], (size - pIndex - 1) * sizeof(T));
        }
        mData->mSize--;
        return lElement;
    }

    /** Remove the first element in the array.
    * \return Removed element.
    * \remark The array should have at least one element and no error will be thrown if the array is empty. */
    inline T RemoveFirst()
    {
        const int size = GetSize();

        if (size <= 0)
        {
            throw std::runtime_error("FbxArray is empty");
        }

        return RemoveAt(0);
    }

    /** Remove the last element in the array.
    * \return Removed element.
    * \remark The array should have at least one element and no error will be thrown if the array is empty. */
    inline T RemoveLast()
    {
        const int size = GetSize();

        if (size <= 0)
        {
            throw std::runtime_error("FbxArray is empty");
        }

        return RemoveAt(size - 1);
    }

    /** Remove first matching element in the array.
    * \param pElement Element to be removed.
    * \return \c true if a matching element is found and removed, \c false otherwise. */
    inline bool RemoveIt(const T& pElement)
    {
        int Index = Find(pElement);
        if( Index >= 0 )
        {
            RemoveAt(Index);
            return true;
        }
        return false;
    }

    /** Remove a range of elements at the given position in the array.
    * \param pIndex Begin position of the elements to remove.
    * \param pCount The count of elements to remove.
    * \return \c true if successful, otherwise \c false.
    * \remark This function re-use the memory already allocated */
    inline void RemoveRange(const int pIndex, const int pCount)
    {
        const int size = GetSize();
        if (size == 0)
            // the array is already empty (or not allocated yet)
            // no point in continuing
            return;

        FBX_ASSERT(GetArray() != NULL);
        FBX_ASSERT_RETURN(pCount >  0);
        FBX_ASSERT_RETURN(pIndex >= 0);

        int lastItem = pIndex + pCount;
        FBX_ASSERT_RETURN(lastItem >= 0);
        FBX_ASSERT_RETURN(lastItem <= size);

        if (lastItem < size)
        {
            memmove(&GetArray()[pIndex], &GetArray()[pIndex + pCount], (size - pIndex - pCount) * sizeof(T));
        }

        if (mData)
        {
            mData->mSize -= pCount;
        }
    }

    /** Inserts or erases elements at the end such that Size() becomes pSize, increasing capacity if needed. Please use SetAt() to initialize any new elements.
    * \param pSize The new count of elements to set the array to. Must be greater or equal to zero.
    * \return \c true if the memory (re)allocation succeeded, \c false otherwise.
    * \remark If the requested element count is less than or equal to the current count, elements are freed from memory. Otherwise, the array grows and elements are unchanged. */
    inline bool Resize(const int pSize)
    {
        if( pSize == GetSize() && GetSize() == GetCapacity() ) return true;

        if( pSize == 0 )
        {
            Clear();
            return true;
        }

        FBX_ASSERT_RETURN_VALUE(pSize > 0, false);
        if( pSize != GetCapacity() )
        {
            Allocate(pSize);
            FBX_ASSERT_RETURN_VALUE(mData, false);
        }

        if( pSize > GetCapacity() )    //Initialize new memory to zero
        {
            memset(&GetArray()[GetSize()], 0, (pSize - GetSize()) * sizeof(T));
        }

        mData->mSize = pSize;
        mData->mCapacity = pSize;
        return true;
    }

    /** Increase size of array by the specified size.
    * \param pSize The size to add to the array size.
    * \return \c true if operation succeeded, \c false otherwise. */
    inline bool Grow(const int pSize)
    {
        const int size = GetSize();

        // Check int32 paramater does not overflow
        FbxLongLong newSize = static_cast<FbxLongLong>(size) + static_cast<FbxLongLong>(pSize);
        if (newSize > INT_MAX)
        {
            throw std::runtime_error("Grow - Int overflow!");
        }

        return Resize(size + pSize);
    }

    /** Reduce size of array by the specified size.
    * \param pSize The size to remove from the array size.
    * \return \c true if operation succeeded, \c false otherwise. */
    inline bool Shrink(const int pSize)
    {
        const int size = GetSize();

        if (pSize < 0 || size - pSize < 0)
        {
            throw std::runtime_error("Shrink - Int underflow!");
        }

        return Resize(size - pSize);
    }

    /** Compact the array so that its capacity is the same as its size.
    * \return \c true if operation succeeded, \c false otherwise. */
    inline bool Compact()
    {
        return Resize(GetSize());
    }

    /** Reset the number of element to zero and free the memory allocated.
    * \remark This only free the memory allocated by the array, and doesn't call the destructor of each element. */
    inline void Clear()
    {
        if( mData != NULL )
        {
            FbxFree(mData);
            mData = NULL;
        }
    }

    /** Sort the array using the specified compare function pointer
    * \param pCompareFunc The compare function to use to sort elements. */
    inline void Sort(CompareFunc pCompareFunc)
    {
        qsort(GetArray(), GetSize(), sizeof(T), pCompareFunc);
    }

    //! Get pointer to internal array of elements.
    inline T* GetArray() const { return mData ? &mData->mArray[0] : NULL; }

    //! Cast operator.
    inline operator T* () const { return GetArray(); }

    /** Append another array at the end of this array.
    * \param pOther The other array to append to this array. */
    inline void AddArray(const FbxArray<T>& pOther)
    {
        if( Grow(pOther.GetSize()) )
        {
            memcpy(&GetArray()[GetSize() - pOther.GetSize()], pOther.GetArray(), pOther.GetSize() * sizeof(T));
        }
    }

    /** Append the elements of another array at the end of this array if they are not present.
    * \param pOther Another array. */
    inline void AddArrayNoDuplicate(const FbxArray<T>& pOther)
    {
        for( int i = 0, c = pOther.GetSize(); i < c; ++i )
        {
            AddUnique(pOther[i]);
        }
    }

    /** Remove the elements of another array from this array is they are present.
    * \param pOther Another array. */
    inline void RemoveArray(const FbxArray<T>& pOther)
    {
        for( int i = 0, c = pOther.GetSize(); i < c; ++i )
        {
            RemoveIt(pOther[i]);
        }
    }

    /** Operator to copy elements of an array.
    * \return this array containing a copy of pOther elements. */
    inline FbxArray<T>& operator=(const FbxArray<T>& pOther)
    {
        if( this != &pOther )
        {
            if( Resize(pOther.GetSize()) )
            {
                memcpy(GetArray(), pOther.GetArray(), pOther.GetSize() * sizeof(T));
            }
        }
        return *this;
    }

    /** Operator to compare elements of an array.
    * \return \c true if the two arrays are equal, otherwise \c false. */
    inline bool operator==(const FbxArray<T>& pOther) const
    {
        if( this == &pOther ) return true;
        if( GetSize() != pOther.GetSize() ) return false;
        return memcmp(GetArray(), pOther.GetArray(), sizeof(T) * GetSize()) == 0;
    }

/*****************************************************************************************************************************
** WARNING! Anything beyond these lines is for internal use, may not be documented and is subject to change without notice! **
*****************************************************************************************************************************/
#ifndef DOXYGEN_SHOULD_SKIP_THIS
    inline int GetCount() const { return mData ? mData->mSize : 0; }

private:
    inline void Allocate(const int pCapacity)
    {
        tData* lOldData = mData;
        tData* lData = (tData*)FbxRealloc(mData, (size_t)Alignment + FbxAllocSize(pCapacity, sizeof(T)));
        if (lData)
        {
            mData = lData;
            if (!lOldData)
            {
                mData->mSize = 0;
                mData->mCapacity = 0;
            }
        }
        else
        {
            mData = NULL;

            throw std::runtime_error("FbxArray Allocate failed");
        }
    }

    inline int GetSize() const { return mData ? mData->mSize : 0; }
    inline int GetCapacity() const { return mData ? mData->mCapacity : 0; }

#if defined(FBXSDK_COMPILER_MSC)
    //Previously class FbxArray is for pointers. Somehow, it's used to store other types. Here's a compile-time checking for known incompatible classes.
    //If it happens you find new incompatible ones, declare them with macro FBXSDK_INCOMPATIBLE_WITH_ARRAY. Also see file fbxstring.h.
    FBX_ASSERT_STATIC(FBXSDK_IS_SIMPLE_TYPE(T) || __is_enum(T) || (__has_trivial_constructor(T)&&__has_trivial_destructor(T)) || !FBXSDK_IS_INCOMPATIBLE_WITH_ARRAY(T));
#endif

#endif /* !DOXYGEN_SHOULD_SKIP_THIS *****************************************************************************************/
};

#if defined(FBXSDK_COMPILER_MSC)
    #pragma warning( pop )
#endif

//! Call FbxFree on each element of the array, and then clear it.
template <class T> inline void FbxArrayFree(FbxArray<T>& pArray)
{
    for( int i = 0, c = pArray.Size(); i < c; ++i )
    {
        FbxFree(pArray[i]);
    }
    pArray.Clear();
}

//! Call FbxDelete on each element of the array, and then clear it.
template <class T> inline void FbxArrayDelete(FbxArray<T>& pArray)
{
    for( int i = 0, c = pArray.Size(); i < c; ++i )
    {
        FbxDelete(pArray[i]);
    }
    pArray.Clear();
}

//! Call Destroy on each element of the array, and then clear it.
template <class T> inline void FbxArrayDestroy(FbxArray<T>& pArray)
{
    for( int i = 0, c = pArray.Size(); i < c; ++i )
    {
        (pArray[i])->Destroy();
    }
    pArray.Clear();
}

//! Make sure to break build if someone try to make FbxArray<FbxArray<T>>, which is not supported.
template <class T> FBXSDK_INCOMPATIBLE_WITH_ARRAY_TEMPLATE(FbxArray<T>);

#include <fbxsdk/fbxsdk_nsend.h>

#endif /* _FBXSDK_CORE_BASE_ARRAY_H_ */
