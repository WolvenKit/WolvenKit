using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameuiDetectionParams : CVariable
	{
		[Ordinal(0)] [RED("detectionProgress")] public CFloat DetectionProgress { get; set; }

		public gameuiDetectionParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
