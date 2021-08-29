using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameRagdollHitEvent : gameeventsHitEvent
	{
		private CFloat _impactForce;
		private CFloat _speedDelta;
		private CFloat _heightDelta;

		[Ordinal(12)] 
		[RED("impactForce")] 
		public CFloat ImpactForce
		{
			get => GetProperty(ref _impactForce);
			set => SetProperty(ref _impactForce, value);
		}

		[Ordinal(13)] 
		[RED("speedDelta")] 
		public CFloat SpeedDelta
		{
			get => GetProperty(ref _speedDelta);
			set => SetProperty(ref _speedDelta, value);
		}

		[Ordinal(14)] 
		[RED("heightDelta")] 
		public CFloat HeightDelta
		{
			get => GetProperty(ref _heightDelta);
			set => SetProperty(ref _heightDelta, value);
		}
	}
}
