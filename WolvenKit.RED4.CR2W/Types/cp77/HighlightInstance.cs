using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class HighlightInstance : ModuleInstance
	{
		[Ordinal(6)] [RED("context")] public CEnum<HighlightContext> Context { get; set; }
		[Ordinal(7)] [RED("instant")] public CBool Instant { get; set; }

		public HighlightInstance(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
