using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AccumulatedDamageDigitsNode : CVariable
	{
		[Ordinal(0)] [RED("used")] public CBool Used { get; set; }
		[Ordinal(1)] [RED("entityID")] public entEntityID EntityID { get; set; }
		[Ordinal(2)] [RED("controller")] public wCHandle<AccumulatedDamageDigitLogicController> Controller { get; set; }
		[Ordinal(3)] [RED("isDamageOverTime")] public CBool IsDamageOverTime { get; set; }

		public AccumulatedDamageDigitsNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
