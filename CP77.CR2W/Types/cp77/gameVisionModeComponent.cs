using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameVisionModeComponent : gameComponent
	{
		[Ordinal(0)]  [RED("activeForcedHighlight")] public CHandle<FocusForcedHighlightData> ActiveForcedHighlight { get; set; }
		[Ordinal(1)]  [RED("activeRevealRequests")] public CArray<gameVisionModeSystemRevealIdentifier> ActiveRevealRequests { get; set; }
		[Ordinal(2)]  [RED("availableVisionModes")] public CArray<gameVisionModuleParams> AvailableVisionModes { get; set; }
		[Ordinal(3)]  [RED("currentDefaultHighlight")] public CHandle<FocusForcedHighlightData> CurrentDefaultHighlight { get; set; }
		[Ordinal(4)]  [RED("defaultHighlightData")] public CHandle<HighlightEditableData> DefaultHighlightData { get; set; }
		[Ordinal(5)]  [RED("forcedHighlights")] public CArray<CHandle<FocusForcedHighlightData>> ForcedHighlights { get; set; }
		[Ordinal(6)]  [RED("isFocusModeActive")] public CBool IsFocusModeActive { get; set; }
		[Ordinal(7)]  [RED("wasCleanedUp")] public CBool WasCleanedUp { get; set; }

		public gameVisionModeComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
