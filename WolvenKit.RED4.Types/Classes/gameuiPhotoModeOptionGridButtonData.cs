using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameuiPhotoModeOptionGridButtonData : RedBaseClass
	{
		private CName _imagePart;
		private redResourceReferenceScriptToken _atlasResource;
		private CInt32 _optionData;

		[Ordinal(0)] 
		[RED("imagePart")] 
		public CName ImagePart
		{
			get => GetProperty(ref _imagePart);
			set => SetProperty(ref _imagePart, value);
		}

		[Ordinal(1)] 
		[RED("atlasResource")] 
		public redResourceReferenceScriptToken AtlasResource
		{
			get => GetProperty(ref _atlasResource);
			set => SetProperty(ref _atlasResource, value);
		}

		[Ordinal(2)] 
		[RED("optionData")] 
		public CInt32 OptionData
		{
			get => GetProperty(ref _optionData);
			set => SetProperty(ref _optionData, value);
		}
	}
}
