using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animStackTransformsExtender_Entry : CVariable
	{
		private animTransformInfo _transformInfo;
		private CEnum<animStackTransformsExtender_SnapToBoneMethod> _snapMethod;
		private CBool _snapToReference;
		private animTransformIndex _snapTargetBone;
		private CBool _offsetToReference;
		private animTransformIndex _offsetSpaceBone;
		private QsTransform _offset;

		[Ordinal(0)] 
		[RED("transformInfo")] 
		public animTransformInfo TransformInfo
		{
			get
			{
				if (_transformInfo == null)
				{
					_transformInfo = (animTransformInfo) CR2WTypeManager.Create("animTransformInfo", "transformInfo", cr2w, this);
				}
				return _transformInfo;
			}
			set
			{
				if (_transformInfo == value)
				{
					return;
				}
				_transformInfo = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("snapMethod")] 
		public CEnum<animStackTransformsExtender_SnapToBoneMethod> SnapMethod
		{
			get
			{
				if (_snapMethod == null)
				{
					_snapMethod = (CEnum<animStackTransformsExtender_SnapToBoneMethod>) CR2WTypeManager.Create("animStackTransformsExtender_SnapToBoneMethod", "snapMethod", cr2w, this);
				}
				return _snapMethod;
			}
			set
			{
				if (_snapMethod == value)
				{
					return;
				}
				_snapMethod = value;
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
		[RED("snapTargetBone")] 
		public animTransformIndex SnapTargetBone
		{
			get
			{
				if (_snapTargetBone == null)
				{
					_snapTargetBone = (animTransformIndex) CR2WTypeManager.Create("animTransformIndex", "snapTargetBone", cr2w, this);
				}
				return _snapTargetBone;
			}
			set
			{
				if (_snapTargetBone == value)
				{
					return;
				}
				_snapTargetBone = value;
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

		public animStackTransformsExtender_Entry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
