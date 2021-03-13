using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class entTransformHistoryComponent : entIComponent
	{
		[Ordinal(3)] [RED("historyLength")] public CFloat HistoryLength { get; set; }
		[Ordinal(4)] [RED("samplesAmount")] public CUInt32 SamplesAmount { get; set; }

		public entTransformHistoryComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
