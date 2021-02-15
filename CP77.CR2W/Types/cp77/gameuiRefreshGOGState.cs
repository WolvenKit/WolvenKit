using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameuiRefreshGOGState : redEvent
	{
		[Ordinal(0)] [RED("status")] public CEnum<gameGOGRewardsSystemStatus> Status { get; set; }
		[Ordinal(1)] [RED("error")] public CEnum<gameGOGRewardsSystemErrors> Error { get; set; }
		[Ordinal(2)] [RED("registerURL")] public CString RegisterURL { get; set; }
		[Ordinal(3)] [RED("qrCodePNGBlob")] public CArray<CUInt8> QrCodePNGBlob { get; set; }

		public gameuiRefreshGOGState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
