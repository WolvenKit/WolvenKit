using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class NPCKillDelayEvent : redEvent
	{
		[Ordinal(0)]  [RED("disableKillReward")] public CBool DisableKillReward { get; set; }
		[Ordinal(1)]  [RED("isLethalTakedown")] public CBool IsLethalTakedown { get; set; }
		[Ordinal(2)]  [RED("target")] public wCHandle<gameObject> Target { get; set; }

		public NPCKillDelayEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
