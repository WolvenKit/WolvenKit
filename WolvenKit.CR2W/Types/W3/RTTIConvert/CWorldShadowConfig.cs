using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CWorldShadowConfig : CVariable
	{
		[RED("numCascades")] 		public CInt32 NumCascades { get; set;}

		[RED("cascadeRange1")] 		public CFloat CascadeRange1 { get; set;}

		[RED("cascadeRange2")] 		public CFloat CascadeRange2 { get; set;}

		[RED("cascadeRange3")] 		public CFloat CascadeRange3 { get; set;}

		[RED("cascadeRange4")] 		public CFloat CascadeRange4 { get; set;}

		[RED("cascadeFilterSize1")] 		public CFloat CascadeFilterSize1 { get; set;}

		[RED("cascadeFilterSize2")] 		public CFloat CascadeFilterSize2 { get; set;}

		[RED("cascadeFilterSize3")] 		public CFloat CascadeFilterSize3 { get; set;}

		[RED("cascadeFilterSize4")] 		public CFloat CascadeFilterSize4 { get; set;}

		[RED("shadowEdgeFade1")] 		public CFloat ShadowEdgeFade1 { get; set;}

		[RED("shadowEdgeFade2")] 		public CFloat ShadowEdgeFade2 { get; set;}

		[RED("shadowEdgeFade3")] 		public CFloat ShadowEdgeFade3 { get; set;}

		[RED("shadowEdgeFade4")] 		public CFloat ShadowEdgeFade4 { get; set;}

		[RED("shadowBiasOffsetSlopeMul")] 		public CFloat ShadowBiasOffsetSlopeMul { get; set;}

		[RED("shadowBiasOffsetConst")] 		public CFloat ShadowBiasOffsetConst { get; set;}

		[RED("shadowBiasOffsetConstCascade1")] 		public CFloat ShadowBiasOffsetConstCascade1 { get; set;}

		[RED("shadowBiasOffsetConstCascade2")] 		public CFloat ShadowBiasOffsetConstCascade2 { get; set;}

		[RED("shadowBiasOffsetConstCascade3")] 		public CFloat ShadowBiasOffsetConstCascade3 { get; set;}

		[RED("shadowBiasOffsetConstCascade4")] 		public CFloat ShadowBiasOffsetConstCascade4 { get; set;}

		[RED("shadowBiasCascadeMultiplier")] 		public CFloat ShadowBiasCascadeMultiplier { get; set;}

		[RED("speedTreeShadowFilterSize1")] 		public CFloat SpeedTreeShadowFilterSize1 { get; set;}

		[RED("speedTreeShadowFilterSize2")] 		public CFloat SpeedTreeShadowFilterSize2 { get; set;}

		[RED("speedTreeShadowFilterSize3")] 		public CFloat SpeedTreeShadowFilterSize3 { get; set;}

		[RED("speedTreeShadowFilterSize4")] 		public CFloat SpeedTreeShadowFilterSize4 { get; set;}

		[RED("speedTreeShadowGradient")] 		public CFloat SpeedTreeShadowGradient { get; set;}

		[RED("hiResShadowBiasOffsetSlopeMul")] 		public CFloat HiResShadowBiasOffsetSlopeMul { get; set;}

		[RED("hiResShadowBiasOffsetConst")] 		public CFloat HiResShadowBiasOffsetConst { get; set;}

		[RED("hiResShadowTexelRadius")] 		public CFloat HiResShadowTexelRadius { get; set;}

		[RED("useTerrainShadows")] 		public CBool UseTerrainShadows { get; set;}

		[RED("terrainShadowsDistance")] 		public CFloat TerrainShadowsDistance { get; set;}

		[RED("terrainShadowsFadeRange")] 		public CFloat TerrainShadowsFadeRange { get; set;}

		[RED("terrainShadowsBaseSmoothing")] 		public CFloat TerrainShadowsBaseSmoothing { get; set;}

		[RED("terrainShadowsTerrainDistanceSoftness")] 		public CFloat TerrainShadowsTerrainDistanceSoftness { get; set;}

		[RED("terrainShadowsMeshDistanceSoftness")] 		public CFloat TerrainShadowsMeshDistanceSoftness { get; set;}

		[RED("terrainMeshShadowDistance")] 		public CFloat TerrainMeshShadowDistance { get; set;}

		[RED("terrainMeshShadowFadeRange")] 		public CFloat TerrainMeshShadowFadeRange { get; set;}

		public CWorldShadowConfig(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CWorldShadowConfig(cr2w);

	}
}