using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CWorld : CResource
	{
		[Ordinal(0)] [RED("startupCameraPosition")] 		public Vector StartupCameraPosition { get; set;}

		[Ordinal(0)] [RED("startupCameraRotation")] 		public EulerAngles StartupCameraRotation { get; set;}

		[Ordinal(0)] [RED("terrainClipMap")] 		public CPtr<CClipMap> TerrainClipMap { get; set;}

		[Ordinal(0)] [RED("newLayerGroupFormat")] 		public CBool NewLayerGroupFormat { get; set;}

		[Ordinal(0)] [RED("hasEmbeddedLayerInfos")] 		public CBool HasEmbeddedLayerInfos { get; set;}

		[Ordinal(0)] [RED("initialyHidenLayerGroups")] 		public CHandle<C2dArray> InitialyHidenLayerGroups { get; set;}

		[Ordinal(0)] [RED("umbraScene")] 		public CHandle<CUmbraScene> UmbraScene { get; set;}

		[Ordinal(0)] [RED("globalWater")] 		public CPtr<CGlobalWater> GlobalWater { get; set;}

		[Ordinal(0)] [RED("pathLib")] 		public CPtr<CPathLibWorld> PathLib { get; set;}

		[Ordinal(0)] [RED("worldDimensions")] 		public CFloat WorldDimensions { get; set;}

		[Ordinal(0)] [RED("shadowConfig")] 		public CWorldShadowConfig ShadowConfig { get; set;}

		[Ordinal(0)] [RED("environmentParameters")] 		public SWorldEnvironmentParameters EnvironmentParameters { get; set;}

		[Ordinal(0)] [RED("soundBanksDependency", 2,0)] 		public CArray<CName> SoundBanksDependency { get; set;}

		[Ordinal(0)] [RED("soundEventsOnAttach", 2,0)] 		public CArray<StringAnsi> SoundEventsOnAttach { get; set;}

		[Ordinal(0)] [RED("soundEventsOnDetach", 2,0)] 		public CArray<StringAnsi> SoundEventsOnDetach { get; set;}

		[Ordinal(0)] [RED("foliageScene")] 		public CPtr<CFoliageScene> FoliageScene { get; set;}

		[Ordinal(0)] [RED("playGoChunks", 2,0)] 		public CArray<CName> PlayGoChunks { get; set;}

		[Ordinal(0)] [RED("minimapsPath")] 		public CString MinimapsPath { get; set;}

		[Ordinal(0)] [RED("hubmapsPath")] 		public CString HubmapsPath { get; set;}

		[Ordinal(0)] [RED("mergedGeometry")] 		public CPtr<CMergedWorldGeometry> MergedGeometry { get; set;}

		public CWorld(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CWorld(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}