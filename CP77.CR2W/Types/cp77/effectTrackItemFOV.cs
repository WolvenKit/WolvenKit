using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class effectTrackItemFOV : effectTrackItem
	{
		[Ordinal(0)]  [RED("FOV")] public effectEffectParameterEvaluatorFloat FOV { get; set; }

		public effectTrackItemFOV(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
