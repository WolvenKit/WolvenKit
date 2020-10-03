/****************************************************************************************
 
   Copyright (C) 2015 Autodesk, Inc.
   All rights reserved.
 
   Use of this software is subject to the terms of the Autodesk license agreement
   provided at the time of installation or download, or which otherwise accompanies
   this software in either electronic or hard copy form.
 
****************************************************************************************/

//! \file fbxshape.h
#ifndef _FBXSDK_SCENE_GEOMETRY_SHAPE_H_
#define _FBXSDK_SCENE_GEOMETRY_SHAPE_H_

#include <fbxsdk/fbxsdk_def.h>

#include <fbxsdk/scene/geometry/fbxgeometrybase.h>

#include <fbxsdk/fbxsdk_nsbegin.h>

class FbxBlendShapeChannel;
class FbxGeometry;

/** A shape describes the deformation on a set of control points, which is similar to the cluster deformer in Maya.
  * For example, we can add a shape to a created geometry. And the shape and the geometry have the same
  * topological information but different position of the control points.
  * With varying amounts of influence, the geometry performs a deformation effect.
  *
  * Shape can be represented in 2 ways:
  * \li Legacy style (default): in legacy style only control point positions and normals are handled. In this style the control point position
  * value and normal are saved as relative values to the base geometry values. Only normals for which the control point position 
  * has changed will be exported.
  * \li Modern style(non Legacy style): in this style the LayerElements (FbxLayerElement) for Normal (FbxGeometryBase::GetElementNormal), Tangent (FbxGeometryBase::GetElementTangent)
  * , BiNormal (FbxGeometryBase::GetElementBiNormal), VertexColor (FbxGeometryBase::GetElementVertexColor) and UV (FbxGeometryBase::GetElementUV) will be 
  * exported if they have a corresponding FbxLayerElement on the base geometry of the FbxBlendShape (FbxShape::GetBaseGeometry). The values will be
  * exported only if they are different than values on the base geometry and no longer requires that the corresponding control point 
  * position has changed. In Modern style you can choose whether the values should be saved as absolute or relative values (FbxShape::SetAbsoluteMode).
  * \nosubgrouping
  * \see FbxGeometry
  */
class FBXSDK_DLL FbxShape : public FbxGeometryBase
{
    FBXSDK_OBJECT_DECLARE(FbxShape, FbxGeometryBase);

public:
	/** Sets the shape style.
	* \param pState \c true if this shape is in Legacy style, \c false otherwise.
	* \see For more details on shape style see FbxShape.
	*/
	void SetLegacyStyle(bool pState);

	/** Get the shape style.
	* \return \c true if this shape is in Legacy style, \c false otherwise.
	* \remark When in Legacy style, only position and normals would be considered.
	* \see For more details on shape style see FbxShape.
	*/
	bool IsLegacyStyle() const;

	/** Set whether the values are saved as absolute values or as relative values. Default is relative values.
	* \param pAbsolute true will save the shape as absolute values, false will save the shape values as relative to the 
	* base geometry of the FbxBlendShape (FbxShape::GetBaseGeometry).
	* \remark In legacy style we always use relative values and this value is ignored.
	* \see For more details on shape style see FbxShape.
	*/
	void SetAbsoluteMode(bool pAbsolute);

	/** Get whether the blend shape values are saved as absolute values or as relative values.
	* \return \c true shape control points and attributes will be saved using their absolute values, 
	* \c false shape control points and attribute will be saved in relative values to the base geometry of the FbxBlendShape 
	* \remark In legacy style we always use relative values.
	* (FbxShape::GetBaseGeometry).
	*/
	bool IsAbsoluteMode() const;

	/** Set the blend shape channel that contains this target shape.
	* \param pBlendShapeChannel      Pointer to the blend shape channel to set.
	* \return                        \c true on success, \c false otherwise.
	*/
	bool SetBlendShapeChannel(FbxBlendShapeChannel* pBlendShapeChannel);

	/** Get the blend shape channel that contains this target shape.
	* \return                        a pointer to the blend shape channel if set or NULL.
	*/
	FbxBlendShapeChannel* GetBlendShapeChannel() const;

	/** Get the base geometry of this target shape.
	* \return                        a pointer to the base geometry if set or NULL.
	* \remarks Since target shape can only connected to its base geometry through
	*          blend shape channel and blend shape deformer.
	*          So only when this target shape is connected to a blend shape channel,
	*          and the blend shape channel is connected to a blend shape deformer,
	*          and the blend shape deformer is used on a base geometry, then to get 
    *          base geometry will success.
	*/
	FbxGeometry* GetBaseGeometry();

	/** Get the length of the arrays of control point indices and weights.
	* \return     Length of the arrays of control point indices and weights.
	*             Returns 0 if no control point indices have been added or the arrays have been reset.
	*/
	int GetControlPointIndicesCount() const;

	/** Get the array of control point indices.
	* \return     Pointer to the array of control point indices.
	*             \c NULL if no control point indices have been added or the array has been reset.
	*/
	int* GetControlPointIndices() const;


	/** Set the array size for the control point indices
	* \param pCount The new count.
	*/
	void SetControlPointIndicesCount(int pCount);

	/** Add a control point index to the control point indices array
	* \param pIndex The control point index to add.
	*/	
	void AddControlPointIndex(int pIndex);

	/** Restore the shape to its initial state.
	* Calling this function will clear the following:
	* \li Pointer to blend shape channel.
	* \li Control point indices.
	*/
	void Reset();

protected:
	  //@{
			//! If true only the vertex position and normals are handled.
			FbxPropertyT<FbxBool> LegacyStyle;

			//! If true and not in legacy style values will be stored in absolute values(normals, colors, etc.).
			FbxPropertyT<FbxBool> AbsoluteMode;
	//@}
public:
/*****************************************************************************************************************************
** WARNING! Anything beyond these lines is for internal use, may not be documented and is subject to change without notice! **
*****************************************************************************************************************************/
#ifndef DOXYGEN_SHOULD_SKIP_THIS
    void Compact() override;
    FbxObject& Copy(const FbxObject& pObject) override;
    FbxObject* Clone(FbxObject::ECloneType pCloneType=eDeepClone, FbxObject* pContainer=NULL, void* pSet = NULL) const override;
    
protected:
	void ConstructProperties(bool pForceSet) override;
    FbxNodeAttribute::EType GetAttributeType() const override;
    FbxStringList GetTypeFlags() const override;

	FbxArray<int> mControlPointIndices;
#endif /* !DOXYGEN_SHOULD_SKIP_THIS *****************************************************************************************/
};

#include <fbxsdk/fbxsdk_nsend.h>

#endif /* _FBXSDK_SCENE_GEOMETRY_SHAPE_H_ */
