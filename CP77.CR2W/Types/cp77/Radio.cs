using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class Radio : InteractiveDevice
	{
		[Ordinal(0)]  [RED("isInteractive")] public CBool IsInteractive { get; set; }
		[Ordinal(1)]  [RED("isShortGlitchActive")] public CBool IsShortGlitchActive { get; set; }
		[Ordinal(2)]  [RED("shortGlitchDelayID")] public gameDelayID ShortGlitchDelayID { get; set; }
		[Ordinal(3)]  [RED("startingStation")] public CInt32 StartingStation { get; set; }
		[Ordinal(4)]  [RED("stations")] public CArray<RadioStationsMap> Stations { get; set; }

		public Radio(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
