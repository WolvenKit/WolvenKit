using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class inkStyleTheme : RedBaseClass
	{
		private CName _themeID;
		private CResourceReference<inkStyleResource> _styleResource;

		[Ordinal(0)] 
		[RED("themeID")] 
		public CName ThemeID
		{
			get => GetProperty(ref _themeID);
			set => SetProperty(ref _themeID, value);
		}

		[Ordinal(1)] 
		[RED("styleResource")] 
		public CResourceReference<inkStyleResource> StyleResource
		{
			get => GetProperty(ref _styleResource);
			set => SetProperty(ref _styleResource, value);
		}
	}
}
