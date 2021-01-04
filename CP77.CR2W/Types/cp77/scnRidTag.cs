using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class scnRidTag : CVariable
	{
		[Ordinal(0)]  [RED("serialNumber")] public scnRidSerialNumber SerialNumber { get; set; }
		[Ordinal(1)]  [RED("signature")] public CName Signature { get; set; }

		public scnRidTag(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
