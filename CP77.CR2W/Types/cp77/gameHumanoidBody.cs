using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameHumanoidBody : entIComponent
	{
		[Ordinal(0)]  [RED("aimAnimFeatureName")] public CName AimAnimFeatureName { get; set; }
		[Ordinal(1)]  [RED("baseEyesHeightRatio")] public CFloat BaseEyesHeightRatio { get; set; }
		[Ordinal(2)]  [RED("baseHeight")] public CFloat BaseHeight { get; set; }
		[Ordinal(3)]  [RED("basePersonalSpace")] public CFloat BasePersonalSpace { get; set; }
		[Ordinal(4)]  [RED("stanceAnimFeatureName")] public CName StanceAnimFeatureName { get; set; }

		public gameHumanoidBody(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
