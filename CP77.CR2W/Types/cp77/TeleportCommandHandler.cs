using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class TeleportCommandHandler : AICommandHandlerBase
	{
		[Ordinal(0)]  [RED("doNavTest")] public CHandle<AIArgumentMapping> DoNavTest { get; set; }
		[Ordinal(1)]  [RED("position")] public CHandle<AIArgumentMapping> Position { get; set; }
		[Ordinal(2)]  [RED("rotation")] public CHandle<AIArgumentMapping> Rotation { get; set; }

		public TeleportCommandHandler(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
