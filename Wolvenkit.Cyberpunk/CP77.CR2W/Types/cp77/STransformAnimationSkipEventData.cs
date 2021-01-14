using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class STransformAnimationSkipEventData : CVariable
	{
		[Ordinal(0)]  [RED("skipToEnd")] public CBool SkipToEnd { get; set; }
		[Ordinal(1)]  [RED("time")] public CFloat Time { get; set; }

		public STransformAnimationSkipEventData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
