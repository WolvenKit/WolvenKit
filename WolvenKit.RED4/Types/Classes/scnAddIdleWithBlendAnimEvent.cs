using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class scnAddIdleWithBlendAnimEvent : scnSceneEvent
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
		[RED("targetWeight")] 
		public CFloat TargetWeight
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public scnAddIdleWithBlendAnimEvent()
		{
			Id = new() { Id = 18446744073709551615 };
			PerformerId = new() { Id = 4294967040 };
			ActorComponent = "body";
			TargetWeight = 1.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
