using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class effectTrackItemFilmGrain : effectTrackItem
	{
		[Ordinal(0)]  [RED("luminanceBias")] public effectEffectParameterEvaluatorFloat LuminanceBias { get; set; }
		[Ordinal(1)]  [RED("override")] public CBool Override { get; set; }
		[Ordinal(2)]  [RED("strength")] public effectEffectParameterEvaluatorVector Strength { get; set; }

		public effectTrackItemFilmGrain(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
