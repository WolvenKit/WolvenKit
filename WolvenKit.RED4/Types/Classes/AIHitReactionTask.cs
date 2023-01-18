using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AIHitReactionTask : AIbehaviortaskScript
	{
		[Ordinal(0)] 
		[RED("activationTimeStamp")] 
		public CFloat ActivationTimeStamp
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(1)] 
		[RED("reactionDuration")] 
		public CFloat ReactionDuration
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("hitReactionAction")] 
		public CHandle<ActionHitReactionScriptProxy> HitReactionAction
		{
			get => GetPropertyValue<CHandle<ActionHitReactionScriptProxy>>();
			set => SetPropertyValue<CHandle<ActionHitReactionScriptProxy>>(value);
		}

		[Ordinal(3)] 
		[RED("hitReactionType")] 
		public CEnum<animHitReactionType> HitReactionType
		{
			get => GetPropertyValue<CEnum<animHitReactionType>>();
			set => SetPropertyValue<CEnum<animHitReactionType>>(value);
		}

		public AIHitReactionTask()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
