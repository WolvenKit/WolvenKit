using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class audioEnemyStateCountASTCD : audioAudioStateTransitionConditionData
	{
		[Ordinal(0)]  [RED("countComparer")] public CEnum<audioNumberComparer> CountComparer { get; set; }
		[Ordinal(1)]  [RED("enemiesCount")] public CUInt32 EnemiesCount { get; set; }
		[Ordinal(2)]  [RED("enemiesState")] public CEnum<audioEnemyState> EnemiesState { get; set; }

		public audioEnemyStateCountASTCD(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
