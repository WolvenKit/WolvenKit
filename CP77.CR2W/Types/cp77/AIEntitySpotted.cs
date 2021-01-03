using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class AIEntitySpotted : AIAIEvent
	{
		[Ordinal(0)]  [RED("isHostile")] public CBool IsHostile { get; set; }
		[Ordinal(1)]  [RED("spotted")] public wCHandle<entEntity> Spotted { get; set; }
		[Ordinal(2)]  [RED("spotter")] public wCHandle<entEntity> Spotter { get; set; }

		public AIEntitySpotted(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
