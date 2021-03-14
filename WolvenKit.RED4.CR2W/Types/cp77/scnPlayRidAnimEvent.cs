using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnPlayRidAnimEvent : scnPlayFPPControlAnimEvent
	{
		private CUInt32 _ridVersinon;
		private scnRidAnimationSRRefId _animResRefId;
		private scnMarker _animOriginMarker;
		private CEnum<scnRidActorPlacement> _actorPlacement;
		private CBool _actorHasCollision;
		private CFloat _blendInTrajectoryBone;

		[Ordinal(31)] 
		[RED("ridVersinon")] 
		public CUInt32 RidVersinon
		{
			get
			{
				if (_ridVersinon == null)
				{
					_ridVersinon = (CUInt32) CR2WTypeManager.Create("Uint32", "ridVersinon", cr2w, this);
				}
				return _ridVersinon;
			}
			set
			{
				if (_ridVersinon == value)
				{
					return;
				}
				_ridVersinon = value;
				PropertySet(this);
			}
		}

		[Ordinal(32)] 
		[RED("animResRefId")] 
		public scnRidAnimationSRRefId AnimResRefId
		{
			get
			{
				if (_animResRefId == null)
				{
					_animResRefId = (scnRidAnimationSRRefId) CR2WTypeManager.Create("scnRidAnimationSRRefId", "animResRefId", cr2w, this);
				}
				return _animResRefId;
			}
			set
			{
				if (_animResRefId == value)
				{
					return;
				}
				_animResRefId = value;
				PropertySet(this);
			}
		}

		[Ordinal(33)] 
		[RED("animOriginMarker")] 
		public scnMarker AnimOriginMarker
		{
			get
			{
				if (_animOriginMarker == null)
				{
					_animOriginMarker = (scnMarker) CR2WTypeManager.Create("scnMarker", "animOriginMarker", cr2w, this);
				}
				return _animOriginMarker;
			}
			set
			{
				if (_animOriginMarker == value)
				{
					return;
				}
				_animOriginMarker = value;
				PropertySet(this);
			}
		}

		[Ordinal(34)] 
		[RED("actorPlacement")] 
		public CEnum<scnRidActorPlacement> ActorPlacement
		{
			get
			{
				if (_actorPlacement == null)
				{
					_actorPlacement = (CEnum<scnRidActorPlacement>) CR2WTypeManager.Create("scnRidActorPlacement", "actorPlacement", cr2w, this);
				}
				return _actorPlacement;
			}
			set
			{
				if (_actorPlacement == value)
				{
					return;
				}
				_actorPlacement = value;
				PropertySet(this);
			}
		}

		[Ordinal(35)] 
		[RED("actorHasCollision")] 
		public CBool ActorHasCollision
		{
			get
			{
				if (_actorHasCollision == null)
				{
					_actorHasCollision = (CBool) CR2WTypeManager.Create("Bool", "actorHasCollision", cr2w, this);
				}
				return _actorHasCollision;
			}
			set
			{
				if (_actorHasCollision == value)
				{
					return;
				}
				_actorHasCollision = value;
				PropertySet(this);
			}
		}

		[Ordinal(36)] 
		[RED("blendInTrajectoryBone")] 
		public CFloat BlendInTrajectoryBone
		{
			get
			{
				if (_blendInTrajectoryBone == null)
				{
					_blendInTrajectoryBone = (CFloat) CR2WTypeManager.Create("Float", "blendInTrajectoryBone", cr2w, this);
				}
				return _blendInTrajectoryBone;
			}
			set
			{
				if (_blendInTrajectoryBone == value)
				{
					return;
				}
				_blendInTrajectoryBone = value;
				PropertySet(this);
			}
		}

		public scnPlayRidAnimEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
