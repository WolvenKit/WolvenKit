using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class UI_NotificationsDef : gamebbScriptDefinition
	{
		private gamebbScriptID_Variant _warningMessage;
		private gamebbScriptID_Variant _onscreenMessage;

		[Ordinal(0)] 
		[RED("WarningMessage")] 
		public gamebbScriptID_Variant WarningMessage
		{
			get => GetProperty(ref _warningMessage);
			set => SetProperty(ref _warningMessage, value);
		}

		[Ordinal(1)] 
		[RED("OnscreenMessage")] 
		public gamebbScriptID_Variant OnscreenMessage
		{
			get => GetProperty(ref _onscreenMessage);
			set => SetProperty(ref _onscreenMessage, value);
		}

		public UI_NotificationsDef(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
