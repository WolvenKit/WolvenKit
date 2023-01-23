using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class audioVoiceTriggerRewireMap : audioAudioMetadata
	{
		[Ordinal(1)] 
		[RED("includes")] 
		public CArray<CName> Includes
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		[Ordinal(2)] 
		[RED("items")] 
		public CArray<audioVoiceTriggerRewireMapItem> Items
		{
			get => GetPropertyValue<CArray<audioVoiceTriggerRewireMapItem>>();
			set => SetPropertyValue<CArray<audioVoiceTriggerRewireMapItem>>(value);
		}

		public audioVoiceTriggerRewireMap()
		{
			Includes = new();
			Items = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
