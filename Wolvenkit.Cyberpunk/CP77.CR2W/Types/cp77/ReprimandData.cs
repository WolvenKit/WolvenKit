using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ReprimandData : CVariable
	{
		[Ordinal(0)]  [RED("count")] public CInt32 Count { get; set; }
		[Ordinal(1)]  [RED("isActive")] public CBool IsActive { get; set; }
		[Ordinal(2)]  [RED("receiver")] public entEntityID Receiver { get; set; }
		[Ordinal(3)]  [RED("receiverAttitudeGroup")] public CName ReceiverAttitudeGroup { get; set; }
		[Ordinal(4)]  [RED("reprimandID")] public CInt32 ReprimandID { get; set; }

		public ReprimandData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
