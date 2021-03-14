using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnSectionInternalsActorBehavior : CVariable
	{
		private scnActorId _actorId;
		private CEnum<scnSectionInternalsActorBehaviorMode> _behaviorMode;

		[Ordinal(0)] 
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

		[Ordinal(1)] 
		[RED("behaviorMode")] 
		public CEnum<scnSectionInternalsActorBehaviorMode> BehaviorMode
		{
			get
			{
				if (_behaviorMode == null)
				{
					_behaviorMode = (CEnum<scnSectionInternalsActorBehaviorMode>) CR2WTypeManager.Create("scnSectionInternalsActorBehaviorMode", "behaviorMode", cr2w, this);
				}
				return _behaviorMode;
			}
			set
			{
				if (_behaviorMode == value)
				{
					return;
				}
				_behaviorMode = value;
				PropertySet(this);
			}
		}

		public scnSectionInternalsActorBehavior(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
