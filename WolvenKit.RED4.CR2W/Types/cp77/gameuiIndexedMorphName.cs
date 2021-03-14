using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiIndexedMorphName : CVariable
	{
		private CInt32 _index;
		private CName _morphName;
		private CString _localizedName;
		private redTagList _tags;

		[Ordinal(0)] 
		[RED("index")] 
		public CInt32 Index
		{
			get
			{
				if (_index == null)
				{
					_index = (CInt32) CR2WTypeManager.Create("Int32", "index", cr2w, this);
				}
				return _index;
			}
			set
			{
				if (_index == value)
				{
					return;
				}
				_index = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("morphName")] 
		public CName MorphName
		{
			get
			{
				if (_morphName == null)
				{
					_morphName = (CName) CR2WTypeManager.Create("CName", "morphName", cr2w, this);
				}
				return _morphName;
			}
			set
			{
				if (_morphName == value)
				{
					return;
				}
				_morphName = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("localizedName")] 
		public CString LocalizedName
		{
			get
			{
				if (_localizedName == null)
				{
					_localizedName = (CString) CR2WTypeManager.Create("String", "localizedName", cr2w, this);
				}
				return _localizedName;
			}
			set
			{
				if (_localizedName == value)
				{
					return;
				}
				_localizedName = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("tags")] 
		public redTagList Tags
		{
			get
			{
				if (_tags == null)
				{
					_tags = (redTagList) CR2WTypeManager.Create("redTagList", "tags", cr2w, this);
				}
				return _tags;
			}
			set
			{
				if (_tags == value)
				{
					return;
				}
				_tags = value;
				PropertySet(this);
			}
		}

		public gameuiIndexedMorphName(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
