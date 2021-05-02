using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class QuickMeleeDataDef : gamebbScriptDefinition
	{
		private gamebbScriptID_Bool _nPCHit;

		[Ordinal(0)] 
		[RED("NPCHit")] 
		public gamebbScriptID_Bool NPCHit
		{
			get => GetProperty(ref _nPCHit);
			set => SetProperty(ref _nPCHit, value);
		}

		public QuickMeleeDataDef(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
