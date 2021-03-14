using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animImportFacialCorrectivePoseDataDesc : CVariable
	{
		private CArray<animImportFacialTransform> _transforms;
		private CArray<animImportFacialTransformNoScale> _transformsNoScale;
		private CArray<CUInt16> _transformIds;
		private CArray<CName> _transformNames;
		private CArray<CFloat> _parentsWeights;

		[Ordinal(0)] 
		[RED("transforms")] 
		public CArray<animImportFacialTransform> Transforms
		{
			get
			{
				if (_transforms == null)
				{
					_transforms = (CArray<animImportFacialTransform>) CR2WTypeManager.Create("array:animImportFacialTransform", "transforms", cr2w, this);
				}
				return _transforms;
			}
			set
			{
				if (_transforms == value)
				{
					return;
				}
				_transforms = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("transformsNoScale")] 
		public CArray<animImportFacialTransformNoScale> TransformsNoScale
		{
			get
			{
				if (_transformsNoScale == null)
				{
					_transformsNoScale = (CArray<animImportFacialTransformNoScale>) CR2WTypeManager.Create("array:animImportFacialTransformNoScale", "transformsNoScale", cr2w, this);
				}
				return _transformsNoScale;
			}
			set
			{
				if (_transformsNoScale == value)
				{
					return;
				}
				_transformsNoScale = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("transformIds")] 
		public CArray<CUInt16> TransformIds
		{
			get
			{
				if (_transformIds == null)
				{
					_transformIds = (CArray<CUInt16>) CR2WTypeManager.Create("array:Uint16", "transformIds", cr2w, this);
				}
				return _transformIds;
			}
			set
			{
				if (_transformIds == value)
				{
					return;
				}
				_transformIds = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("transformNames")] 
		public CArray<CName> TransformNames
		{
			get
			{
				if (_transformNames == null)
				{
					_transformNames = (CArray<CName>) CR2WTypeManager.Create("array:CName", "transformNames", cr2w, this);
				}
				return _transformNames;
			}
			set
			{
				if (_transformNames == value)
				{
					return;
				}
				_transformNames = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("parentsWeights")] 
		public CArray<CFloat> ParentsWeights
		{
			get
			{
				if (_parentsWeights == null)
				{
					_parentsWeights = (CArray<CFloat>) CR2WTypeManager.Create("array:Float", "parentsWeights", cr2w, this);
				}
				return _parentsWeights;
			}
			set
			{
				if (_parentsWeights == value)
				{
					return;
				}
				_parentsWeights = value;
				PropertySet(this);
			}
		}

		public animImportFacialCorrectivePoseDataDesc(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
