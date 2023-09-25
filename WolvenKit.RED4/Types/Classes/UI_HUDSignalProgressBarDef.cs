using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class UI_HUDSignalProgressBarDef : gamebbScriptDefinition
	{
		[Ordinal(0)] 
		[RED("TimerID")] 
		public gamebbScriptID_Variant TimerID
		{
			get => GetPropertyValue<gamebbScriptID_Variant>();
			set => SetPropertyValue<gamebbScriptID_Variant>(value);
		}

		[Ordinal(1)] 
		[RED("State")] 
		public gamebbScriptID_Uint32 State
		{
			get => GetPropertyValue<gamebbScriptID_Uint32>();
			set => SetPropertyValue<gamebbScriptID_Uint32>(value);
		}

		[Ordinal(2)] 
		[RED("Progress")] 
		public gamebbScriptID_Float Progress
		{
			get => GetPropertyValue<gamebbScriptID_Float>();
			set => SetPropertyValue<gamebbScriptID_Float>(value);
		}

		[Ordinal(3)] 
		[RED("SignalStrength")] 
		public gamebbScriptID_Float SignalStrength
		{
			get => GetPropertyValue<gamebbScriptID_Float>();
			set => SetPropertyValue<gamebbScriptID_Float>(value);
		}

		[Ordinal(4)] 
		[RED("Orientation")] 
		public gamebbScriptID_Uint32 Orientation
		{
			get => GetPropertyValue<gamebbScriptID_Uint32>();
			set => SetPropertyValue<gamebbScriptID_Uint32>(value);
		}

		[Ordinal(5)] 
		[RED("Appearance")] 
		public gamebbScriptID_CName Appearance
		{
			get => GetPropertyValue<gamebbScriptID_CName>();
			set => SetPropertyValue<gamebbScriptID_CName>(value);
		}

		public UI_HUDSignalProgressBarDef()
		{
			TimerID = new gamebbScriptID_Variant();
			State = new gamebbScriptID_Uint32();
			Progress = new gamebbScriptID_Float();
			SignalStrength = new gamebbScriptID_Float();
			Orientation = new gamebbScriptID_Uint32();
			Appearance = new gamebbScriptID_CName();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
