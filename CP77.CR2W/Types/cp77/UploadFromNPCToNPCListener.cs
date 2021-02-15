using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class UploadFromNPCToNPCListener : QuickHackUploadListener
	{
		[Ordinal(2)] [RED("npcPuppet")] public wCHandle<ScriptedPuppet> NpcPuppet { get; set; }

		public UploadFromNPCToNPCListener(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
