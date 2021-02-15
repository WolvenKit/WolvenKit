using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameStatusEffectReplicatedInfo : CVariable
	{
		[Ordinal(0)] [RED("statusEffectRecordID")] public TweakDBID StatusEffectRecordID { get; set; }
		[Ordinal(1)] [RED("stackCount")] public CUInt32 StackCount { get; set; }
		[Ordinal(2)] [RED("source")] public CName Source { get; set; }

		public gameStatusEffectReplicatedInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
