using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class UI_PointOfNoReturnRewardScreenDef : gamebbScriptDefinition
	{
		private gamebbScriptID_Variant _rewards;

		[Ordinal(0)] 
		[RED("Rewards")] 
		public gamebbScriptID_Variant Rewards
		{
			get => GetProperty(ref _rewards);
			set => SetProperty(ref _rewards, value);
		}
	}
}
