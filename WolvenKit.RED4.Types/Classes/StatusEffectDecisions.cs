using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class StatusEffectDecisions : LocomotionGroundDecisions
	{
		private CWeakHandle<gameObject> _executionOwner;
		private CHandle<DefaultTransitionStatusEffectListener> _statusEffectListener;
		private CString _statusEffectEnumName;

		[Ordinal(3)] 
		[RED("executionOwner")] 
		public CWeakHandle<gameObject> ExecutionOwner
		{
			get => GetProperty(ref _executionOwner);
			set => SetProperty(ref _executionOwner, value);
		}

		[Ordinal(4)] 
		[RED("statusEffectListener")] 
		public CHandle<DefaultTransitionStatusEffectListener> StatusEffectListener
		{
			get => GetProperty(ref _statusEffectListener);
			set => SetProperty(ref _statusEffectListener, value);
		}

		[Ordinal(5)] 
		[RED("statusEffectEnumName")] 
		public CString StatusEffectEnumName
		{
			get => GetProperty(ref _statusEffectEnumName);
			set => SetProperty(ref _statusEffectEnumName, value);
		}
	}
}
