using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioShockwaveMetadata : audioEmitterMetadata
	{
		[Ordinal(1)] [RED("explosionMetadataName")] public CName ExplosionMetadataName { get; set; }
		[Ordinal(2)] [RED("thumpMetadataName")] public CName ThumpMetadataName { get; set; }
		[Ordinal(3)] [RED("electroshockMetadataName")] public CName ElectroshockMetadataName { get; set; }
		[Ordinal(4)] [RED("revealMetadataName")] public CName RevealMetadataName { get; set; }

		public audioShockwaveMetadata(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
