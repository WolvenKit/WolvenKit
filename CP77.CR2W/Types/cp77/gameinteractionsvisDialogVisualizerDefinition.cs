using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameinteractionsvisDialogVisualizerDefinition : gameinteractionsvisIVisualizerDefinition
	{
		[Ordinal(0)]  [RED("disableAfterSelectingChoice")] public CBool DisableAfterSelectingChoice { get; set; }
		[Ordinal(1)]  [RED("displayNameOverride")] public CString DisplayNameOverride { get; set; }
		[Ordinal(2)]  [RED("hubPriority")] public CUInt8 HubPriority { get; set; }
		[Ordinal(3)]  [RED("timeProvider")] public CHandle<gameinteractionsvisIVisualizerTimeProvider> TimeProvider { get; set; }
		[Ordinal(4)]  [RED("useLookAt")] public CBool UseLookAt { get; set; }

		public gameinteractionsvisDialogVisualizerDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
