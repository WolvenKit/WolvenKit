using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class JukeboxControllerPS : ScriptableDeviceComponentPS
	{
		[Ordinal(0)]  [RED("activeStation")] public CInt32 ActiveStation { get; set; }
		[Ordinal(1)]  [RED("isPlaying")] public CBool IsPlaying { get; set; }
		[Ordinal(2)]  [RED("jukeboxSetup")] public JukeboxSetup JukeboxSetup { get; set; }
		[Ordinal(3)]  [RED("stations")] public CArray<RadioStationsMap> Stations { get; set; }

		public JukeboxControllerPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
