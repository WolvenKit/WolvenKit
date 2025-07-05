using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiPhotoModeOptionGridButtonData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("imagePart")] 
		public CName ImagePart
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("atlasResource")] 
		public redResourceReferenceScriptToken AtlasResource
		{
			get => GetPropertyValue<redResourceReferenceScriptToken>();
			set => SetPropertyValue<redResourceReferenceScriptToken>(value);
		}

		[Ordinal(2)] 
		[RED("optionData")] 
		public CInt32 OptionData
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public gameuiPhotoModeOptionGridButtonData()
		{
			AtlasResource = new redResourceReferenceScriptToken();
			OptionData = -1;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
