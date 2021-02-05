using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class audioPhysicalPropSettings : audioAudioMetadata
	{
		[Ordinal(0)]  [RED("shockwaveSound")] public CName ShockwaveSound { get; set; }
		[Ordinal(1)]  [RED("damagedSound")] public CName DamagedSound { get; set; }
		[Ordinal(2)]  [RED("destroyedSound")] public CName DestroyedSound { get; set; }
		[Ordinal(3)]  [RED("materialOverrides")] public CArray<CName> MaterialOverrides { get; set; }

		public audioPhysicalPropSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
