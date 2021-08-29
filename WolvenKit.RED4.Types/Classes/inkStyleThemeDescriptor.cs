using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class inkStyleThemeDescriptor : RedBaseClass
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
	}
}
