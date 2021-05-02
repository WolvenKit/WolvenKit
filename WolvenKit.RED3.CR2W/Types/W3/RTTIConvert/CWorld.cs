using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CWorld : CResource
	{
		[Ordinal(1)] [RED("startupCameraPosition")] 		public Vector StartupCameraPosition { get; set;}

		[Ordinal(2)] [RED("startupCameraRotation")] 		public EulerAngles StartupCameraRotation { get; set;}

		[Ordinal(3)] [RED("terrainClipMap")] 		public CPtr<CClipMap> TerrainClipMap { get; set;}

		[Ordinal(4)] [RED("newLayerGroupFormat")] 		public CBool NewLayerGroupFormat { get; set;}

		[Ordinal(5)] [RED("hasEmbeddedLayerInfos")] 		public CBool HasEmbeddedLayerInfos { get; set;}

		[Ordinal(6)] [RED("initialyHidenLayerGroups")] 		public CHandle<C2dArray> InitialyHidenLayerGroups { get; set;}

		[Ordinal(7)] [RED("umbraScene")] 		public CHandle<CUmbraScene> UmbraScene { get; set;}

		[Ordinal(8)] [RED("globalWater")] 		public CPtr<CGlobalWater> GlobalWater { get; set;}

		[Ordinal(9)] [RED("pathLib")] 		public CPtr<CPathLibWorld> PathLib { get; set;}

		[Ordinal(10)] [RED("worldDimensions")] 		public CFloat WorldDimensions { get; set;}

		[Ordinal(11)] [RED("shadowConfig")] 		public CWorldShadowConfig ShadowConfig { get; set;}

		[Ordinal(12)] [RED("environmentParameters")] 		public SWorldEnvironmentParameters EnvironmentParameters { get; set;}

		[Ordinal(13)] [RED("soundBanksDependency", 2,0)] 		public CArray<CName> SoundBanksDependency { get; set;}

		[Ordinal(14)] [RED("soundEventsOnAttach", 2,0)] 		public CArray<StringAnsi> SoundEventsOnAttach { get; set;}

		[Ordinal(15)] [RED("soundEventsOnDetach", 2,0)] 		public CArray<StringAnsi> SoundEventsOnDetach { get; set;}

		[Ordinal(16)] [RED("foliageScene")] 		public CPtr<CFoliageScene> FoliageScene { get; set;}

		[Ordinal(17)] [RED("playGoChunks", 2,0)] 		public CArray<CName> PlayGoChunks { get; set;}

		[Ordinal(18)] [RED("minimapsPath")] 		public CString MinimapsPath { get; set;}

		[Ordinal(19)] [RED("hubmapsPath")] 		public CString HubmapsPath { get; set;}

		[Ordinal(20)] [RED("mergedGeometry")] 		public CPtr<CMergedWorldGeometry> MergedGeometry { get; set;}

		public CWorld(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CWorld(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}