using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class UI_DamageInfoDef : gamebbScriptDefinition
	{
		[Ordinal(0)] 
		[RED("DamageList")] 
		public gamebbScriptID_Variant DamageList
		{
			get => GetPropertyValue<gamebbScriptID_Variant>();
			set => SetPropertyValue<gamebbScriptID_Variant>(value);
		}

		[Ordinal(1)] 
		[RED("KillList")] 
		public gamebbScriptID_Variant KillList
		{
			get => GetPropertyValue<gamebbScriptID_Variant>();
			set => SetPropertyValue<gamebbScriptID_Variant>(value);
		}

		[Ordinal(2)] 
		[RED("DigitsMode")] 
		public gamebbScriptID_Variant DigitsMode
		{
			get => GetPropertyValue<gamebbScriptID_Variant>();
			set => SetPropertyValue<gamebbScriptID_Variant>(value);
		}

		[Ordinal(3)] 
		[RED("DigitsInterpolationOn")] 
		public gamebbScriptID_Bool DigitsInterpolationOn
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		[Ordinal(4)] 
		[RED("DigitsStickingMode")] 
		public gamebbScriptID_Variant DigitsStickingMode
		{
			get => GetPropertyValue<gamebbScriptID_Variant>();
			set => SetPropertyValue<gamebbScriptID_Variant>(value);
		}

		[Ordinal(5)] 
		[RED("HitIndicatorEnabled")] 
		public gamebbScriptID_Bool HitIndicatorEnabled
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		[Ordinal(6)] 
		[RED("DmgIndicatorMode")] 
		public gamebbScriptID_Variant DmgIndicatorMode
		{
			get => GetPropertyValue<gamebbScriptID_Variant>();
			set => SetPropertyValue<gamebbScriptID_Variant>(value);
		}

		public UI_DamageInfoDef()
		{
			DamageList = new gamebbScriptID_Variant();
			KillList = new gamebbScriptID_Variant();
			DigitsMode = new gamebbScriptID_Variant();
			DigitsInterpolationOn = new gamebbScriptID_Bool();
			DigitsStickingMode = new gamebbScriptID_Variant();
			HitIndicatorEnabled = new gamebbScriptID_Bool();
			DmgIndicatorMode = new gamebbScriptID_Variant();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
