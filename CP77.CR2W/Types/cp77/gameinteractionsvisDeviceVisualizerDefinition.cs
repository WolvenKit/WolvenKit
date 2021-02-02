using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameinteractionsvisDeviceVisualizerDefinition : gameinteractionsvisIVisualizerDefinition
	{
		[Ordinal(0)]  [RED("interactionType")] public CEnum<gameinteractionsvisInteractionType> InteractionType { get; set; }
		[Ordinal(1)]  [RED("displayNameOverride")] public CString DisplayNameOverride { get; set; }
		[Ordinal(2)]  [RED("isDynamic")] public CBool IsDynamic { get; set; }
		[Ordinal(3)]  [RED("useDefaultActionMapping")] public CBool UseDefaultActionMapping { get; set; }
		[Ordinal(4)]  [RED("createMappin")] public CBool CreateMappin { get; set; }
		[Ordinal(5)]  [RED("timeProvider")] public CHandle<gameinteractionsvisIVisualizerTimeProvider> TimeProvider { get; set; }

		public gameinteractionsvisDeviceVisualizerDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
