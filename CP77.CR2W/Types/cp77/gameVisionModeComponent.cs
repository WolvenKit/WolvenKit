using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameVisionModeComponent : gameComponent
	{
		[Ordinal(4)] [RED("availableVisionModes")] public CArray<gameVisionModuleParams> AvailableVisionModes { get; set; }
		[Ordinal(5)] [RED("defaultHighlightData")] public CHandle<HighlightEditableData> DefaultHighlightData { get; set; }
		[Ordinal(6)] [RED("forcedHighlights")] public CArray<CHandle<FocusForcedHighlightData>> ForcedHighlights { get; set; }
		[Ordinal(7)] [RED("activeForcedHighlight")] public CHandle<FocusForcedHighlightData> ActiveForcedHighlight { get; set; }
		[Ordinal(8)] [RED("currentDefaultHighlight")] public CHandle<FocusForcedHighlightData> CurrentDefaultHighlight { get; set; }
		[Ordinal(9)] [RED("activeRevealRequests")] public CArray<gameVisionModeSystemRevealIdentifier> ActiveRevealRequests { get; set; }
		[Ordinal(10)] [RED("isFocusModeActive")] public CBool IsFocusModeActive { get; set; }
		[Ordinal(11)] [RED("wasCleanedUp")] public CBool WasCleanedUp { get; set; }

		public gameVisionModeComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
