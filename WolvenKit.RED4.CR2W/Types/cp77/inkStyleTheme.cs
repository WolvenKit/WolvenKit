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
			get => GetProperty(ref _themeID);
			set => SetProperty(ref _themeID, value);
		}

		[Ordinal(1)] 
		[RED("styleResource")] 
		public rRef<inkStyleResource> StyleResource
		{
			get => GetProperty(ref _styleResource);
			set => SetProperty(ref _styleResource, value);
		}

		public inkStyleTheme(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
