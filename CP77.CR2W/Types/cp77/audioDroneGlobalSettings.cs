using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class audioDroneGlobalSettings : audioAudioMetadata
	{
		[Ordinal(0)]  [RED("speedRtpc")] public CName SpeedRtpc { get; set; }
		[Ordinal(1)]  [RED("thrustRtpc")] public CName ThrustRtpc { get; set; }

		public audioDroneGlobalSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
