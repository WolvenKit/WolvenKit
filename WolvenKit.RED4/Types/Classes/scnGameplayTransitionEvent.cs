using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class scnGameplayTransitionEvent : scnSceneEvent
	{
		[Ordinal(6)] 
		[RED("performer")] 
		public scnPerformerId Performer
		{
			get => GetPropertyValue<scnPerformerId>();
			set => SetPropertyValue<scnPerformerId>(value);
		}

		[Ordinal(7)] 
		[RED("vehState")] 
		public CEnum<scnPuppetVehicleState> VehState
		{
			get => GetPropertyValue<CEnum<scnPuppetVehicleState>>();
			set => SetPropertyValue<CEnum<scnPuppetVehicleState>>(value);
		}

		public scnGameplayTransitionEvent()
		{
			Id = new scnSceneEventId();
			Performer = new scnPerformerId();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
