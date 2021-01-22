using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class CPOMissionDevice : gameObject
	{
		[Ordinal(0)]  [RED("blockAfterOperation")] public CBool BlockAfterOperation { get; set; }
		[Ordinal(1)]  [RED("compatibleDeviceName")] public CName CompatibleDeviceName { get; set; }
		[Ordinal(2)]  [RED("factToUnblock")] public CName FactToUnblock { get; set; }
		[Ordinal(3)]  [RED("factUnblockCallbackID")] public CUInt32 FactUnblockCallbackID { get; set; }
		[Ordinal(4)]  [RED("isBlocked")] public CBool IsBlocked { get; set; }

		public CPOMissionDevice(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
