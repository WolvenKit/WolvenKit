using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class UI_PointOfNoReturnRewardScreenDef : gamebbScriptDefinition
	{
		[Ordinal(0)] 
		[RED("Rewards")] 
		public gamebbScriptID_Variant Rewards
		{
			get => GetPropertyValue<gamebbScriptID_Variant>();
			set => SetPropertyValue<gamebbScriptID_Variant>(value);
		}

		public UI_PointOfNoReturnRewardScreenDef()
		{
			Rewards = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
