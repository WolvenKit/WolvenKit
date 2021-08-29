using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CentaurShieldLookatController : AILookatTask
	{
		private CHandle<entLookAtAddEvent> _mainShieldLookat;
		private CBool _mainShieldlookatActive;
		private CWeakHandle<gameObject> _currentLookatTarget;
		private CWeakHandle<gameObject> _shieldTarget;
		private CWeakHandle<gameIBlackboard> _centaurBlackboard;
		private CFloat _shieldTargetTimeStamp;

		[Ordinal(0)] 
		[RED("mainShieldLookat")] 
		public CHandle<entLookAtAddEvent> MainShieldLookat
		{
			get => GetProperty(ref _mainShieldLookat);
			set => SetProperty(ref _mainShieldLookat, value);
		}

		[Ordinal(1)] 
		[RED("mainShieldlookatActive")] 
		public CBool MainShieldlookatActive
		{
			get => GetProperty(ref _mainShieldlookatActive);
			set => SetProperty(ref _mainShieldlookatActive, value);
		}

		[Ordinal(2)] 
		[RED("currentLookatTarget")] 
		public CWeakHandle<gameObject> CurrentLookatTarget
		{
			get => GetProperty(ref _currentLookatTarget);
			set => SetProperty(ref _currentLookatTarget, value);
		}

		[Ordinal(3)] 
		[RED("shieldTarget")] 
		public CWeakHandle<gameObject> ShieldTarget
		{
			get => GetProperty(ref _shieldTarget);
			set => SetProperty(ref _shieldTarget, value);
		}

		[Ordinal(4)] 
		[RED("centaurBlackboard")] 
		public CWeakHandle<gameIBlackboard> CentaurBlackboard
		{
			get => GetProperty(ref _centaurBlackboard);
			set => SetProperty(ref _centaurBlackboard, value);
		}

		[Ordinal(5)] 
		[RED("shieldTargetTimeStamp")] 
		public CFloat ShieldTargetTimeStamp
		{
			get => GetProperty(ref _shieldTargetTimeStamp);
			set => SetProperty(ref _shieldTargetTimeStamp, value);
		}
	}
}
