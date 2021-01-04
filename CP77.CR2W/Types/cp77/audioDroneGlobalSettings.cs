using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class audioDroneGlobalSettings : audioAudioMetadata
	{
		[Ordinal(0)]  [RED("speedRtpc")] public CName SpeedRtpc { get; set; }
		[Ordinal(1)]  [RED("thrustRtpc")] public CName ThrustRtpc { get; set; }

		public audioDroneGlobalSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
