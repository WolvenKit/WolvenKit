using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class audioAudBulletTimeModeMap : audioAudioMetadata
	{
		[Ordinal(1)] 
		[RED("bulletTimeMapItems")] 
		public CArray<audioAudBulletTimeModeMapItem> BulletTimeMapItems
		{
			get => GetPropertyValue<CArray<audioAudBulletTimeModeMapItem>>();
			set => SetPropertyValue<CArray<audioAudBulletTimeModeMapItem>>(value);
		}

		public audioAudBulletTimeModeMap()
		{
			BulletTimeMapItems = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
