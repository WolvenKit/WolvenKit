using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class RootMotionCommandHandler : AICommandHandlerBase
	{
		[Ordinal(0)]  [RED("inCommand")] public CHandle<AIArgumentMapping> InCommand { get; set; }
		[Ordinal(1)]  [RED("params")] public CHandle<AIArgumentMapping> Params { get; set; }

		public RootMotionCommandHandler(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
