using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public partial class CClipMap : CObject
	{
		[RED("clipSize")] 		public CUInt32 ClipSize { get; set;}

		[RED("clipmapSize")] 		public CUInt32 ClipmapSize { get; set;}

		[RED("numClipmapStackLevels")] 		public CUInt32 NumClipmapStackLevels { get; set;}

		[RED("tileRes")] 		public CUInt32 TileRes { get; set;}

		[RED("colormapStartingMip")] 		public CInt32 ColormapStartingMip { get; set;}

		[RED("terrainSize")] 		public CFloat TerrainSize { get; set;}

		[RED("terrainCorner")] 		public Vector TerrainCorner { get; set;}

		[RED("numTilesPerEdge")] 		public CUInt32 NumTilesPerEdge { get; set;}

		[RED("lowestElevation")] 		public CFloat LowestElevation { get; set;}

		[RED("highestElevation")] 		public CFloat HighestElevation { get; set;}

		[RED("material")] 		public CHandle<IMaterial> Material { get; set;}

		[RED("textureParams", 2,0)] 		public CArray<STerrainTextureParameters> TextureParams { get; set;}

		[RED("grassBrushes", 2,0)] 		public CArray<CHandle<CVegetationBrush>> GrassBrushes { get; set;}

		[RED("tileHeightRanges", 2,0)] 		public CArray<Vector2> TileHeightRanges { get; set;}

		[RED("minWaterHeight", 2,0)] 		public CArray<CFloat> MinWaterHeight { get; set;}

		[RED("cookedMipStackHeight")] 		public DataBuffer CookedMipStackHeight { get; set;}

		[RED("cookedMipStackControl")] 		public DataBuffer CookedMipStackControl { get; set;}

		[RED("cookedMipStackColor")] 		public DataBuffer CookedMipStackColor { get; set;}

		[RED("cookedData")] 		public CPtr<CClipMapCookedData> CookedData { get; set;}

		public CClipMap(CR2WFile cr2w) : base(cr2w){ }

		public override CVariable Create(CR2WFile cr2w) => new CClipMap(cr2w);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}