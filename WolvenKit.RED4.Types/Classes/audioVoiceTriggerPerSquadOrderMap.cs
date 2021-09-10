using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class audioVoiceTriggerPerSquadOrderMap : audioAudioMetadata
	{
		[Ordinal(1)] 
		[RED("items")] 
		public CArray<audioVoiceTriggerPerSquadOrderMapItem> Items
		{
			get => GetPropertyValue<CArray<audioVoiceTriggerPerSquadOrderMapItem>>();
			set => SetPropertyValue<CArray<audioVoiceTriggerPerSquadOrderMapItem>>(value);
		}

		public audioVoiceTriggerPerSquadOrderMap()
		{
			Items = new();
		}
	}
}
