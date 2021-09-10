using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class audioGenericNameEventMap : audioAudioMetadata
	{
		[Ordinal(1)] 
		[RED("eventOverrides")] 
		public CHandle<audioGenericNameEventDictionary> EventOverrides
		{
			get => GetPropertyValue<CHandle<audioGenericNameEventDictionary>>();
			set => SetPropertyValue<CHandle<audioGenericNameEventDictionary>>(value);
		}
	}
}
