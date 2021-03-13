using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public partial class CR4WorldDescriptionDLC : CObject
	{
		[Ordinal(0)] [RED("worldEnumAreaName")] 		public CName WorldEnumAreaName { get; set;}

		[Ordinal(1)] [RED("worldName")] 		public CString WorldName { get; set;}

		[Ordinal(2)] [RED("worldMapPath")] 		public CString WorldMapPath { get; set;}

		[Ordinal(3)] [RED("worldMapPinX")] 		public CInt32 WorldMapPinX { get; set;}

		[Ordinal(4)] [RED("worldMapPinY")] 		public CInt32 WorldMapPinY { get; set;}

		[Ordinal(5)] [RED("worldMapLoactionNameStringKey")] 		public CName WorldMapLoactionNameStringKey { get; set;}

		[Ordinal(6)] [RED("worldMapLoactionDescriptionStringKey")] 		public CName WorldMapLoactionDescriptionStringKey { get; set;}

		/// <summary>
		///  Missing in RTTI
		/// </summary>
		[Ordinal(7)] [RED("requiredChunk")] public CName RequiredChunk { get; set; }

		[Ordinal(8)] [RED("worldMiniMapSize")] 		public CFloat WorldMiniMapSize { get; set;}

		[Ordinal(9)] [RED("worldMiniMapTileCount")] 		public CInt32 WorldMiniMapTileCount { get; set;}

		[Ordinal(10)] [RED("worldMiniMapExteriorTextureSize")] 		public CInt32 WorldMiniMapExteriorTextureSize { get; set;}

		[Ordinal(11)] [RED("worldMiniMapInteriorTextureSize")] 		public CInt32 WorldMiniMapInteriorTextureSize { get; set;}

		[Ordinal(12)] [RED("worldMiniMapTextureSize")] 		public CInt32 WorldMiniMapTextureSize { get; set;}

		[Ordinal(13)] [RED("worldMiniMapMinLod")] 		public CInt32 WorldMiniMapMinLod { get; set;}

		[Ordinal(14)] [RED("worldMiniMapMaxLod")] 		public CInt32 WorldMiniMapMaxLod { get; set;}

		[Ordinal(15)] [RED("worldMiniMapExteriorTextureExtension")] 		public CString WorldMiniMapExteriorTextureExtension { get; set;}

		[Ordinal(16)] [RED("worldMiniMapInteriorTextureExtension")] 		public CString WorldMiniMapInteriorTextureExtension { get; set;}

		[Ordinal(17)] [RED("worldMiniMapVminX")] 		public CInt32 WorldMiniMapVminX { get; set;}

		[Ordinal(18)] [RED("worldMiniMapVmaxX")] 		public CInt32 WorldMiniMapVmaxX { get; set;}

		[Ordinal(19)] [RED("worldMiniMapVminY")] 		public CInt32 WorldMiniMapVminY { get; set;}

		[Ordinal(20)] [RED("worldMiniMapVmaxY")] 		public CInt32 WorldMiniMapVmaxY { get; set;}

		[Ordinal(21)] [RED("worldMiniMapSminX")] 		public CInt32 WorldMiniMapSminX { get; set;}

		[Ordinal(22)] [RED("worldMiniMapSmaxX")] 		public CInt32 WorldMiniMapSmaxX { get; set;}

		[Ordinal(23)] [RED("worldMiniMapSminY")] 		public CInt32 WorldMiniMapSminY { get; set;}

		[Ordinal(24)] [RED("worldMiniMapSmaxY")] 		public CInt32 WorldMiniMapSmaxY { get; set;}

		[Ordinal(25)] [RED("worldMiniMapMinZoom")] 		public CFloat WorldMiniMapMinZoom { get; set;}

		[Ordinal(26)] [RED("worldMiniMapMaxZoom")] 		public CFloat WorldMiniMapMaxZoom { get; set;}

		[Ordinal(27)] [RED("worldMiniMapZoom12")] 		public CFloat WorldMiniMapZoom12 { get; set;}

		[Ordinal(28)] [RED("worldMiniMapZoom23")] 		public CFloat WorldMiniMapZoom23 { get; set;}

		[Ordinal(29)] [RED("worldMiniMapZoom34")] 		public CFloat WorldMiniMapZoom34 { get; set;}

		[Ordinal(30)] [RED("worldGradientScale")] 		public CFloat WorldGradientScale { get; set;}

		[Ordinal(31)] [RED("worldPreviewHeight")] 		public CFloat WorldPreviewHeight { get; set;}

		public CR4WorldDescriptionDLC(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CR4WorldDescriptionDLC(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}