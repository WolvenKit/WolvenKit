using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameEffectAction_ChildEffectsMovingInCone : gameEffectPostAction
	{
		[Ordinal(0)] [RED("effectsCount")] public CUInt32 EffectsCount { get; set; }
		[Ordinal(1)] [RED("effectTagInThisFile")] public CName EffectTagInThisFile { get; set; }
		[Ordinal(2)] [RED("coneAngle")] public CFloat ConeAngle { get; set; }
		[Ordinal(3)] [RED("minEffectDuration")] public CFloat MinEffectDuration { get; set; }
		[Ordinal(4)] [RED("maxEffectDuration")] public CFloat MaxEffectDuration { get; set; }
		[Ordinal(5)] [RED("twoDimensional")] public CBool TwoDimensional { get; set; }

		public gameEffectAction_ChildEffectsMovingInCone(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
