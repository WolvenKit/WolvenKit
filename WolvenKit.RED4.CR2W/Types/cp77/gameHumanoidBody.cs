using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameHumanoidBody : entIComponent
	{
		[Ordinal(3)] [RED("basePersonalSpace")] public CFloat BasePersonalSpace { get; set; }
		[Ordinal(4)] [RED("baseHeight")] public CFloat BaseHeight { get; set; }
		[Ordinal(5)] [RED("baseEyesHeightRatio")] public CFloat BaseEyesHeightRatio { get; set; }
		[Ordinal(6)] [RED("stanceAnimFeatureName")] public CName StanceAnimFeatureName { get; set; }
		[Ordinal(7)] [RED("aimAnimFeatureName")] public CName AimAnimFeatureName { get; set; }

		public gameHumanoidBody(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
