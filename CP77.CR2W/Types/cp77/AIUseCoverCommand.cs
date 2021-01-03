using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class AIUseCoverCommand : AICombatRelatedCommand
	{
		[Ordinal(0)]  [RED("coverNodeRef")] public NodeRef CoverNodeRef { get; set; }
		[Ordinal(1)]  [RED("exposureMethods")] public CArray<CEnum<AICoverExposureMethod>> ExposureMethods { get; set; }
		[Ordinal(2)]  [RED("forcedEntryAnimation")] public CName ForcedEntryAnimation { get; set; }
		[Ordinal(3)]  [RED("limitToTheseExposureMethods")] public CHandle<CoverCommandParams> LimitToTheseExposureMethods { get; set; }
		[Ordinal(4)]  [RED("oneTimeSelection")] public CBool OneTimeSelection { get; set; }

		public AIUseCoverCommand(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
