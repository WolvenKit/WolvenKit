using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class scnSectionInternalsActorBehavior : RedBaseClass
	{
		private scnActorId _actorId;
		private CEnum<scnSectionInternalsActorBehaviorMode> _behaviorMode;

		[Ordinal(0)] 
		[RED("actorId")] 
		public scnActorId ActorId
		{
			get => GetProperty(ref _actorId);
			set => SetProperty(ref _actorId, value);
		}

		[Ordinal(1)] 
		[RED("behaviorMode")] 
		public CEnum<scnSectionInternalsActorBehaviorMode> BehaviorMode
		{
			get => GetProperty(ref _behaviorMode);
			set => SetProperty(ref _behaviorMode, value);
		}
	}
}
