using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class audioVoiceTriggerPerSquadOrderMap : audioAudioMetadata
	{
		private CArray<audioVoiceTriggerPerSquadOrderMapItem> _items;

		[Ordinal(1)] 
		[RED("items")] 
		public CArray<audioVoiceTriggerPerSquadOrderMapItem> Items
		{
			get => GetProperty(ref _items);
			set => SetProperty(ref _items, value);
		}
	}
}
