using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ChargedHealingBlackBoardDef : gamebbScriptDefinition
	{
		[Ordinal(0)] 
		[RED("currHealingItemCharge")] 
		public gamebbScriptID_Int32 CurrHealingItemCharge
		{
			get => GetPropertyValue<gamebbScriptID_Int32>();
			set => SetPropertyValue<gamebbScriptID_Int32>(value);
		}

		[Ordinal(1)] 
		[RED("rechargeGoingOn")] 
		public gamebbScriptID_Bool RechargeGoingOn
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		public ChargedHealingBlackBoardDef()
		{
			CurrHealingItemCharge = new gamebbScriptID_Int32();
			RechargeGoingOn = new gamebbScriptID_Bool();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
