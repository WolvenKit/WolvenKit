using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class HUDManagerDef : gamebbScriptDefinition
	{
		private gamebbScriptID_Bool _showHudHintMessege;
		private gamebbScriptID_String _hudHintMessegeContent;

		[Ordinal(0)] 
		[RED("ShowHudHintMessege")] 
		public gamebbScriptID_Bool ShowHudHintMessege
		{
			get => GetProperty(ref _showHudHintMessege);
			set => SetProperty(ref _showHudHintMessege, value);
		}

		[Ordinal(1)] 
		[RED("HudHintMessegeContent")] 
		public gamebbScriptID_String HudHintMessegeContent
		{
			get => GetProperty(ref _hudHintMessegeContent);
			set => SetProperty(ref _hudHintMessegeContent, value);
		}

		public HUDManagerDef(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
