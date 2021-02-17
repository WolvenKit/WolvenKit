using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class cpConveyor : gameObject
	{
		[Ordinal(40)] [RED("lines")] public CArray<cpConveyorLine> Lines { get; set; }
		[Ordinal(41)] [RED("movementCurve")] public curveData<CFloat> MovementCurve { get; set; }
		[Ordinal(42)] [RED("entityDistance")] public CFloat EntityDistance { get; set; }
		[Ordinal(43)] [RED("entitySpawnOffset")] public CFloat EntitySpawnOffset { get; set; }
		[Ordinal(44)] [RED("audioParameterLineActive")] public CName AudioParameterLineActive { get; set; }
		[Ordinal(45)] [RED("audioParameterLineCycle")] public CName AudioParameterLineCycle { get; set; }
		[Ordinal(46)] [RED("audioParameterLineSpeed")] public CName AudioParameterLineSpeed { get; set; }

		public cpConveyor(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
