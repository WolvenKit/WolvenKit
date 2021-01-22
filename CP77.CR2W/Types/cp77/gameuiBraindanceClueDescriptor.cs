using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameuiBraindanceClueDescriptor : CVariable
	{
		[Ordinal(0)]  [RED("clueName")] public CName ClueName { get; set; }
		[Ordinal(1)]  [RED("endTime")] public CFloat EndTime { get; set; }
		[Ordinal(2)]  [RED("layer")] public CEnum<gameuiEBraindanceLayer> Layer { get; set; }
		[Ordinal(3)]  [RED("mode")] public CEnum<gameuiEClueDescriptorMode> Mode { get; set; }
		[Ordinal(4)]  [RED("startTime")] public CFloat StartTime { get; set; }

		public gameuiBraindanceClueDescriptor(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
