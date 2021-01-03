using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class audioShockwaveMetadata : audioEmitterMetadata
	{
		[Ordinal(0)]  [RED("electroshockMetadataName")] public CName ElectroshockMetadataName { get; set; }
		[Ordinal(1)]  [RED("explosionMetadataName")] public CName ExplosionMetadataName { get; set; }
		[Ordinal(2)]  [RED("revealMetadataName")] public CName RevealMetadataName { get; set; }
		[Ordinal(3)]  [RED("thumpMetadataName")] public CName ThumpMetadataName { get; set; }

		public audioShockwaveMetadata(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
