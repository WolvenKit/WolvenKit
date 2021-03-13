using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimProfilerData_TimingsRoot : ISerializable
	{
		[Ordinal(0)] [RED("timings")] public CArray<animAnimProfilerData_Timings> Timings { get; set; }

		public animAnimProfilerData_TimingsRoot(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
