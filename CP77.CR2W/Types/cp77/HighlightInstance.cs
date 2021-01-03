using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class HighlightInstance : ModuleInstance
	{
		[Ordinal(0)]  [RED("context")] public CEnum<HighlightContext> Context { get; set; }
		[Ordinal(1)]  [RED("instant")] public CBool Instant { get; set; }

		public HighlightInstance(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
