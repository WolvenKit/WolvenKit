using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class PuppetReactionDef : gamebbScriptDefinition
	{
		[Ordinal(0)]  [RED("blockReactionFlag")] public gamebbScriptID_Bool BlockReactionFlag { get; set; }
		[Ordinal(1)]  [RED("exitReactionFlag")] public gamebbScriptID_Bool ExitReactionFlag { get; set; }

		public PuppetReactionDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
