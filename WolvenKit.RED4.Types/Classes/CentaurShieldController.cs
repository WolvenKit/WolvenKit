using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CentaurShieldController : AICustomComponents
	{
		private CBool _startWithShieldActive;
		private CName _animFeatureName;
		private CName _shieldDestroyedModifierName;
		private CEnum<ECentaurShieldState> _shieldState;
		private CHandle<gameIBlackboard> _centaurBlackboard;

		[Ordinal(5)] 
		[RED("startWithShieldActive")] 
		public CBool StartWithShieldActive
		{
			get => GetProperty(ref _startWithShieldActive);
			set => SetProperty(ref _startWithShieldActive, value);
		}

		[Ordinal(6)] 
		[RED("animFeatureName")] 
		public CName AnimFeatureName
		{
			get => GetProperty(ref _animFeatureName);
			set => SetProperty(ref _animFeatureName, value);
		}

		[Ordinal(7)] 
		[RED("shieldDestroyedModifierName")] 
		public CName ShieldDestroyedModifierName
		{
			get => GetProperty(ref _shieldDestroyedModifierName);
			set => SetProperty(ref _shieldDestroyedModifierName, value);
		}

		[Ordinal(8)] 
		[RED("shieldState")] 
		public CEnum<ECentaurShieldState> ShieldState
		{
			get => GetProperty(ref _shieldState);
			set => SetProperty(ref _shieldState, value);
		}

		[Ordinal(9)] 
		[RED("centaurBlackboard")] 
		public CHandle<gameIBlackboard> CentaurBlackboard
		{
			get => GetProperty(ref _centaurBlackboard);
			set => SetProperty(ref _centaurBlackboard, value);
		}
	}
}
