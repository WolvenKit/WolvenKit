using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class questDeviceManager_ActionProperty : CVariable
	{
		[Ordinal(0)]  [RED("name")] public CName Name { get; set; }
		[Ordinal(1)]  [RED("value")] public CVariant Value { get; set; }
		[Ordinal(2)]  [RED("min")] public CFloat Min { get; set; }
		[Ordinal(3)]  [RED("max")] public CFloat Max { get; set; }

		public questDeviceManager_ActionProperty(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
