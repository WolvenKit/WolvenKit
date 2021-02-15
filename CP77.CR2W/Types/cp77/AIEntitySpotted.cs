using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AIEntitySpotted : AIAIEvent
	{
		[Ordinal(2)] [RED("spotter")] public wCHandle<entEntity> Spotter { get; set; }
		[Ordinal(3)] [RED("spotted")] public wCHandle<entEntity> Spotted { get; set; }
		[Ordinal(4)] [RED("isHostile")] public CBool IsHostile { get; set; }

		public AIEntitySpotted(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
