using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkStyleThemeDescriptor : CVariable
	{
		private CName _themeID;
		private CName _themeNameLocKey;

		[Ordinal(0)] 
		[RED("themeID")] 
		public CName ThemeID
		{
			get
			{
				if (_themeID == null)
				{
					_themeID = (CName) CR2WTypeManager.Create("CName", "themeID", cr2w, this);
				}
				return _themeID;
			}
			set
			{
				if (_themeID == value)
				{
					return;
				}
				_themeID = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("themeNameLocKey")] 
		public CName ThemeNameLocKey
		{
			get
			{
				if (_themeNameLocKey == null)
				{
					_themeNameLocKey = (CName) CR2WTypeManager.Create("CName", "themeNameLocKey", cr2w, this);
				}
				return _themeNameLocKey;
			}
			set
			{
				if (_themeNameLocKey == value)
				{
					return;
				}
				_themeNameLocKey = value;
				PropertySet(this);
			}
		}

		public inkStyleThemeDescriptor(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
