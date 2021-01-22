using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class audioMixSettings : audioAudioMetadata
	{
		[Ordinal(0)]  [RED("masterVolume")] public CFloat MasterVolume { get; set; }
		[Ordinal(1)]  [RED("musicVolume")] public CFloat MusicVolume { get; set; }
		[Ordinal(2)]  [RED("onStartupEvent")] public CName OnStartupEvent { get; set; }
		[Ordinal(3)]  [RED("sfxVolume")] public CFloat SfxVolume { get; set; }
		[Ordinal(4)]  [RED("uiMenuVolume")] public CFloat UiMenuVolume { get; set; }
		[Ordinal(5)]  [RED("voVolume")] public CFloat VoVolume { get; set; }

		public audioMixSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
