using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class scnAddIdleAnimEvent : scnSceneEvent
	{
		[Ordinal(6)] 
		[RED("performerId")] 
		public scnPerformerId PerformerId
		{
			get => GetPropertyValue<scnPerformerId>();
			set => SetPropertyValue<scnPerformerId>(value);
		}

		[Ordinal(7)] 
		[RED("actorComponent")] 
		public CName ActorComponent
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(8)] 
		[RED("weight")] 
		public CFloat Weight
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public scnAddIdleAnimEvent()
		{
			Id = new scnSceneEventId { Id = long.MaxValue };
			PerformerId = new scnPerformerId { Id = 4294967040 };
			ActorComponent = "body";
			Weight = 1.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
