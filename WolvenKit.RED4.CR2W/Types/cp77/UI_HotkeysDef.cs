using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class UI_HotkeysDef : gamebbScriptDefinition
	{
		private gamebbScriptID_Variant _modifiedHotkey;

		[Ordinal(0)] 
		[RED("ModifiedHotkey")] 
		public gamebbScriptID_Variant ModifiedHotkey
		{
			get => GetProperty(ref _modifiedHotkey);
			set => SetProperty(ref _modifiedHotkey, value);
		}

		public UI_HotkeysDef(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
