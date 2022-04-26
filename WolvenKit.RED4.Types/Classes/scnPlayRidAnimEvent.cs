using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class scnPlayRidAnimEvent : scnPlayFPPControlAnimEvent
	{
		[Ordinal(32)] 
		[RED("ridVersinon")] 
		public CUInt32 RidVersinon
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(33)] 
		[RED("animResRefId")] 
		public scnRidAnimationSRRefId AnimResRefId
		{
			get => GetPropertyValue<scnRidAnimationSRRefId>();
			set => SetPropertyValue<scnRidAnimationSRRefId>(value);
		}

		[Ordinal(34)] 
		[RED("animOriginMarker")] 
		public scnMarker AnimOriginMarker
		{
			get => GetPropertyValue<scnMarker>();
			set => SetPropertyValue<scnMarker>(value);
		}

		[Ordinal(35)] 
		[RED("actorPlacement")] 
		public CEnum<scnRidActorPlacement> ActorPlacement
		{
			get => GetPropertyValue<CEnum<scnRidActorPlacement>>();
			set => SetPropertyValue<CEnum<scnRidActorPlacement>>(value);
		}

		[Ordinal(36)] 
		[RED("actorHasCollision")] 
		public CBool ActorHasCollision
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(37)] 
		[RED("blendInTrajectoryBone")] 
		public CFloat BlendInTrajectoryBone
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public scnPlayRidAnimEvent()
		{
			AnimResRefId = new() { Id = 4294967295 };
			AnimOriginMarker = new() { Type = Enums.scnMarkerType.Global, EntityRef = new() { Names = new() }, IsMounted = true };
			ActorHasCollision = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
