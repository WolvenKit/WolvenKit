using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class EffectExecutor_Spread : gameEffectExecutor_Scripted
	{
		[Ordinal(0)]  [RED("objectActionRecord")] public wCHandle<gamedataObjectAction_Record> ObjectActionRecord { get; set; }
		[Ordinal(1)]  [RED("prevEntity")] public wCHandle<entEntity> PrevEntity { get; set; }
		[Ordinal(2)]  [RED("player")] public wCHandle<PlayerPuppet> Player { get; set; }
		[Ordinal(3)]  [RED("spreadToAllTargetsInTheArea")] public CBool SpreadToAllTargetsInTheArea { get; set; }

		public EffectExecutor_Spread(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
