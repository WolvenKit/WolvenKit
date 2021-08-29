using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class scnLookAtAdvancedEvent : scnSceneEvent
	{
		private scnLookAtAdvancedEventData _advancedData;

		[Ordinal(6)] 
		[RED("advancedData")] 
		public scnLookAtAdvancedEventData AdvancedData
		{
			get => GetProperty(ref _advancedData);
			set => SetProperty(ref _advancedData, value);
		}
	}
}
