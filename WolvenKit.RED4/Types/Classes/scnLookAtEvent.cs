using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class scnLookAtEvent : scnSceneEvent
	{
		[Ordinal(6)] 
		[RED("basicData")] 
		public scnLookAtBasicEventData BasicData
		{
			get => GetPropertyValue<scnLookAtBasicEventData>();
			set => SetPropertyValue<scnLookAtBasicEventData>(value);
		}

		public scnLookAtEvent()
		{
			Id = new scnSceneEventId();
			Duration = 1000;
			BasicData = new scnLookAtBasicEventData();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
