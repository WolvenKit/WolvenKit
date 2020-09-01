using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CR4WorldDescriptionDLC : CObject
	{
		[Ordinal(0)] [RED("("worldEnumAreaName")] 		public CName WorldEnumAreaName { get; set;}

		[Ordinal(0)] [RED("("worldName")] 		public CString WorldName { get; set;}

		[Ordinal(0)] [RED("("worldMapPath")] 		public CString WorldMapPath { get; set;}

		[Ordinal(0)] [RED("("worldMapPinX")] 		public CInt32 WorldMapPinX { get; set;}

		[Ordinal(0)] [RED("("worldMapPinY")] 		public CInt32 WorldMapPinY { get; set;}

		[Ordinal(0)] [RED("("worldMapLoactionNameStringKey")] 		public CName WorldMapLoactionNameStringKey { get; set;}

		[Ordinal(0)] [RED("("worldMapLoactionDescriptionStringKey")] 		public CName WorldMapLoactionDescriptionStringKey { get; set;}

		[Ordinal(0)] [RED("("worldMiniMapSize")] 		public CFloat WorldMiniMapSize { get; set;}

		[Ordinal(0)] [RED("("worldMiniMapTileCount")] 		public CInt32 WorldMiniMapTileCount { get; set;}

		[Ordinal(0)] [RED("("worldMiniMapExteriorTextureSize")] 		public CInt32 WorldMiniMapExteriorTextureSize { get; set;}

		[Ordinal(0)] [RED("("worldMiniMapInteriorTextureSize")] 		public CInt32 WorldMiniMapInteriorTextureSize { get; set;}

		[Ordinal(0)] [RED("("worldMiniMapTextureSize")] 		public CInt32 WorldMiniMapTextureSize { get; set;}

		[Ordinal(0)] [RED("("worldMiniMapMinLod")] 		public CInt32 WorldMiniMapMinLod { get; set;}

		[Ordinal(0)] [RED("("worldMiniMapMaxLod")] 		public CInt32 WorldMiniMapMaxLod { get; set;}

		[Ordinal(0)] [RED("("worldMiniMapExteriorTextureExtension")] 		public CString WorldMiniMapExteriorTextureExtension { get; set;}

		[Ordinal(0)] [RED("("worldMiniMapInteriorTextureExtension")] 		public CString WorldMiniMapInteriorTextureExtension { get; set;}

		[Ordinal(0)] [RED("("worldMiniMapVminX")] 		public CInt32 WorldMiniMapVminX { get; set;}

		[Ordinal(0)] [RED("("worldMiniMapVmaxX")] 		public CInt32 WorldMiniMapVmaxX { get; set;}

		[Ordinal(0)] [RED("("worldMiniMapVminY")] 		public CInt32 WorldMiniMapVminY { get; set;}

		[Ordinal(0)] [RED("("worldMiniMapVmaxY")] 		public CInt32 WorldMiniMapVmaxY { get; set;}

		[Ordinal(0)] [RED("("worldMiniMapSminX")] 		public CInt32 WorldMiniMapSminX { get; set;}

		[Ordinal(0)] [RED("("worldMiniMapSmaxX")] 		public CInt32 WorldMiniMapSmaxX { get; set;}

		[Ordinal(0)] [RED("("worldMiniMapSminY")] 		public CInt32 WorldMiniMapSminY { get; set;}

		[Ordinal(0)] [RED("("worldMiniMapSmaxY")] 		public CInt32 WorldMiniMapSmaxY { get; set;}

		[Ordinal(0)] [RED("("worldMiniMapMinZoom")] 		public CFloat WorldMiniMapMinZoom { get; set;}

		[Ordinal(0)] [RED("("worldMiniMapMaxZoom")] 		public CFloat WorldMiniMapMaxZoom { get; set;}

		[Ordinal(0)] [RED("("worldMiniMapZoom12")] 		public CFloat WorldMiniMapZoom12 { get; set;}

		[Ordinal(0)] [RED("("worldMiniMapZoom23")] 		public CFloat WorldMiniMapZoom23 { get; set;}

		[Ordinal(0)] [RED("("worldMiniMapZoom34")] 		public CFloat WorldMiniMapZoom34 { get; set;}

		[Ordinal(0)] [RED("("worldGradientScale")] 		public CFloat WorldGradientScale { get; set;}

		[Ordinal(0)] [RED("("worldPreviewHeight")] 		public CFloat WorldPreviewHeight { get; set;}

		public CR4WorldDescriptionDLC(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CR4WorldDescriptionDLC(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}