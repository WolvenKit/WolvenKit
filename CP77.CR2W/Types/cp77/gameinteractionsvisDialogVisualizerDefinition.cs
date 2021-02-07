using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameinteractionsvisDialogVisualizerDefinition : gameinteractionsvisIVisualizerDefinition
	{
		[Ordinal(0)]  [RED("displayNameOverride")] public CString DisplayNameOverride { get; set; }
		[Ordinal(1)]  [RED("useLookAt")] public CBool UseLookAt { get; set; }
		[Ordinal(2)]  [RED("disableAfterSelectingChoice")] public CBool DisableAfterSelectingChoice { get; set; }
		[Ordinal(3)]  [RED("timeProvider")] public CHandle<gameinteractionsvisIVisualizerTimeProvider> TimeProvider { get; set; }
		[Ordinal(4)]  [RED("hubPriority")] public CUInt8 HubPriority { get; set; }

		public gameinteractionsvisDialogVisualizerDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
