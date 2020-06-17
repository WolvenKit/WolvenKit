using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CR4WorldDescriptionDLC : CObject
	{
		[RED("worldEnumAreaName")] 		public CName WorldEnumAreaName { get; set;}

		[RED("worldName")] 		public CString WorldName { get; set;}

		[RED("worldMapPath")] 		public CString WorldMapPath { get; set;}

		[RED("worldMapPinX")] 		public CInt32 WorldMapPinX { get; set;}

		[RED("worldMapPinY")] 		public CInt32 WorldMapPinY { get; set;}

		[RED("worldMapLoactionNameStringKey")] 		public CName WorldMapLoactionNameStringKey { get; set;}

		[RED("worldMapLoactionDescriptionStringKey")] 		public CName WorldMapLoactionDescriptionStringKey { get; set;}

		[RED("worldMiniMapSize")] 		public CFloat WorldMiniMapSize { get; set;}

		[RED("worldMiniMapTileCount")] 		public CInt32 WorldMiniMapTileCount { get; set;}

		[RED("worldMiniMapExteriorTextureSize")] 		public CInt32 WorldMiniMapExteriorTextureSize { get; set;}

		[RED("worldMiniMapInteriorTextureSize")] 		public CInt32 WorldMiniMapInteriorTextureSize { get; set;}

		[RED("worldMiniMapTextureSize")] 		public CInt32 WorldMiniMapTextureSize { get; set;}

		[RED("worldMiniMapMinLod")] 		public CInt32 WorldMiniMapMinLod { get; set;}

		[RED("worldMiniMapMaxLod")] 		public CInt32 WorldMiniMapMaxLod { get; set;}

		[RED("worldMiniMapExteriorTextureExtension")] 		public CString WorldMiniMapExteriorTextureExtension { get; set;}

		[RED("worldMiniMapInteriorTextureExtension")] 		public CString WorldMiniMapInteriorTextureExtension { get; set;}

		[RED("worldMiniMapVminX")] 		public CInt32 WorldMiniMapVminX { get; set;}

		[RED("worldMiniMapVmaxX")] 		public CInt32 WorldMiniMapVmaxX { get; set;}

		[RED("worldMiniMapVminY")] 		public CInt32 WorldMiniMapVminY { get; set;}

		[RED("worldMiniMapVmaxY")] 		public CInt32 WorldMiniMapVmaxY { get; set;}

		[RED("worldMiniMapSminX")] 		public CInt32 WorldMiniMapSminX { get; set;}

		[RED("worldMiniMapSmaxX")] 		public CInt32 WorldMiniMapSmaxX { get; set;}

		[RED("worldMiniMapSminY")] 		public CInt32 WorldMiniMapSminY { get; set;}

		[RED("worldMiniMapSmaxY")] 		public CInt32 WorldMiniMapSmaxY { get; set;}

		[RED("worldMiniMapMinZoom")] 		public CFloat WorldMiniMapMinZoom { get; set;}

		[RED("worldMiniMapMaxZoom")] 		public CFloat WorldMiniMapMaxZoom { get; set;}

		[RED("worldMiniMapZoom12")] 		public CFloat WorldMiniMapZoom12 { get; set;}

		[RED("worldMiniMapZoom23")] 		public CFloat WorldMiniMapZoom23 { get; set;}

		[RED("worldMiniMapZoom34")] 		public CFloat WorldMiniMapZoom34 { get; set;}

		[RED("worldGradientScale")] 		public CFloat WorldGradientScale { get; set;}

		[RED("worldPreviewHeight")] 		public CFloat WorldPreviewHeight { get; set;}

		public CR4WorldDescriptionDLC(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CR4WorldDescriptionDLC(cr2w);

	}
}