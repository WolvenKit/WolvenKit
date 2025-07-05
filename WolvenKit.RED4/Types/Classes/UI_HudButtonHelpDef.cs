using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class UI_HudButtonHelpDef : gamebbScriptDefinition
	{
		[Ordinal(0)] 
		[RED("button1_Text")] 
		public gamebbScriptID_String Button1_Text
		{
			get => GetPropertyValue<gamebbScriptID_String>();
			set => SetPropertyValue<gamebbScriptID_String>(value);
		}

		[Ordinal(1)] 
		[RED("button1_Icon")] 
		public gamebbScriptID_CName Button1_Icon
		{
			get => GetPropertyValue<gamebbScriptID_CName>();
			set => SetPropertyValue<gamebbScriptID_CName>(value);
		}

		[Ordinal(2)] 
		[RED("button2_Text")] 
		public gamebbScriptID_String Button2_Text
		{
			get => GetPropertyValue<gamebbScriptID_String>();
			set => SetPropertyValue<gamebbScriptID_String>(value);
		}

		[Ordinal(3)] 
		[RED("button2_Icon")] 
		public gamebbScriptID_CName Button2_Icon
		{
			get => GetPropertyValue<gamebbScriptID_CName>();
			set => SetPropertyValue<gamebbScriptID_CName>(value);
		}

		[Ordinal(4)] 
		[RED("button3_Text")] 
		public gamebbScriptID_String Button3_Text
		{
			get => GetPropertyValue<gamebbScriptID_String>();
			set => SetPropertyValue<gamebbScriptID_String>(value);
		}

		[Ordinal(5)] 
		[RED("button3_Icon")] 
		public gamebbScriptID_CName Button3_Icon
		{
			get => GetPropertyValue<gamebbScriptID_CName>();
			set => SetPropertyValue<gamebbScriptID_CName>(value);
		}

		public UI_HudButtonHelpDef()
		{
			Button1_Text = new gamebbScriptID_String();
			Button1_Icon = new gamebbScriptID_CName();
			Button2_Text = new gamebbScriptID_String();
			Button2_Icon = new gamebbScriptID_CName();
			Button3_Text = new gamebbScriptID_String();
			Button3_Icon = new gamebbScriptID_CName();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
