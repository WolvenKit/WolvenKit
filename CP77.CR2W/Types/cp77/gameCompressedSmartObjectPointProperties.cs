using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameCompressedSmartObjectPointProperties : CVariable
	{
		[Ordinal(0)] [RED("propertyId")] public CUInt16 PropertyId { get; set; }

		public gameCompressedSmartObjectPointProperties(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
