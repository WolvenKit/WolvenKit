using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CycleRoundEvents : WeaponEventsTransition
	{
		private CBool _hasBlockedAiming;
		private CFloat _blockAimStart;
		private CFloat _blockAimDuration;

		[Ordinal(3)] 
		[RED("hasBlockedAiming")] 
		public CBool HasBlockedAiming
		{
			get => GetProperty(ref _hasBlockedAiming);
			set => SetProperty(ref _hasBlockedAiming, value);
		}

		[Ordinal(4)] 
		[RED("blockAimStart")] 
		public CFloat BlockAimStart
		{
			get => GetProperty(ref _blockAimStart);
			set => SetProperty(ref _blockAimStart, value);
		}

		[Ordinal(5)] 
		[RED("blockAimDuration")] 
		public CFloat BlockAimDuration
		{
			get => GetProperty(ref _blockAimDuration);
			set => SetProperty(ref _blockAimDuration, value);
		}
	}
}
