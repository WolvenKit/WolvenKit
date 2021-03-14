using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gamehitRepresentationEventsSetSingleScaleMultiplier_MultipleShapes : gamehitRepresentationEventsSetSingleScaleMultiplier_AllShapes
	{
		[Ordinal(1)] [RED("shapeNames")] public CArray<CName> ShapeNames { get; set; }

		public gamehitRepresentationEventsSetSingleScaleMultiplier_MultipleShapes(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
