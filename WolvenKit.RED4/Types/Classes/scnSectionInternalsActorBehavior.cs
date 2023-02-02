using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class scnSectionInternalsActorBehavior : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("actorId")] 
		public scnActorId ActorId
		{
			get => GetPropertyValue<scnActorId>();
			set => SetPropertyValue<scnActorId>(value);
		}

		[Ordinal(1)] 
		[RED("behaviorMode")] 
		public CEnum<scnSectionInternalsActorBehaviorMode> BehaviorMode
		{
			get => GetPropertyValue<CEnum<scnSectionInternalsActorBehaviorMode>>();
			set => SetPropertyValue<CEnum<scnSectionInternalsActorBehaviorMode>>(value);
		}

		public scnSectionInternalsActorBehavior()
		{
			ActorId = new() { Id = 4294967295 };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
