using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class entTransformHistoryComponent : entIComponent
	{
		[Ordinal(0)]  [RED("historyLength")] public CFloat HistoryLength { get; set; }
		[Ordinal(1)]  [RED("samplesAmount")] public CUInt32 SamplesAmount { get; set; }

		public entTransformHistoryComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
