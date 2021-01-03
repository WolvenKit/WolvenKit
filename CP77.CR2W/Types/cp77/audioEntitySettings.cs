using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class audioEntitySettings : audioAudioMetadata
	{
		[Ordinal(0)]  [RED("auxiliaryMetadata")] public audioAuxiliaryMetadata AuxiliaryMetadata { get; set; }
		[Ordinal(1)]  [RED("commonSettings")] public audioCommonEntitySettings CommonSettings { get; set; }
		[Ordinal(2)]  [RED("emitterDecoratorMetadata")] public CName EmitterDecoratorMetadata { get; set; }
		[Ordinal(3)]  [RED("preferSoundComponentPosition")] public CBool PreferSoundComponentPosition { get; set; }
		[Ordinal(4)]  [RED("scanningSettings")] public audioScanningSettings ScanningSettings { get; set; }

		public audioEntitySettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
