using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class UI_HUDProgressBarDef : gamebbScriptDefinition
	{
		[Ordinal(0)] 
		[RED("TimerID")] 
		public gamebbScriptID_Variant TimerID
		{
			get => GetPropertyValue<gamebbScriptID_Variant>();
			set => SetPropertyValue<gamebbScriptID_Variant>(value);
		}

		[Ordinal(1)] 
		[RED("Header")] 
		public gamebbScriptID_String Header
		{
			get => GetPropertyValue<gamebbScriptID_String>();
			set => SetPropertyValue<gamebbScriptID_String>(value);
		}

		[Ordinal(2)] 
		[RED("Active")] 
		public gamebbScriptID_Bool Active
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		[Ordinal(3)] 
		[RED("Progress")] 
		public gamebbScriptID_Float Progress
		{
			get => GetPropertyValue<gamebbScriptID_Float>();
			set => SetPropertyValue<gamebbScriptID_Float>(value);
		}

		public UI_HUDProgressBarDef()
		{
			TimerID = new gamebbScriptID_Variant();
			Header = new gamebbScriptID_String();
			Active = new gamebbScriptID_Bool();
			Progress = new gamebbScriptID_Float();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
