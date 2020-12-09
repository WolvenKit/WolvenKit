using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public partial class CClipMap : CObject
	{
		[Ordinal(1)] [RED("clipSize")] 		public CUInt32 ClipSize { get; set;}

		[Ordinal(2)] [RED("clipmapSize")] 		public CUInt32 ClipmapSize { get; set;}

		[Ordinal(3)] [RED("numClipmapStackLevels")] 		public CUInt32 NumClipmapStackLevels { get; set;}

		[Ordinal(4)] [RED("tileRes")] 		public CUInt32 TileRes { get; set;}

		[Ordinal(5)] [RED("colormapStartingMip")] 		public CInt32 ColormapStartingMip { get; set;}

		[Ordinal(6)] [RED("terrainSize")] 		public CFloat TerrainSize { get; set;}

		[Ordinal(7)] [RED("terrainCorner")] 		public Vector TerrainCorner { get; set;}

		[Ordinal(8)] [RED("numTilesPerEdge")] 		public CUInt32 NumTilesPerEdge { get; set;}

		[Ordinal(9)] [RED("lowestElevation")] 		public CFloat LowestElevation { get; set;}

		[Ordinal(10)] [RED("highestElevation")] 		public CFloat HighestElevation { get; set;}

		[Ordinal(11)] [RED("material")] 		public CHandle<IMaterial> Material { get; set;}

		[Ordinal(12)] [RED("textureParams", 2,0)] 		public CArray<STerrainTextureParameters> TextureParams { get; set;}

		[Ordinal(13)] [RED("grassBrushes", 2,0)] 		public CArray<CHandle<CVegetationBrush>> GrassBrushes { get; set;}

		[Ordinal(14)] [RED("tileHeightRanges", 2,0)] 		public CArray<Vector2> TileHeightRanges { get; set;}

		[Ordinal(15)] [RED("minWaterHeight", 2,0)] 		public CArray<CFloat> MinWaterHeight { get; set;}

		[Ordinal(16)] [RED("cookedMipStackHeight")] 		public DataBuffer CookedMipStackHeight { get; set;}

		[Ordinal(17)] [RED("cookedMipStackControl")] 		public DataBuffer CookedMipStackControl { get; set;}

		[Ordinal(18)] [RED("cookedMipStackColor")] 		public DataBuffer CookedMipStackColor { get; set;}

		[Ordinal(19)] [RED("cookedData")] 		public CPtr<CClipMapCookedData> CookedData { get; set;}

		public CClipMap(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CClipMap(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}