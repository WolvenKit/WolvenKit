using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class scnWalkToEvent : scnSceneEvent
	{
		[Ordinal(6)] 
		[RED("actorId")] 
		public scnActorId ActorId
		{
			get => GetPropertyValue<scnActorId>();
			set => SetPropertyValue<scnActorId>(value);
		}

		[Ordinal(7)] 
		[RED("targetWaypointTag")] 
		public CName TargetWaypointTag
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(8)] 
		[RED("usePathfinding")] 
		public CBool UsePathfinding
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public scnWalkToEvent()
		{
			Id = new scnSceneEventId { Id = long.MaxValue };
			ActorId = new scnActorId { Id = uint.MaxValue };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
