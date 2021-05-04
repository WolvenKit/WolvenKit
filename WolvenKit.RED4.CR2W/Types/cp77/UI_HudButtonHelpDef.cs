using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class UI_HudButtonHelpDef : gamebbScriptDefinition
	{
		private gamebbScriptID_String _button1_Text;
		private gamebbScriptID_CName _button1_Icon;
		private gamebbScriptID_String _button2_Text;
		private gamebbScriptID_CName _button2_Icon;
		private gamebbScriptID_String _button3_Text;
		private gamebbScriptID_CName _button3_Icon;

		[Ordinal(0)] 
		[RED("button1_Text")] 
		public gamebbScriptID_String Button1_Text
		{
			get => GetProperty(ref _button1_Text);
			set => SetProperty(ref _button1_Text, value);
		}

		[Ordinal(1)] 
		[RED("button1_Icon")] 
		public gamebbScriptID_CName Button1_Icon
		{
			get => GetProperty(ref _button1_Icon);
			set => SetProperty(ref _button1_Icon, value);
		}

		[Ordinal(2)] 
		[RED("button2_Text")] 
		public gamebbScriptID_String Button2_Text
		{
			get => GetProperty(ref _button2_Text);
			set => SetProperty(ref _button2_Text, value);
		}

		[Ordinal(3)] 
		[RED("button2_Icon")] 
		public gamebbScriptID_CName Button2_Icon
		{
			get => GetProperty(ref _button2_Icon);
			set => SetProperty(ref _button2_Icon, value);
		}

		[Ordinal(4)] 
		[RED("button3_Text")] 
		public gamebbScriptID_String Button3_Text
		{
			get => GetProperty(ref _button3_Text);
			set => SetProperty(ref _button3_Text, value);
		}

		[Ordinal(5)] 
		[RED("button3_Icon")] 
		public gamebbScriptID_CName Button3_Icon
		{
			get => GetProperty(ref _button3_Icon);
			set => SetProperty(ref _button3_Icon, value);
		}

		public UI_HudButtonHelpDef(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
