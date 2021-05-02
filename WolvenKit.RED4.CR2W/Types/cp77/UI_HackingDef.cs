using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class UI_HackingDef : gamebbScriptDefinition
	{
		private gamebbScriptID_Bool _ammoIndicator;

		[Ordinal(0)] 
		[RED("ammoIndicator")] 
		public gamebbScriptID_Bool AmmoIndicator
		{
			get => GetProperty(ref _ammoIndicator);
			set => SetProperty(ref _ammoIndicator, value);
		}

		public UI_HackingDef(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
