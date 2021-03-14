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
			get
			{
				if (_actorId == null)
				{
					_actorId = (scnActorId) CR2WTypeManager.Create("scnActorId", "actorId", cr2w, this);
				}
				return _actorId;
			}
			set
			{
				if (_actorId == value)
				{
					return;
				}
				_actorId = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("targetWaypoint")] 
		public scnMarker TargetWaypoint
		{
			get
			{
				if (_targetWaypoint == null)
				{
					_targetWaypoint = (scnMarker) CR2WTypeManager.Create("scnMarker", "targetWaypoint", cr2w, this);
				}
				return _targetWaypoint;
			}
			set
			{
				if (_targetWaypoint == value)
				{
					return;
				}
				_targetWaypoint = value;
				PropertySet(this);
			}
		}

		public scnPlacementEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
