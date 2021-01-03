using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gamehitRepresentationEventsSetMultipleScaleMultipliers_MultipleShapes : redEvent
	{
		[Ordinal(0)]  [RED("scaleMultipliers")] public CArray<Vector4> ScaleMultipliers { get; set; }
		[Ordinal(1)]  [RED("shapeNames")] public CArray<CName> ShapeNames { get; set; }

		public gamehitRepresentationEventsSetMultipleScaleMultipliers_MultipleShapes(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
