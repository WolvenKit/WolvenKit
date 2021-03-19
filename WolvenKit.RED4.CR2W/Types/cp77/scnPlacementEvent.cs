using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnPlacementEvent : scnSceneEvent
	{
		private scnActorId _actorId;
		private scnMarker _targetWaypoint;

		[Ordinal(6)] 
		[RED("actorId")] 
		public scnActorId ActorId
		{
			get => GetProperty(ref _actorId);
			set => SetProperty(ref _actorId, value);
		}

		[Ordinal(7)] 
		[RED("targetWaypoint")] 
		public scnMarker TargetWaypoint
		{
			get => GetProperty(ref _targetWaypoint);
			set => SetProperty(ref _targetWaypoint, value);
		}

		public scnPlacementEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
