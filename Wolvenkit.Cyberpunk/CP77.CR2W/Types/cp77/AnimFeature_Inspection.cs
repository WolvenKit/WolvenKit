using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AnimFeature_Inspection : animAnimFeature
	{
		[Ordinal(0)]  [RED("activeInspectionStage")] public CInt32 ActiveInspectionStage { get; set; }
		[Ordinal(1)]  [RED("offsetX")] public CFloat OffsetX { get; set; }
		[Ordinal(2)]  [RED("offsetY")] public CFloat OffsetY { get; set; }
		[Ordinal(3)]  [RED("rotationX")] public CFloat RotationX { get; set; }
		[Ordinal(4)]  [RED("rotationY")] public CFloat RotationY { get; set; }

		public AnimFeature_Inspection(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
