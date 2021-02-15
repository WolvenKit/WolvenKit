using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ScriptHitData : CVariable
	{
		[Ordinal(0)] [RED("animVariation")] public CInt32 AnimVariation { get; set; }
		[Ordinal(1)] [RED("attackDirection")] public CInt32 AttackDirection { get; set; }
		[Ordinal(2)] [RED("hitBodyPart")] public CInt32 HitBodyPart { get; set; }

		public ScriptHitData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
