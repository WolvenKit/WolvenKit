using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class scnLookAtAdvancedEvent : scnSceneEvent
	{
		[Ordinal(6)] 
		[RED("advancedData")] 
		public scnLookAtAdvancedEventData AdvancedData
		{
			get => GetPropertyValue<scnLookAtAdvancedEventData>();
			set => SetPropertyValue<scnLookAtAdvancedEventData>(value);
		}

		public scnLookAtAdvancedEvent()
		{
			Id = new scnSceneEventId();
			Duration = 1000;
			AdvancedData = new scnLookAtAdvancedEventData();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
