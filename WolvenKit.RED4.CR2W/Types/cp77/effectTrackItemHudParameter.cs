using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class effectTrackItemHudParameter : effectTrackItem
	{
		[Ordinal(3)] [RED("scale")] public CFloat Scale { get; set; }
		[Ordinal(4)] [RED("glitchParameter")] public effectEffectParameterEvaluator GlitchParameter { get; set; }
		[Ordinal(5)] [RED("scale1")] public CFloat Scale1 { get; set; }
		[Ordinal(6)] [RED("glitchParameter1")] public effectEffectParameterEvaluator GlitchParameter1 { get; set; }

		public effectTrackItemHudParameter(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
