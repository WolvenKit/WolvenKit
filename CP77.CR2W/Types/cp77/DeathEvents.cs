using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class DeathEvents : HighLevelTransition
	{
		[Ordinal(0)]  [RED("isDyingEffectPlaying")] public CBool IsDyingEffectPlaying { get; set; }

		public DeathEvents(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
