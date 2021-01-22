using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class PuppetReactionDef : gamebbScriptDefinition
	{
		[Ordinal(0)]  [RED("blockReactionFlag")] public gamebbScriptID_Bool BlockReactionFlag { get; set; }
		[Ordinal(1)]  [RED("exitReactionFlag")] public gamebbScriptID_Bool ExitReactionFlag { get; set; }

		public PuppetReactionDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
