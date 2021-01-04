using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class audioAudioMaterialMetadataMapItem : audioAudioMetadata
	{
		[Ordinal(0)]  [RED("foliageMaterialName")] public CName FoliageMaterialName { get; set; }
		[Ordinal(1)]  [RED("foliagePaletteTag")] public CName FoliagePaletteTag { get; set; }
		[Ordinal(2)]  [RED("footstepsMetadata")] public CName FootstepsMetadata { get; set; }
		[Ordinal(3)]  [RED("meleeMaterialName")] public CName MeleeMaterialName { get; set; }
		[Ordinal(4)]  [RED("meleeMaterialType")] public CEnum<audioMeleeMaterialType> MeleeMaterialType { get; set; }
		[Ordinal(5)]  [RED("obstructionData")] public CName ObstructionData { get; set; }
		[Ordinal(6)]  [RED("physicalMaterial")] public CName PhysicalMaterial { get; set; }
		[Ordinal(7)]  [RED("ragdollMetadata")] public CName RagdollMetadata { get; set; }
		[Ordinal(8)]  [RED("reflectionParams")] public CName ReflectionParams { get; set; }
		[Ordinal(9)]  [RED("vehicleMaterialName")] public CName VehicleMaterialName { get; set; }

		public audioAudioMaterialMetadataMapItem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
