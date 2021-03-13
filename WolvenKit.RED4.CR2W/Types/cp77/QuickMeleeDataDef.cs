using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class QuickMeleeDataDef : gamebbScriptDefinition
	{
		[Ordinal(0)] [RED("NPCHit")] public gamebbScriptID_Bool NPCHit { get; set; }

		public QuickMeleeDataDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
