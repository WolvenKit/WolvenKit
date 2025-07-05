using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public abstract partial class AIDeathReactionsTask : AIbehaviortaskScript
	{
		[Ordinal(0)] 
		[RED("fastForwardAnimation")] 
		public CHandle<AIArgumentMapping> FastForwardAnimation
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(1)] 
		[RED("hitData")] 
		public CHandle<animAnimFeature_HitReactionsData> HitData
		{
			get => GetPropertyValue<CHandle<animAnimFeature_HitReactionsData>>();
			set => SetPropertyValue<CHandle<animAnimFeature_HitReactionsData>>(value);
		}

		[Ordinal(2)] 
		[RED("hitReactionAction")] 
		public CHandle<ActionHitReactionScriptProxy> HitReactionAction
		{
			get => GetPropertyValue<CHandle<ActionHitReactionScriptProxy>>();
			set => SetPropertyValue<CHandle<ActionHitReactionScriptProxy>>(value);
		}

		[Ordinal(3)] 
		[RED("previousRagdollTimeStamp")] 
		public CFloat PreviousRagdollTimeStamp
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(4)] 
		[RED("deathHasBeenPlayed")] 
		public CBool DeathHasBeenPlayed
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(5)] 
		[RED("updateFrame")] 
		public CInt32 UpdateFrame
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public AIDeathReactionsTask()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
