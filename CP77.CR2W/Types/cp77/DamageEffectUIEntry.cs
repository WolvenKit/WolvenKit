using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class DamageEffectUIEntry : IScriptable
	{
		[Ordinal(0)] [RED("valueStat")] public CEnum<gamedataStatType> ValueStat { get; set; }
		[Ordinal(1)] [RED("targetStat")] public CEnum<gamedataStatType> TargetStat { get; set; }
		[Ordinal(2)] [RED("displayType")] public CEnum<DamageEffectDisplayType> DisplayType { get; set; }
		[Ordinal(3)] [RED("valueToDisplay")] public CFloat ValueToDisplay { get; set; }
		[Ordinal(4)] [RED("effectorDuration")] public CFloat EffectorDuration { get; set; }
		[Ordinal(5)] [RED("effectorDelay")] public CFloat EffectorDelay { get; set; }
		[Ordinal(6)] [RED("isContinuous")] public CBool IsContinuous { get; set; }

		public DamageEffectUIEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
