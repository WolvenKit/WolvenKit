using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AnimFeature_CamberData : animAnimFeatureMarkUnstable
	{
		[Ordinal(0)] [RED("rightFrontCamber")] public CFloat RightFrontCamber { get; set; }
		[Ordinal(1)] [RED("leftFrontCamber")] public CFloat LeftFrontCamber { get; set; }
		[Ordinal(2)] [RED("rightBackCamber")] public CFloat RightBackCamber { get; set; }
		[Ordinal(3)] [RED("leftBackCamber")] public CFloat LeftBackCamber { get; set; }
		[Ordinal(4)] [RED("rightFrontCamberOffset")] public Vector4 RightFrontCamberOffset { get; set; }
		[Ordinal(5)] [RED("leftFrontCamberOffset")] public Vector4 LeftFrontCamberOffset { get; set; }
		[Ordinal(6)] [RED("rightBackCamberOffset")] public Vector4 RightBackCamberOffset { get; set; }
		[Ordinal(7)] [RED("leftBackCamberOffset")] public Vector4 LeftBackCamberOffset { get; set; }

		public AnimFeature_CamberData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
