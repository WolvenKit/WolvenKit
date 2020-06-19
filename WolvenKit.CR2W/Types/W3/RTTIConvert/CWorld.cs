using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CWorld : CResource
	{
		[RED("startupCameraPosition")] 		public Vector StartupCameraPosition { get; set;}

		[RED("startupCameraRotation")] 		public EulerAngles StartupCameraRotation { get; set;}

		[RED("terrainClipMap")] 		public CPtr<CClipMap> TerrainClipMap { get; set;}

		[RED("newLayerGroupFormat")] 		public CBool NewLayerGroupFormat { get; set;}

		[RED("hasEmbeddedLayerInfos")] 		public CBool HasEmbeddedLayerInfos { get; set;}

		[RED("initialyHidenLayerGroups")] 		public CHandle<C2dArray> InitialyHidenLayerGroups { get; set;}

		[RED("umbraScene")] 		public CHandle<CUmbraScene> UmbraScene { get; set;}

		[RED("globalWater")] 		public CPtr<CGlobalWater> GlobalWater { get; set;}

		[RED("pathLib")] 		public CPtr<CPathLibWorld> PathLib { get; set;}

		[RED("worldDimensions")] 		public CFloat WorldDimensions { get; set;}

		[RED("shadowConfig")] 		public CWorldShadowConfig ShadowConfig { get; set;}

		[RED("environmentParameters")] 		public SWorldEnvironmentParameters EnvironmentParameters { get; set;}

		[RED("soundBanksDependency", 2,0)] 		public CArray<CName> SoundBanksDependency { get; set;}

		[RED("soundEventsOnAttach", 2,0)] 		public CArray<StringAnsi> SoundEventsOnAttach { get; set;}

		[RED("soundEventsOnDetach", 2,0)] 		public CArray<StringAnsi> SoundEventsOnDetach { get; set;}

		[RED("foliageScene")] 		public CPtr<CFoliageScene> FoliageScene { get; set;}

		[RED("playGoChunks", 2,0)] 		public CArray<CName> PlayGoChunks { get; set;}

		[RED("minimapsPath")] 		public CString MinimapsPath { get; set;}

		[RED("hubmapsPath")] 		public CString HubmapsPath { get; set;}

		[RED("mergedGeometry")] 		public CPtr<CMergedWorldGeometry> MergedGeometry { get; set;}

		public CWorld(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public override CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CWorld(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}