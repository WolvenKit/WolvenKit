using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gamehitRepresentationEventsSetSingleScaleMultiplier_SingleShape : gamehitRepresentationEventsSetSingleScaleMultiplier_AllShapes
	{
		[Ordinal(1)] [RED("shapeName")] public CName ShapeName { get; set; }

		public gamehitRepresentationEventsSetSingleScaleMultiplier_SingleShape(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
