using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animSetBoneTransformEntry : CVariable
	{
		private animTransformIndex _transformToChange;
		private CEnum<animSetBoneTransformEntry_SetMethod> _setMethod;
		private CBool _snapToReference;
		private animTransformIndex _sourceBone;
		private CBool _offsetToReference;
		private animTransformIndex _offsetSpaceBone;
		private QsTransform _offset;

		[Ordinal(0)] 
		[RED("transformToChange")] 
		public animTransformIndex TransformToChange
		{
			get
			{
				if (_transformToChange == null)
				{
					_transformToChange = (animTransformIndex) CR2WTypeManager.Create("animTransformIndex", "transformToChange", cr2w, this);
				}
				return _transformToChange;
			}
			set
			{
				if (_transformToChange == value)
				{
					return;
				}
				_transformToChange = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("setMethod")] 
		public CEnum<animSetBoneTransformEntry_SetMethod> SetMethod
		{
			get
			{
				if (_setMethod == null)
				{
					_setMethod = (CEnum<animSetBoneTransformEntry_SetMethod>) CR2WTypeManager.Create("animSetBoneTransformEntry_SetMethod", "setMethod", cr2w, this);
				}
				return _setMethod;
			}
			set
			{
				if (_setMethod == value)
				{
					return;
				}
				_setMethod = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("snapToReference")] 
		public CBool SnapToReference
		{
			get
			{
				if (_snapToReference == null)
				{
					_snapToReference = (CBool) CR2WTypeManager.Create("Bool", "snapToReference", cr2w, this);
				}
				return _snapToReference;
			}
			set
			{
				if (_snapToReference == value)
				{
					return;
				}
				_snapToReference = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("sourceBone")] 
		public animTransformIndex SourceBone
		{
			get
			{
				if (_sourceBone == null)
				{
					_sourceBone = (animTransformIndex) CR2WTypeManager.Create("animTransformIndex", "sourceBone", cr2w, this);
				}
				return _sourceBone;
			}
			set
			{
				if (_sourceBone == value)
				{
					return;
				}
				_sourceBone = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("offsetToReference")] 
		public CBool OffsetToReference
		{
			get
			{
				if (_offsetToReference == null)
				{
					_offsetToReference = (CBool) CR2WTypeManager.Create("Bool", "offsetToReference", cr2w, this);
				}
				return _offsetToReference;
			}
			set
			{
				if (_offsetToReference == value)
				{
					return;
				}
				_offsetToReference = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("offsetSpaceBone")] 
		public animTransformIndex OffsetSpaceBone
		{
			get
			{
				if (_offsetSpaceBone == null)
				{
					_offsetSpaceBone = (animTransformIndex) CR2WTypeManager.Create("animTransformIndex", "offsetSpaceBone", cr2w, this);
				}
				return _offsetSpaceBone;
			}
			set
			{
				if (_offsetSpaceBone == value)
				{
					return;
				}
				_offsetSpaceBone = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("offset")] 
		public QsTransform Offset
		{
			get
			{
				if (_offset == null)
				{
					_offset = (QsTransform) CR2WTypeManager.Create("QsTransform", "offset", cr2w, this);
				}
				return _offset;
			}
			set
			{
				if (_offset == value)
				{
					return;
				}
				_offset = value;
				PropertySet(this);
			}
		}

		public animSetBoneTransformEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
