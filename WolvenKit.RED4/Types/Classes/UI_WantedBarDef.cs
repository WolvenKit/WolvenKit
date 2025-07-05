using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class UI_WantedBarDef : gamebbScriptDefinition
	{
		[Ordinal(0)] 
		[RED("CurrentWantedLevel")] 
		public gamebbScriptID_Int32 CurrentWantedLevel
		{
			get => GetPropertyValue<gamebbScriptID_Int32>();
			set => SetPropertyValue<gamebbScriptID_Int32>(value);
		}

		[Ordinal(1)] 
		[RED("DeescalationStages")] 
		public gamebbScriptID_Int32 DeescalationStages
		{
			get => GetPropertyValue<gamebbScriptID_Int32>();
			set => SetPropertyValue<gamebbScriptID_Int32>(value);
		}

		[Ordinal(2)] 
		[RED("CurrentChaseState")] 
		public gamebbScriptID_CName CurrentChaseState
		{
			get => GetPropertyValue<gamebbScriptID_CName>();
			set => SetPropertyValue<gamebbScriptID_CName>(value);
		}

		[Ordinal(3)] 
		[RED("BlinkingStarsDurationTime")] 
		public gamebbScriptID_Float BlinkingStarsDurationTime
		{
			get => GetPropertyValue<gamebbScriptID_Float>();
			set => SetPropertyValue<gamebbScriptID_Float>(value);
		}

		[Ordinal(4)] 
		[RED("IsDogtown")] 
		public gamebbScriptID_Bool IsDogtown
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		public UI_WantedBarDef()
		{
			CurrentWantedLevel = new gamebbScriptID_Int32();
			DeescalationStages = new gamebbScriptID_Int32();
			CurrentChaseState = new gamebbScriptID_CName();
			BlinkingStarsDurationTime = new gamebbScriptID_Float();
			IsDogtown = new gamebbScriptID_Bool();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
