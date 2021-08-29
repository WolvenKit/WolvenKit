using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class TimeDilationFocusModeEvents : TimeDilationEventsTransitions
	{
		private CFloat _timeDilation;
		private CFloat _playerDilation;
		private CName _easeInCurve;
		private CName _easeOutCurve;
		private CBool _applyTimeDilationToPlayer;
		private CName _timeDilationReason;

		[Ordinal(0)] 
		[RED("timeDilation")] 
		public CFloat TimeDilation
		{
			get => GetProperty(ref _timeDilation);
			set => SetProperty(ref _timeDilation, value);
		}

		[Ordinal(1)] 
		[RED("playerDilation")] 
		public CFloat PlayerDilation
		{
			get => GetProperty(ref _playerDilation);
			set => SetProperty(ref _playerDilation, value);
		}

		[Ordinal(2)] 
		[RED("easeInCurve")] 
		public CName EaseInCurve
		{
			get => GetProperty(ref _easeInCurve);
			set => SetProperty(ref _easeInCurve, value);
		}

		[Ordinal(3)] 
		[RED("easeOutCurve")] 
		public CName EaseOutCurve
		{
			get => GetProperty(ref _easeOutCurve);
			set => SetProperty(ref _easeOutCurve, value);
		}

		[Ordinal(4)] 
		[RED("applyTimeDilationToPlayer")] 
		public CBool ApplyTimeDilationToPlayer
		{
			get => GetProperty(ref _applyTimeDilationToPlayer);
			set => SetProperty(ref _applyTimeDilationToPlayer, value);
		}

		[Ordinal(5)] 
		[RED("timeDilationReason")] 
		public CName TimeDilationReason
		{
			get => GetProperty(ref _timeDilationReason);
			set => SetProperty(ref _timeDilationReason, value);
		}
	}
}
