using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class audioGenericNameEventMap : audioAudioMetadata
	{
		private CHandle<audioGenericNameEventDictionary> _eventOverrides;

		[Ordinal(1)] 
		[RED("eventOverrides")] 
		public CHandle<audioGenericNameEventDictionary> EventOverrides
		{
			get => GetProperty(ref _eventOverrides);
			set => SetProperty(ref _eventOverrides, value);
		}
	}
}
