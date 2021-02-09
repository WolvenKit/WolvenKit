using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class CPOMissionDevice : gameObject
	{
		[Ordinal(31)]  [RED("compatibleDeviceName")] public CName CompatibleDeviceName { get; set; }
		[Ordinal(32)]  [RED("blockAfterOperation")] public CBool BlockAfterOperation { get; set; }
		[Ordinal(33)]  [RED("factToUnblock")] public CName FactToUnblock { get; set; }
		[Ordinal(34)]  [RED("isBlocked")] public CBool IsBlocked { get; set; }
		[Ordinal(35)]  [RED("factUnblockCallbackID")] public CUInt32 FactUnblockCallbackID { get; set; }

		public CPOMissionDevice(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
