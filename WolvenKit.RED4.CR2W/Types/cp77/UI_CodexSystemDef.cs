using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class UI_CodexSystemDef : gamebbScriptDefinition
	{
		private gamebbScriptID_Variant _codexUpdated;

		[Ordinal(0)] 
		[RED("CodexUpdated")] 
		public gamebbScriptID_Variant CodexUpdated
		{
			get => GetProperty(ref _codexUpdated);
			set => SetProperty(ref _codexUpdated, value);
		}

		public UI_CodexSystemDef(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
