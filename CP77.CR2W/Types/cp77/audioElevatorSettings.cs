using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class audioElevatorSettings : audioEntitySettings
	{
		[Ordinal(0)]  [RED("musicEvents")] public audioMusicController MusicEvents { get; set; }
		[Ordinal(1)]  [RED("movementEvents")] public audioLoopingSoundController MovementEvents { get; set; }
		[Ordinal(2)]  [RED("callingEvent")] public CName CallingEvent { get; set; }
		[Ordinal(3)]  [RED("destinationReachedEvent")] public CName DestinationReachedEvent { get; set; }
		[Ordinal(4)]  [RED("panelSelectionEvent")] public CName PanelSelectionEvent { get; set; }

		public audioElevatorSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
