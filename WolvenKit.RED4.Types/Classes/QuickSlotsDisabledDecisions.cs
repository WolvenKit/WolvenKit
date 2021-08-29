using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class QuickSlotsDisabledDecisions : QuickSlotsDecisions
	{
		private CWeakHandle<gameObject> _executionOwner;
		private CHandle<DefaultTransitionStatusEffectListener> _statusEffectListener;
		private CBool _hasStatusEffect;

		[Ordinal(0)] 
		[RED("executionOwner")] 
		public CWeakHandle<gameObject> ExecutionOwner
		{
			get => GetProperty(ref _executionOwner);
			set => SetProperty(ref _executionOwner, value);
		}

		[Ordinal(1)] 
		[RED("statusEffectListener")] 
		public CHandle<DefaultTransitionStatusEffectListener> StatusEffectListener
		{
			get => GetProperty(ref _statusEffectListener);
			set => SetProperty(ref _statusEffectListener, value);
		}

		[Ordinal(2)] 
		[RED("hasStatusEffect")] 
		public CBool HasStatusEffect
		{
			get => GetProperty(ref _hasStatusEffect);
			set => SetProperty(ref _hasStatusEffect, value);
		}
	}
}
