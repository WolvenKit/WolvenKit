using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class audioEventOverrides : audioAudioMetadata
	{
		private CHandle<audioEventOverrideDictionary> _eventOverrides;

		[Ordinal(1)] 
		[RED("eventOverrides")] 
		public CHandle<audioEventOverrideDictionary> EventOverrides
		{
			get => GetProperty(ref _eventOverrides);
			set => SetProperty(ref _eventOverrides, value);
		}
	}
}
