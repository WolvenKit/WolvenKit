using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIDeathReactionsTask : AIbehaviortaskScript
	{
		private CHandle<AIArgumentMapping> _fastForwardAnimation;
		private CHandle<animAnimFeature_HitReactionsData> _hitData;
		private CHandle<ActionHitReactionScriptProxy> _hitReactionAction;

		[Ordinal(0)] 
		[RED("fastForwardAnimation")] 
		public CHandle<AIArgumentMapping> FastForwardAnimation
		{
			get => GetProperty(ref _fastForwardAnimation);
			set => SetProperty(ref _fastForwardAnimation, value);
		}

		[Ordinal(1)] 
		[RED("hitData")] 
		public CHandle<animAnimFeature_HitReactionsData> HitData
		{
			get => GetProperty(ref _hitData);
			set => SetProperty(ref _hitData, value);
		}

		[Ordinal(2)] 
		[RED("hitReactionAction")] 
		public CHandle<ActionHitReactionScriptProxy> HitReactionAction
		{
			get => GetProperty(ref _hitReactionAction);
			set => SetProperty(ref _hitReactionAction, value);
		}
	}
}
