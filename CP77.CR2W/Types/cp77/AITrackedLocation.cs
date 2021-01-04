using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AITrackedLocation : CVariable
	{
		[Ordinal(0)]  [RED("accuracy")] public CFloat Accuracy { get; set; }
		[Ordinal(1)]  [RED("entity")] public wCHandle<entEntity> Entity { get; set; }
		[Ordinal(2)]  [RED("invalidExpectation")] public CBool InvalidExpectation { get; set; }
		[Ordinal(3)]  [RED("lastKnown")] public AILocationInformation LastKnown { get; set; }
		[Ordinal(4)]  [RED("location")] public AILocationInformation Location { get; set; }
		[Ordinal(5)]  [RED("sharedAccuracy")] public CFloat SharedAccuracy { get; set; }
		[Ordinal(6)]  [RED("sharedLastKnown")] public AILocationInformation SharedLastKnown { get; set; }
		[Ordinal(7)]  [RED("sharedLocation")] public AILocationInformation SharedLocation { get; set; }
		[Ordinal(8)]  [RED("sharedTimeDelay")] public CFloat SharedTimeDelay { get; set; }
		[Ordinal(9)]  [RED("speed")] public Vector4 Speed { get; set; }
		[Ordinal(10)]  [RED("status")] public CEnum<AITrackedStatusType> Status { get; set; }
		[Ordinal(11)]  [RED("threat")] public CFloat Threat { get; set; }
		[Ordinal(12)]  [RED("visible")] public CBool Visible { get; set; }

		public AITrackedLocation(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
