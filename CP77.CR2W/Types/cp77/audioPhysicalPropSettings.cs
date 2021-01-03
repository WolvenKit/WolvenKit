using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class audioPhysicalPropSettings : audioAudioMetadata
	{
		[Ordinal(0)]  [RED("damagedSound")] public CName DamagedSound { get; set; }
		[Ordinal(1)]  [RED("destroyedSound")] public CName DestroyedSound { get; set; }
		[Ordinal(2)]  [RED("materialOverrides")] public CArray<CName> MaterialOverrides { get; set; }
		[Ordinal(3)]  [RED("shockwaveSound")] public CName ShockwaveSound { get; set; }

		public audioPhysicalPropSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
