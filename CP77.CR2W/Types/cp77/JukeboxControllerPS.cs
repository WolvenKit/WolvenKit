using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class JukeboxControllerPS : ScriptableDeviceComponentPS
	{
		[Ordinal(103)] [RED("jukeboxSetup")] public JukeboxSetup JukeboxSetup { get; set; }
		[Ordinal(104)] [RED("stations")] public CArray<RadioStationsMap> Stations { get; set; }
		[Ordinal(105)] [RED("activeStation")] public CInt32 ActiveStation { get; set; }
		[Ordinal(106)] [RED("isPlaying")] public CBool IsPlaying { get; set; }

		public JukeboxControllerPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
