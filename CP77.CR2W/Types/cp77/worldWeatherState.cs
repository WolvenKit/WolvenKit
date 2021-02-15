using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class worldWeatherState : CVariable
	{
		[Ordinal(0)] [RED("probability")] public curveData<CFloat> Probability { get; set; }
		[Ordinal(1)] [RED("minDuration")] public curveData<CFloat> MinDuration { get; set; }
		[Ordinal(2)] [RED("maxDuration")] public curveData<CFloat> MaxDuration { get; set; }
		[Ordinal(3)] [RED("transitionDuration")] public curveData<CFloat> TransitionDuration { get; set; }
		[Ordinal(4)] [RED("environmentAreaParameters")] public rRef<worldEnvironmentAreaParameters> EnvironmentAreaParameters { get; set; }
		[Ordinal(5)] [RED("effect")] public raRef<worldEffect> Effect { get; set; }
		[Ordinal(6)] [RED("name")] public CName Name { get; set; }

		public worldWeatherState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
