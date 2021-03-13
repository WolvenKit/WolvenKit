using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AnimFeature_Inspection : animAnimFeature
	{
		[Ordinal(0)] [RED("activeInspectionStage")] public CInt32 ActiveInspectionStage { get; set; }
		[Ordinal(1)] [RED("rotationX")] public CFloat RotationX { get; set; }
		[Ordinal(2)] [RED("rotationY")] public CFloat RotationY { get; set; }
		[Ordinal(3)] [RED("offsetX")] public CFloat OffsetX { get; set; }
		[Ordinal(4)] [RED("offsetY")] public CFloat OffsetY { get; set; }

		public AnimFeature_Inspection(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
