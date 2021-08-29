using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class audioMeleeAttackSettings : RedBaseClass
	{
		private CName _hitEvent;
		private CName _penetratingHitEvent;
		private CName _criticalHitEvent;
		private CName _killingHitEvent;

		[Ordinal(0)] 
		[RED("hitEvent")] 
		public CName HitEvent
		{
			get => GetProperty(ref _hitEvent);
			set => SetProperty(ref _hitEvent, value);
		}

		[Ordinal(1)] 
		[RED("penetratingHitEvent")] 
		public CName PenetratingHitEvent
		{
			get => GetProperty(ref _penetratingHitEvent);
			set => SetProperty(ref _penetratingHitEvent, value);
		}

		[Ordinal(2)] 
		[RED("criticalHitEvent")] 
		public CName CriticalHitEvent
		{
			get => GetProperty(ref _criticalHitEvent);
			set => SetProperty(ref _criticalHitEvent, value);
		}

		[Ordinal(3)] 
		[RED("killingHitEvent")] 
		public CName KillingHitEvent
		{
			get => GetProperty(ref _killingHitEvent);
			set => SetProperty(ref _killingHitEvent, value);
		}
	}
}
