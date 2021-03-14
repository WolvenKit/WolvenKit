using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkCreditsSectionEntry : CVariable
	{
		private CString _sectionTitle;
		private CArray<CString> _names;
		private CEnum<inkDisplayMode> _displayMode;

		[Ordinal(0)] 
		[RED("sectionTitle")] 
		public CString SectionTitle
		{
			get
			{
				if (_sectionTitle == null)
				{
					_sectionTitle = (CString) CR2WTypeManager.Create("String", "sectionTitle", cr2w, this);
				}
				return _sectionTitle;
			}
			set
			{
				if (_sectionTitle == value)
				{
					return;
				}
				_sectionTitle = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("names")] 
		public CArray<CString> Names
		{
			get
			{
				if (_names == null)
				{
					_names = (CArray<CString>) CR2WTypeManager.Create("array:String", "names", cr2w, this);
				}
				return _names;
			}
			set
			{
				if (_names == value)
				{
					return;
				}
				_names = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("displayMode")] 
		public CEnum<inkDisplayMode> DisplayMode
		{
			get
			{
				if (_displayMode == null)
				{
					_displayMode = (CEnum<inkDisplayMode>) CR2WTypeManager.Create("inkDisplayMode", "displayMode", cr2w, this);
				}
				return _displayMode;
			}
			set
			{
				if (_displayMode == value)
				{
					return;
				}
				_displayMode = value;
				PropertySet(this);
			}
		}

		public inkCreditsSectionEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
