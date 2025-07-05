using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiarcadeShooterEventManager : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("nextLevelThreshold")] 
		public Vector2 NextLevelThreshold
		{
			get => GetPropertyValue<Vector2>();
			set => SetPropertyValue<Vector2>(value);
		}

		[Ordinal(2)] 
		[RED("levelEndCheckDelay")] 
		public CFloat LevelEndCheckDelay
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("eventFinishDelay")] 
		public CFloat EventFinishDelay
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(4)] 
		[RED("eventId")] 
		public CInt32 EventId
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(5)] 
		[RED("eventList")] 
		public CArray<gameuiarcadeShooterEventData> EventList
		{
			get => GetPropertyValue<CArray<gameuiarcadeShooterEventData>>();
			set => SetPropertyValue<CArray<gameuiarcadeShooterEventData>>(value);
		}

		public gameuiarcadeShooterEventManager()
		{
			NextLevelThreshold = new Vector2();
			LevelEndCheckDelay = 20.000000F;
			EventId = -1;
			EventList = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
