using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class scnIKEvent : scnSceneEvent
	{
		[Ordinal(6)] 
		[RED("ikData")] 
		public scnIKEventData IkData
		{
			get => GetPropertyValue<scnIKEventData>();
			set => SetPropertyValue<scnIKEventData>(value);
		}

		public scnIKEvent()
		{
			Id = new scnSceneEventId();
			Duration = 1000;
			IkData = new scnIKEventData();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
