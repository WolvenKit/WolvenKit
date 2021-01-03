using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class animAnimProfilerData_Timings : CVariable
	{
		[Ordinal(0)]  [RED("avarageExclusiveTimeMS")] public CFloat AvarageExclusiveTimeMS { get; set; }
		[Ordinal(1)]  [RED("avarageInclusiveTimeMS")] public CFloat AvarageInclusiveTimeMS { get; set; }
		[Ordinal(2)]  [RED("className")] public CName ClassName { get; set; }

		public animAnimProfilerData_Timings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
