using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class audioGearSweetener : audioAudioMetadata
	{
		[Ordinal(0)]  [RED("burnoutFactor")] public CFloat BurnoutFactor { get; set; }
		[Ordinal(1)]  [RED("cooldown")] public CFloat Cooldown { get; set; }
		[Ordinal(2)]  [RED("gear")] public CUInt32 Gear { get; set; }
		[Ordinal(3)]  [RED("rpmThreshold")] public CFloat RpmThreshold { get; set; }
		[Ordinal(4)]  [RED("soundEvent")] public CName SoundEvent { get; set; }

		public audioGearSweetener(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
