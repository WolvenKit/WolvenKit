using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class SquadTicketReceipt : CVariable
	{
		[Ordinal(0)] [RED("acknowledgedTimeStamp")] public CFloat AcknowledgedTimeStamp { get; set; }
		[Ordinal(1)] [RED("conditionDeactivationCheckTimeStamp")] public CFloat ConditionDeactivationCheckTimeStamp { get; set; }
		[Ordinal(2)] [RED("conditionDeactivationSuccessfulCheckTimeStamp")] public CFloat ConditionDeactivationSuccessfulCheckTimeStamp { get; set; }
		[Ordinal(3)] [RED("conditionCheckRandomizedInterval")] public CFloat ConditionCheckRandomizedInterval { get; set; }
		[Ordinal(4)] [RED("lastRecipient")] public entEntityID LastRecipient { get; set; }
		[Ordinal(5)] [RED("acknowledgesInQueue")] public CInt32 AcknowledgesInQueue { get; set; }
		[Ordinal(6)] [RED("numberOfOrders")] public CInt32 NumberOfOrders { get; set; }
		[Ordinal(7)] [RED("cooldownID")] public CInt32 CooldownID { get; set; }

		public SquadTicketReceipt(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
