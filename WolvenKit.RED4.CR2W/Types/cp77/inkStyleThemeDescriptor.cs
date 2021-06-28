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
			get => GetProperty(ref _themeID);
			set => SetProperty(ref _themeID, value);
		}

		[Ordinal(1)] 
		[RED("themeNameLocKey")] 
		public CName ThemeNameLocKey
		{
			get => GetProperty(ref _themeNameLocKey);
			set => SetProperty(ref _themeNameLocKey, value);
		}

		public inkStyleThemeDescriptor(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
