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

		public scnSectionInternalsActorBehavior(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
