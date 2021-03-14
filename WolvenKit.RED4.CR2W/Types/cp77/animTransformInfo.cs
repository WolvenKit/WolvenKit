using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animTransformInfo : CVariable
	{
		private CName _name;
		private CName _parentName;
		private QsTransform _referenceTransformLs;

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

		public animTransformInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
