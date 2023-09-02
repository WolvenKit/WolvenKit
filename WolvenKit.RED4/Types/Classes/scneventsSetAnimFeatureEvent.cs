using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class scneventsSetAnimFeatureEvent : scnSceneEvent
	{
		[Ordinal(6)] 
		[RED("actorId")] 
		public scnActorId ActorId
		{
			get => GetPropertyValue<scnActorId>();
			set => SetPropertyValue<scnActorId>(value);
		}

		[Ordinal(7)] 
		[RED("animFeatureName")] 
		public CName AnimFeatureName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(8)] 
		[RED("animFeature")] 
		public CHandle<animAnimFeature> AnimFeature
		{
			get => GetPropertyValue<CHandle<animAnimFeature>>();
			set => SetPropertyValue<CHandle<animAnimFeature>>(value);
		}

		public scneventsSetAnimFeatureEvent()
		{
			Id = new scnSceneEventId { Id = long.MaxValue };
			ActorId = new scnActorId { Id = uint.MaxValue };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
