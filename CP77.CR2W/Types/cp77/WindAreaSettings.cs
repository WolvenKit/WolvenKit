using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class WindAreaSettings : IAreaSettings
	{
		[Ordinal(2)] [RED("strength")] public curveData<CFloat> Strength { get; set; }
		[Ordinal(3)] [RED("direction")] public curveData<Vector4> Direction { get; set; }

		public WindAreaSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
