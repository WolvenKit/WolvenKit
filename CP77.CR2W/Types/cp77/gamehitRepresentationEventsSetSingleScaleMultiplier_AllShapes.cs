using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gamehitRepresentationEventsSetSingleScaleMultiplier_AllShapes : redEvent
	{
		[Ordinal(0)] [RED("scaleMultiplier")] public Vector4 ScaleMultiplier { get; set; }

		public gamehitRepresentationEventsSetSingleScaleMultiplier_AllShapes(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
