using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class TonemappingModeLottes : ITonemappingMode
	{
		[Ordinal(1)] [RED("maxInput")] public CFloat MaxInput { get; set; }
		[Ordinal(2)] [RED("contrast")] public CFloat Contrast { get; set; }
		[Ordinal(3)] [RED("midIn")] public CFloat MidIn { get; set; }
		[Ordinal(4)] [RED("midOut")] public CFloat MidOut { get; set; }
		[Ordinal(5)] [RED("crosstalk")] public Vector3 Crosstalk { get; set; }
		[Ordinal(6)] [RED("crosstalkSaturation")] public Vector3 CrosstalkSaturation { get; set; }

		public TonemappingModeLottes(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
