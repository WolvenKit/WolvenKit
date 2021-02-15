using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class NPCGodModeListener : gameScriptStatsListener
	{
		[Ordinal(0)] [RED("owner")] public wCHandle<NPCPuppet> Owner { get; set; }

		public NPCGodModeListener(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
