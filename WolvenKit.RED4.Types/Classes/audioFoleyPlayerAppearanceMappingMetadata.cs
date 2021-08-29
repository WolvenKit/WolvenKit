using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class audioFoleyPlayerAppearanceMappingMetadata : audioAudioMetadata
	{
		private CName _fallbackMetadata;
		private CArray<audioAppearanceToPlayerMetadata> _jacketSettings;
		private CArray<audioAppearanceToPlayerMetadata> _topSettings;
		private CArray<audioAppearanceToPlayerMetadata> _bottomSettings;
		private CArray<audioAppearanceToPlayerMetadata> _jewelrySettings;

		[Ordinal(1)] 
		[RED("fallbackMetadata")] 
		public CName FallbackMetadata
		{
			get => GetProperty(ref _fallbackMetadata);
			set => SetProperty(ref _fallbackMetadata, value);
		}

		[Ordinal(2)] 
		[RED("jacketSettings")] 
		public CArray<audioAppearanceToPlayerMetadata> JacketSettings
		{
			get => GetProperty(ref _jacketSettings);
			set => SetProperty(ref _jacketSettings, value);
		}

		[Ordinal(3)] 
		[RED("topSettings")] 
		public CArray<audioAppearanceToPlayerMetadata> TopSettings
		{
			get => GetProperty(ref _topSettings);
			set => SetProperty(ref _topSettings, value);
		}

		[Ordinal(4)] 
		[RED("bottomSettings")] 
		public CArray<audioAppearanceToPlayerMetadata> BottomSettings
		{
			get => GetProperty(ref _bottomSettings);
			set => SetProperty(ref _bottomSettings, value);
		}

		[Ordinal(5)] 
		[RED("jewelrySettings")] 
		public CArray<audioAppearanceToPlayerMetadata> JewelrySettings
		{
			get => GetProperty(ref _jewelrySettings);
			set => SetProperty(ref _jewelrySettings, value);
		}
	}
}
