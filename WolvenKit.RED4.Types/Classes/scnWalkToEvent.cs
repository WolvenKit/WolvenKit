using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class scnWalkToEvent : scnSceneEvent
	{
		private scnActorId _actorId;
		private CName _targetWaypointTag;
		private CBool _usePathfinding;

		[Ordinal(6)] 
		[RED("actorId")] 
		public scnActorId ActorId
		{
			get => GetProperty(ref _actorId);
			set => SetProperty(ref _actorId, value);
		}

		[Ordinal(7)] 
		[RED("targetWaypointTag")] 
		public CName TargetWaypointTag
		{
			get => GetProperty(ref _targetWaypointTag);
			set => SetProperty(ref _targetWaypointTag, value);
		}

		[Ordinal(8)] 
		[RED("usePathfinding")] 
		public CBool UsePathfinding
		{
			get => GetProperty(ref _usePathfinding);
			set => SetProperty(ref _usePathfinding, value);
		}
	}
}
