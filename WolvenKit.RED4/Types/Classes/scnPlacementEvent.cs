using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class scnPlacementEvent : scnSceneEvent
	{
		[Ordinal(6)] 
		[RED("actorId")] 
		public scnActorId ActorId
		{
			get => GetPropertyValue<scnActorId>();
			set => SetPropertyValue<scnActorId>(value);
		}

		[Ordinal(7)] 
		[RED("targetWaypoint")] 
		public scnMarker TargetWaypoint
		{
			get => GetPropertyValue<scnMarker>();
			set => SetPropertyValue<scnMarker>(value);
		}

		public scnPlacementEvent()
		{
			Id = new scnSceneEventId();
			ActorId = new scnActorId();
			TargetWaypoint = new scnMarker();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
