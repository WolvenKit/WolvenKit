using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class CacheFXOnDefeated : StatusEffectTasks
	{
		[Ordinal(0)] [RED("npcPuppet")] public wCHandle<NPCPuppet> NpcPuppet { get; set; }

		public CacheFXOnDefeated(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
