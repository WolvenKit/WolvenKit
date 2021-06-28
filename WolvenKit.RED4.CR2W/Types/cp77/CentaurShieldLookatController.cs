using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CentaurShieldLookatController : AILookatTask
	{
		private CHandle<entLookAtAddEvent> _mainShieldLookat;
		private CBool _mainShieldlookatActive;
		private wCHandle<gameObject> _currentLookatTarget;
		private wCHandle<gameObject> _shieldTarget;
		private CHandle<gameIBlackboard> _centaurBlackboard;
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
		public wCHandle<gameObject> CurrentLookatTarget
		{
			get => GetProperty(ref _currentLookatTarget);
			set => SetProperty(ref _currentLookatTarget, value);
		}

		[Ordinal(3)] 
		[RED("shieldTarget")] 
		public wCHandle<gameObject> ShieldTarget
		{
			get => GetProperty(ref _shieldTarget);
			set => SetProperty(ref _shieldTarget, value);
		}

		[Ordinal(4)] 
		[RED("centaurBlackboard")] 
		public CHandle<gameIBlackboard> CentaurBlackboard
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

		public CentaurShieldLookatController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
