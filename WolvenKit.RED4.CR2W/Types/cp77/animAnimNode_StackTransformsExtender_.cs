using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_StackTransformsExtender_ : animAnimNode_OnePoseInput
	{
		private CName _tag;
		private CArray<animTransformInfo> _transformInfos;
		private CArray<CEnum<animStackTransformsExtender_SnapToBoneMethod>> _snapMethods;
		private CArray<CBool> _snapToReferenceValues;
		private CArray<animTransformIndex> _snapTargetBones;
		private CArray<CBool> _offsetToReferenceValues;
		private CArray<animTransformIndex> _offsetSpaceBones;
		private CArray<QsTransform> _offsets;

		[Ordinal(12)] 
		[RED("tag")] 
		public CName Tag
		{
			get
			{
				if (_tag == null)
				{
					_tag = (CName) CR2WTypeManager.Create("CName", "tag", cr2w, this);
				}
				return _tag;
			}
			set
			{
				if (_tag == value)
				{
					return;
				}
				_tag = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("transformInfos")] 
		public CArray<animTransformInfo> TransformInfos
		{
			get
			{
				if (_transformInfos == null)
				{
					_transformInfos = (CArray<animTransformInfo>) CR2WTypeManager.Create("array:animTransformInfo", "transformInfos", cr2w, this);
				}
				return _transformInfos;
			}
			set
			{
				if (_transformInfos == value)
				{
					return;
				}
				_transformInfos = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("snapMethods")] 
		public CArray<CEnum<animStackTransformsExtender_SnapToBoneMethod>> SnapMethods
		{
			get
			{
				if (_snapMethods == null)
				{
					_snapMethods = (CArray<CEnum<animStackTransformsExtender_SnapToBoneMethod>>) CR2WTypeManager.Create("array:animStackTransformsExtender_SnapToBoneMethod", "snapMethods", cr2w, this);
				}
				return _snapMethods;
			}
			set
			{
				if (_snapMethods == value)
				{
					return;
				}
				_snapMethods = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("snapToReferenceValues")] 
		public CArray<CBool> SnapToReferenceValues
		{
			get
			{
				if (_snapToReferenceValues == null)
				{
					_snapToReferenceValues = (CArray<CBool>) CR2WTypeManager.Create("array:Bool", "snapToReferenceValues", cr2w, this);
				}
				return _snapToReferenceValues;
			}
			set
			{
				if (_snapToReferenceValues == value)
				{
					return;
				}
				_snapToReferenceValues = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("snapTargetBones")] 
		public CArray<animTransformIndex> SnapTargetBones
		{
			get
			{
				if (_snapTargetBones == null)
				{
					_snapTargetBones = (CArray<animTransformIndex>) CR2WTypeManager.Create("array:animTransformIndex", "snapTargetBones", cr2w, this);
				}
				return _snapTargetBones;
			}
			set
			{
				if (_snapTargetBones == value)
				{
					return;
				}
				_snapTargetBones = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("offsetToReferenceValues")] 
		public CArray<CBool> OffsetToReferenceValues
		{
			get
			{
				if (_offsetToReferenceValues == null)
				{
					_offsetToReferenceValues = (CArray<CBool>) CR2WTypeManager.Create("array:Bool", "offsetToReferenceValues", cr2w, this);
				}
				return _offsetToReferenceValues;
			}
			set
			{
				if (_offsetToReferenceValues == value)
				{
					return;
				}
				_offsetToReferenceValues = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("offsetSpaceBones")] 
		public CArray<animTransformIndex> OffsetSpaceBones
		{
			get
			{
				if (_offsetSpaceBones == null)
				{
					_offsetSpaceBones = (CArray<animTransformIndex>) CR2WTypeManager.Create("array:animTransformIndex", "offsetSpaceBones", cr2w, this);
				}
				return _offsetSpaceBones;
			}
			set
			{
				if (_offsetSpaceBones == value)
				{
					return;
				}
				_offsetSpaceBones = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("offsets")] 
		public CArray<QsTransform> Offsets
		{
			get
			{
				if (_offsets == null)
				{
					_offsets = (CArray<QsTransform>) CR2WTypeManager.Create("array:QsTransform", "offsets", cr2w, this);
				}
				return _offsets;
			}
			set
			{
				if (_offsets == value)
				{
					return;
				}
				_offsets = value;
				PropertySet(this);
			}
		}

		public animAnimNode_StackTransformsExtender_(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
