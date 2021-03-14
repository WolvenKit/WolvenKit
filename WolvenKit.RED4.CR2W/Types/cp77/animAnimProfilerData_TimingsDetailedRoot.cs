using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimProfilerData_TimingsDetailedRoot : ISerializable
	{
		[Ordinal(0)] [RED("sections")] public CArray<animAnimProfilerData_SectionTimings> Sections { get; set; }
		[Ordinal(1)] [RED("timings")] public CArray<animAnimProfilerData_TimingsDetailed> Timings { get; set; }

		public animAnimProfilerData_TimingsDetailedRoot(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
