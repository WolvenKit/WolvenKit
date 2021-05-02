using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIHitReactionTask : AIbehaviortaskScript
	{
		private CFloat _activationTimeStamp;
		private CFloat _reactionDuration;
		private CHandle<ActionHitReactionScriptProxy> _hitReactionAction;
		private CEnum<animHitReactionType> _hitReactionType;

		[Ordinal(0)] 
		[RED("activationTimeStamp")] 
		public CFloat ActivationTimeStamp
		{
			get => GetProperty(ref _activationTimeStamp);
			set => SetProperty(ref _activationTimeStamp, value);
		}

		[Ordinal(1)] 
		[RED("reactionDuration")] 
		public CFloat ReactionDuration
		{
			get => GetProperty(ref _reactionDuration);
			set => SetProperty(ref _reactionDuration, value);
		}

		[Ordinal(2)] 
		[RED("hitReactionAction")] 
		public CHandle<ActionHitReactionScriptProxy> HitReactionAction
		{
			get => GetProperty(ref _hitReactionAction);
			set => SetProperty(ref _hitReactionAction, value);
		}

		[Ordinal(3)] 
		[RED("hitReactionType")] 
		public CEnum<animHitReactionType> HitReactionType
		{
			get => GetProperty(ref _hitReactionType);
			set => SetProperty(ref _hitReactionType, value);
		}

		public AIHitReactionTask(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
