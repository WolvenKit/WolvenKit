using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class audioMeleeRigMap : audioAudioMetadata
	{
		[Ordinal(1)] 
		[RED("mapItems")] 
		public CArray<audioMeleeRigMapItem> MapItems
		{
			get => GetPropertyValue<CArray<audioMeleeRigMapItem>>();
			set => SetPropertyValue<CArray<audioMeleeRigMapItem>>(value);
		}

		public audioMeleeRigMap()
		{
			MapItems = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
