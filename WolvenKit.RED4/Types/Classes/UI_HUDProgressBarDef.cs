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
		[RED("BottomText")] 
		public gamebbScriptID_String BottomText
		{
			get => GetPropertyValue<gamebbScriptID_String>();
			set => SetPropertyValue<gamebbScriptID_String>(value);
		}

		[Ordinal(3)] 
		[RED("CompletedText")] 
		public gamebbScriptID_String CompletedText
		{
			get => GetPropertyValue<gamebbScriptID_String>();
			set => SetPropertyValue<gamebbScriptID_String>(value);
		}

		[Ordinal(4)] 
		[RED("FailedText")] 
		public gamebbScriptID_String FailedText
		{
			get => GetPropertyValue<gamebbScriptID_String>();
			set => SetPropertyValue<gamebbScriptID_String>(value);
		}

		[Ordinal(5)] 
		[RED("Active")] 
		public gamebbScriptID_Bool Active
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		[Ordinal(6)] 
		[RED("Progress")] 
		public gamebbScriptID_Float Progress
		{
			get => GetPropertyValue<gamebbScriptID_Float>();
			set => SetPropertyValue<gamebbScriptID_Float>(value);
		}

		[Ordinal(7)] 
		[RED("ProgressBump")] 
		public gamebbScriptID_Float ProgressBump
		{
			get => GetPropertyValue<gamebbScriptID_Float>();
			set => SetPropertyValue<gamebbScriptID_Float>(value);
		}

		[Ordinal(8)] 
		[RED("MessageType")] 
		public gamebbScriptID_Variant MessageType
		{
			get => GetPropertyValue<gamebbScriptID_Variant>();
			set => SetPropertyValue<gamebbScriptID_Variant>(value);
		}

		public UI_HUDProgressBarDef()
		{
			TimerID = new gamebbScriptID_Variant();
			Header = new gamebbScriptID_String();
			BottomText = new gamebbScriptID_String();
			CompletedText = new gamebbScriptID_String();
			FailedText = new gamebbScriptID_String();
			Active = new gamebbScriptID_Bool();
			Progress = new gamebbScriptID_Float();
			ProgressBump = new gamebbScriptID_Float();
			MessageType = new gamebbScriptID_Variant();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
