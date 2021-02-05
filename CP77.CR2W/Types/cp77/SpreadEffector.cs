using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class SpreadEffector : gameEffector
	{
		[Ordinal(0)]  [RED("objectActionRecord")] public wCHandle<gamedataObjectAction_Record> ObjectActionRecord { get; set; }
		[Ordinal(1)]  [RED("player")] public wCHandle<PlayerPuppet> Player { get; set; }
		[Ordinal(2)]  [RED("effectorRecord")] public CHandle<gamedataSpreadEffector_Record> EffectorRecord { get; set; }
		[Ordinal(3)]  [RED("spreadToAllTargetsInTheArea")] public CBool SpreadToAllTargetsInTheArea { get; set; }

		public SpreadEffector(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
