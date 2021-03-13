using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class effectLoopData : CVariable
	{
		[Ordinal(0)] [RED("startTime")] public CFloat StartTime { get; set; }
		[Ordinal(1)] [RED("endTime")] public CFloat EndTime { get; set; }

		public effectLoopData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
