using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class audioAudioMaterialMetadataMapItem : audioAudioMetadata
	{
		[Ordinal(0)]  [RED("footstepsMetadata")] public CName FootstepsMetadata { get; set; }
		[Ordinal(1)]  [RED("ragdollMetadata")] public CName RagdollMetadata { get; set; }
		[Ordinal(2)]  [RED("physicalMaterial")] public CName PhysicalMaterial { get; set; }
		[Ordinal(3)]  [RED("obstructionData")] public CName ObstructionData { get; set; }
		[Ordinal(4)]  [RED("reflectionParams")] public CName ReflectionParams { get; set; }
		[Ordinal(5)]  [RED("meleeMaterialName")] public CName MeleeMaterialName { get; set; }
		[Ordinal(6)]  [RED("vehicleMaterialName")] public CName VehicleMaterialName { get; set; }
		[Ordinal(7)]  [RED("foliageMaterialName")] public CName FoliageMaterialName { get; set; }
		[Ordinal(8)]  [RED("foliagePaletteTag")] public CName FoliagePaletteTag { get; set; }
		[Ordinal(9)]  [RED("meleeMaterialType")] public CEnum<audioMeleeMaterialType> MeleeMaterialType { get; set; }

		public audioAudioMaterialMetadataMapItem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
