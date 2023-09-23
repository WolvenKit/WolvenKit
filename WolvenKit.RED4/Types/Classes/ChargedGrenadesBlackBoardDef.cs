using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ChargedGrenadesBlackBoardDef : gamebbScriptDefinition
	{
		[Ordinal(0)] 
		[RED("curentGrenadeCharges")] 
		public gamebbScriptID_Int32 CurentGrenadeCharges
		{
			get => GetPropertyValue<gamebbScriptID_Int32>();
			set => SetPropertyValue<gamebbScriptID_Int32>(value);
		}

		[Ordinal(1)] 
		[RED("maxGrenadeCharges")] 
		public gamebbScriptID_Int32 MaxGrenadeCharges
		{
			get => GetPropertyValue<gamebbScriptID_Int32>();
			set => SetPropertyValue<gamebbScriptID_Int32>(value);
		}

		[Ordinal(2)] 
		[RED("rechargeGoingOn")] 
		public gamebbScriptID_Bool RechargeGoingOn
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		public ChargedGrenadesBlackBoardDef()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
