using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ApartmentScreenControllerPS : LcdScreenControllerPS
	{
		[Ordinal(107)] [RED("initialRentStatus")] public CEnum<ERentStatus> InitialRentStatus { get; set; }
		[Ordinal(108)] [RED("overdueMessageRecordID")] public TweakDBID OverdueMessageRecordID { get; set; }
		[Ordinal(109)] [RED("paidMessageRecordID")] public TweakDBID PaidMessageRecordID { get; set; }
		[Ordinal(110)] [RED("evictionMessageRecordID")] public TweakDBID EvictionMessageRecordID { get; set; }
		[Ordinal(111)] [RED("paymentSchedule")] public CEnum<EPaymentSchedule> PaymentSchedule { get; set; }
		[Ordinal(112)] [RED("randomizeInitialOverdue")] public CBool RandomizeInitialOverdue { get; set; }
		[Ordinal(113)] [RED("initialOverdue")] public CInt32 InitialOverdue { get; set; }
		[Ordinal(114)] [RED("allowAutomaticRentStatusChange")] public CBool AllowAutomaticRentStatusChange { get; set; }
		[Ordinal(115)] [RED("maxDays")] public CInt32 MaxDays { get; set; }
		[Ordinal(116)] [RED("currentOverdue")] public CInt32 CurrentOverdue { get; set; }
		[Ordinal(117)] [RED("isInitialRentStateSet")] public CBool IsInitialRentStateSet { get; set; }
		[Ordinal(118)] [RED("currentRentStatus")] public CEnum<ERentStatus> CurrentRentStatus { get; set; }
		[Ordinal(119)] [RED("lastStatusChangeDay")] public CInt32 LastStatusChangeDay { get; set; }

		public ApartmentScreenControllerPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
