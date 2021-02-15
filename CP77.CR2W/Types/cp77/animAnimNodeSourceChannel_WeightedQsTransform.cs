using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animAnimNodeSourceChannel_WeightedQsTransform : ISerializable
	{
		[Ordinal(0)] [RED("channel")] public CHandle<animIAnimNodeSourceChannel_QsTransform> Channel { get; set; }
		[Ordinal(1)] [RED("weight")] public CFloat Weight { get; set; }

		public animAnimNodeSourceChannel_WeightedQsTransform(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
