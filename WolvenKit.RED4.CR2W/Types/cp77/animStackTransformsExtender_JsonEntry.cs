using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animStackTransformsExtender_JsonEntry : CVariable
	{
		private CName _name;
		private CName _parentName;
		private QsTransform _referenceTransformLs;
		private CEnum<animStackTransformsExtender_SnapToBoneMethod> _snapMethod;
		private CBool _snapToReference;
		private CName _snapTargetBone;
		private CBool _offsetToReference;
		private CName _offsetSpaceBone;
		private QsTransform _offset;

		[Ordinal(0)] 
		[RED("name")] 
		public CName Name
		{
			get
			{
				if (_name == null)
				{
					_name = (CName) CR2WTypeManager.Create("CName", "name", cr2w, this);
				}
				return _name;
			}
			set
			{
				if (_name == value)
				{
					return;
				}
				_name = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("parentName")] 
		public CName ParentName
		{
			get
			{
				if (_parentName == null)
				{
					_parentName = (CName) CR2WTypeManager.Create("CName", "parentName", cr2w, this);
				}
				return _parentName;
			}
			set
			{
				if (_parentName == value)
				{
					return;
				}
				_parentName = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("referenceTransformLs")] 
		public QsTransform ReferenceTransformLs
		{
			get
			{
				if (_referenceTransformLs == null)
				{
					_referenceTransformLs = (QsTransform) CR2WTypeManager.Create("QsTransform", "referenceTransformLs", cr2w, this);
				}
				return _referenceTransformLs;
			}
			set
			{
				if (_referenceTransformLs == value)
				{
					return;
				}
				_referenceTransformLs = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
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

		[Ordinal(4)] 
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

		[Ordinal(5)] 
		[RED("snapTargetBone")] 
		public CName SnapTargetBone
		{
			get
			{
				if (_snapTargetBone == null)
				{
					_snapTargetBone = (CName) CR2WTypeManager.Create("CName", "snapTargetBone", cr2w, this);
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

		[Ordinal(6)] 
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

		[Ordinal(7)] 
		[RED("offsetSpaceBone")] 
		public CName OffsetSpaceBone
		{
			get
			{
				if (_offsetSpaceBone == null)
				{
					_offsetSpaceBone = (CName) CR2WTypeManager.Create("CName", "offsetSpaceBone", cr2w, this);
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

		[Ordinal(8)] 
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

		public animStackTransformsExtender_JsonEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
