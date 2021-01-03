using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class CombatTarget : CVariable
	{
		[Ordinal(0)]  [RED("hasTime")] public CBool HasTime { get; set; }
		[Ordinal(1)]  [RED("highlightTime")] public CFloat HighlightTime { get; set; }
		[Ordinal(2)]  [RED("puppet")] public wCHandle<ScriptedPuppet> Puppet { get; set; }

		public CombatTarget(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
