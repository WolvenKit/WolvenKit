using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CombatTarget : CVariable
	{
		[Ordinal(0)] [RED("puppet")] public wCHandle<ScriptedPuppet> Puppet { get; set; }
		[Ordinal(1)] [RED("hasTime")] public CBool HasTime { get; set; }
		[Ordinal(2)] [RED("highlightTime")] public CFloat HighlightTime { get; set; }

		public CombatTarget(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
