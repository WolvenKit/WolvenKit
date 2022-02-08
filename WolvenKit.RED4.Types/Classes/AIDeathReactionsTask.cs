using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIDeathReactionsTask : AIbehaviortaskScript
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
	}
}
