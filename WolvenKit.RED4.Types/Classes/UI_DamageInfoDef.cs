using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class UI_DamageInfoDef : gamebbScriptDefinition
	{
		private gamebbScriptID_Variant _damageList;
		private gamebbScriptID_Variant _killList;
		private gamebbScriptID_Variant _digitsMode;
		private gamebbScriptID_Bool _digitsInterpolationOn;
		private gamebbScriptID_Variant _digitsStickingMode;
		private gamebbScriptID_Bool _hitIndicatorEnabled;
		private gamebbScriptID_Variant _dmgIndicatorMode;

		[Ordinal(0)] 
		[RED("DamageList")] 
		public gamebbScriptID_Variant DamageList
		{
			get => GetProperty(ref _damageList);
			set => SetProperty(ref _damageList, value);
		}

		[Ordinal(1)] 
		[RED("KillList")] 
		public gamebbScriptID_Variant KillList
		{
			get => GetProperty(ref _killList);
			set => SetProperty(ref _killList, value);
		}

		[Ordinal(2)] 
		[RED("DigitsMode")] 
		public gamebbScriptID_Variant DigitsMode
		{
			get => GetProperty(ref _digitsMode);
			set => SetProperty(ref _digitsMode, value);
		}

		[Ordinal(3)] 
		[RED("DigitsInterpolationOn")] 
		public gamebbScriptID_Bool DigitsInterpolationOn
		{
			get => GetProperty(ref _digitsInterpolationOn);
			set => SetProperty(ref _digitsInterpolationOn, value);
		}

		[Ordinal(4)] 
		[RED("DigitsStickingMode")] 
		public gamebbScriptID_Variant DigitsStickingMode
		{
			get => GetProperty(ref _digitsStickingMode);
			set => SetProperty(ref _digitsStickingMode, value);
		}

		[Ordinal(5)] 
		[RED("HitIndicatorEnabled")] 
		public gamebbScriptID_Bool HitIndicatorEnabled
		{
			get => GetProperty(ref _hitIndicatorEnabled);
			set => SetProperty(ref _hitIndicatorEnabled, value);
		}

		[Ordinal(6)] 
		[RED("DmgIndicatorMode")] 
		public gamebbScriptID_Variant DmgIndicatorMode
		{
			get => GetProperty(ref _dmgIndicatorMode);
			set => SetProperty(ref _dmgIndicatorMode, value);
		}
	}
}
