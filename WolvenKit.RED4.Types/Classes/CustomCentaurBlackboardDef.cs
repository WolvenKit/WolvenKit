using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CustomCentaurBlackboardDef : CustomBlackboardDef
	{
		private gamebbScriptID_Int32 _shieldState;
		private gamebbScriptID_Float _weakSpotHitTimeStamp;
		private gamebbScriptID_EntityID _shieldTarget;
		private gamebbScriptID_Float _woundedStateHPThreshold;

		[Ordinal(0)] 
		[RED("ShieldState")] 
		public gamebbScriptID_Int32 ShieldState
		{
			get => GetProperty(ref _shieldState);
			set => SetProperty(ref _shieldState, value);
		}

		[Ordinal(1)] 
		[RED("WeakSpotHitTimeStamp")] 
		public gamebbScriptID_Float WeakSpotHitTimeStamp
		{
			get => GetProperty(ref _weakSpotHitTimeStamp);
			set => SetProperty(ref _weakSpotHitTimeStamp, value);
		}

		[Ordinal(2)] 
		[RED("ShieldTarget")] 
		public gamebbScriptID_EntityID ShieldTarget
		{
			get => GetProperty(ref _shieldTarget);
			set => SetProperty(ref _shieldTarget, value);
		}

		[Ordinal(3)] 
		[RED("WoundedStateHPThreshold")] 
		public gamebbScriptID_Float WoundedStateHPThreshold
		{
			get => GetProperty(ref _woundedStateHPThreshold);
			set => SetProperty(ref _woundedStateHPThreshold, value);
		}
	}
}
