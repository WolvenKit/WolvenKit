using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SpiderbotOrderDeviceEvent : redEvent
	{
		private CWeakHandle<gameObject> _target;
		private CWeakHandle<gameObject> _overrideMovementTarget;

		[Ordinal(0)] 
		[RED("target")] 
		public CWeakHandle<gameObject> Target
		{
			get => GetProperty(ref _target);
			set => SetProperty(ref _target, value);
		}

		[Ordinal(1)] 
		[RED("overrideMovementTarget")] 
		public CWeakHandle<gameObject> OverrideMovementTarget
		{
			get => GetProperty(ref _overrideMovementTarget);
			set => SetProperty(ref _overrideMovementTarget, value);
		}
	}
}
