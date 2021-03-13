using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questPuppetsUnconscious : questPuppetsEffector
	{
		[Ordinal(0)] [RED("setUnconscious")] public CBool SetUnconscious { get; set; }

		public questPuppetsUnconscious(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
