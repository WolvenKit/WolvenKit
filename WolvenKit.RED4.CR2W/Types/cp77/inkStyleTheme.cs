using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkStyleTheme : CVariable
	{
		private CName _themeID;
		private rRef<inkStyleResource> _styleResource;

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
		[RED("styleResource")] 
		public rRef<inkStyleResource> StyleResource
		{
			get
			{
				if (_styleResource == null)
				{
					_styleResource = (rRef<inkStyleResource>) CR2WTypeManager.Create("rRef:inkStyleResource", "styleResource", cr2w, this);
				}
				return _styleResource;
			}
			set
			{
				if (_styleResource == value)
				{
					return;
				}
				_styleResource = value;
				PropertySet(this);
			}
		}

		public inkStyleTheme(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
