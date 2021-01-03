using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class AIDriveJoinTrafficCommandHandler : AICommandHandlerBase
	{
		[Ordinal(0)]  [RED("outNeedDriver")] public CHandle<AIArgumentMapping> OutNeedDriver { get; set; }
		[Ordinal(1)]  [RED("outUseKinematic")] public CHandle<AIArgumentMapping> OutUseKinematic { get; set; }

		public AIDriveJoinTrafficCommandHandler(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
