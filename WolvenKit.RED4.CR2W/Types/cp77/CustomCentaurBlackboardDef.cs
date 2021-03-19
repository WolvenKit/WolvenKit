using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CustomCentaurBlackboardDef : CustomBlackboardDef
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

		public CustomCentaurBlackboardDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
