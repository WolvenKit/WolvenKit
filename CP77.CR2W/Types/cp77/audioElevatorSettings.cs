using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class audioElevatorSettings : audioEntitySettings
	{
		[Ordinal(0)]  [RED("callingEvent")] public CName CallingEvent { get; set; }
		[Ordinal(1)]  [RED("destinationReachedEvent")] public CName DestinationReachedEvent { get; set; }
		[Ordinal(2)]  [RED("movementEvents")] public audioLoopingSoundController MovementEvents { get; set; }
		[Ordinal(3)]  [RED("musicEvents")] public audioMusicController MusicEvents { get; set; }
		[Ordinal(4)]  [RED("panelSelectionEvent")] public CName PanelSelectionEvent { get; set; }

		public audioElevatorSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
