using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class UI_WantedBarDef : gamebbScriptDefinition
	{
		[Ordinal(0)] 
		[RED("CurrentBounty")] 
		public gamebbScriptID_Int32 CurrentBounty
		{
			get => GetPropertyValue<gamebbScriptID_Int32>();
			set => SetPropertyValue<gamebbScriptID_Int32>(value);
		}

		[Ordinal(1)] 
		[RED("CurrentWantedLevel")] 
		public gamebbScriptID_Int32 CurrentWantedLevel
		{
			get => GetPropertyValue<gamebbScriptID_Int32>();
			set => SetPropertyValue<gamebbScriptID_Int32>(value);
		}

		public UI_WantedBarDef()
		{
			CurrentBounty = new gamebbScriptID_Int32();
			CurrentWantedLevel = new gamebbScriptID_Int32();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
