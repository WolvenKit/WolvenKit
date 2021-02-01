using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ApartmentScreenControllerPS : LcdScreenControllerPS
	{
		[Ordinal(0)]  [RED("allowAutomaticRentStatusChange")] public CBool AllowAutomaticRentStatusChange { get; set; }
		[Ordinal(1)]  [RED("currentOverdue")] public CInt32 CurrentOverdue { get; set; }
		[Ordinal(2)]  [RED("currentRentStatus")] public CEnum<ERentStatus> CurrentRentStatus { get; set; }
		[Ordinal(3)]  [RED("evictionMessageRecordID")] public TweakDBID EvictionMessageRecordID { get; set; }
		[Ordinal(4)]  [RED("initialOverdue")] public CInt32 InitialOverdue { get; set; }
		[Ordinal(5)]  [RED("initialRentStatus")] public CEnum<ERentStatus> InitialRentStatus { get; set; }
		[Ordinal(6)]  [RED("isInitialRentStateSet")] public CBool IsInitialRentStateSet { get; set; }
		[Ordinal(7)]  [RED("lastStatusChangeDay")] public CInt32 LastStatusChangeDay { get; set; }
		[Ordinal(8)]  [RED("maxDays")] public CInt32 MaxDays { get; set; }
		[Ordinal(9)]  [RED("overdueMessageRecordID")] public TweakDBID OverdueMessageRecordID { get; set; }
		[Ordinal(10)]  [RED("paidMessageRecordID")] public TweakDBID PaidMessageRecordID { get; set; }
		[Ordinal(11)]  [RED("paymentSchedule")] public CEnum<EPaymentSchedule> PaymentSchedule { get; set; }
		[Ordinal(12)]  [RED("randomizeInitialOverdue")] public CBool RandomizeInitialOverdue { get; set; }

		public ApartmentScreenControllerPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
