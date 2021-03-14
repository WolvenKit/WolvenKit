using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnWalkToEvent : scnSceneEvent
	{
		private scnActorId _actorId;
		private CName _targetWaypointTag;
		private CBool _usePathfinding;

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
		[RED("targetWaypointTag")] 
		public CName TargetWaypointTag
		{
			get
			{
				if (_targetWaypointTag == null)
				{
					_targetWaypointTag = (CName) CR2WTypeManager.Create("CName", "targetWaypointTag", cr2w, this);
				}
				return _targetWaypointTag;
			}
			set
			{
				if (_targetWaypointTag == value)
				{
					return;
				}
				_targetWaypointTag = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("usePathfinding")] 
		public CBool UsePathfinding
		{
			get
			{
				if (_usePathfinding == null)
				{
					_usePathfinding = (CBool) CR2WTypeManager.Create("Bool", "usePathfinding", cr2w, this);
				}
				return _usePathfinding;
			}
			set
			{
				if (_usePathfinding == value)
				{
					return;
				}
				_usePathfinding = value;
				PropertySet(this);
			}
		}

		public scnWalkToEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
