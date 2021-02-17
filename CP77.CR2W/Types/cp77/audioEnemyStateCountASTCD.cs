using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class audioEnemyStateCountASTCD : audioAudioStateTransitionConditionData
	{
		[Ordinal(1)] [RED("enemiesState")] public CEnum<audioEnemyState> EnemiesState { get; set; }
		[Ordinal(2)] [RED("countComparer")] public CEnum<audioNumberComparer> CountComparer { get; set; }
		[Ordinal(3)] [RED("enemiesCount")] public CUInt32 EnemiesCount { get; set; }

		public audioEnemyStateCountASTCD(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
