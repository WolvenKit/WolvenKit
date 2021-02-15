using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class effectTrackItemBloom : effectTrackItem
	{
		[Ordinal(3)] [RED("override")] public CBool Override { get; set; }
		[Ordinal(4)] [RED("sceneColorScale")] public effectEffectParameterEvaluatorFloat SceneColorScale { get; set; }
		[Ordinal(5)] [RED("bloomColorScale")] public effectEffectParameterEvaluatorFloat BloomColorScale { get; set; }

		public effectTrackItemBloom(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
