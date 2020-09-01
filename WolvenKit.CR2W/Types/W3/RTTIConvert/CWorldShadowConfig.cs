using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CWorldShadowConfig : CVariable
	{
		[Ordinal(0)] [RED("numCascades")] 		public CInt32 NumCascades { get; set;}

		[Ordinal(0)] [RED("cascadeRange1")] 		public CFloat CascadeRange1 { get; set;}

		[Ordinal(0)] [RED("cascadeRange2")] 		public CFloat CascadeRange2 { get; set;}

		[Ordinal(0)] [RED("cascadeRange3")] 		public CFloat CascadeRange3 { get; set;}

		[Ordinal(0)] [RED("cascadeRange4")] 		public CFloat CascadeRange4 { get; set;}

		[Ordinal(0)] [RED("cascadeFilterSize1")] 		public CFloat CascadeFilterSize1 { get; set;}

		[Ordinal(0)] [RED("cascadeFilterSize2")] 		public CFloat CascadeFilterSize2 { get; set;}

		[Ordinal(0)] [RED("cascadeFilterSize3")] 		public CFloat CascadeFilterSize3 { get; set;}

		[Ordinal(0)] [RED("cascadeFilterSize4")] 		public CFloat CascadeFilterSize4 { get; set;}

		[Ordinal(0)] [RED("shadowEdgeFade1")] 		public CFloat ShadowEdgeFade1 { get; set;}

		[Ordinal(0)] [RED("shadowEdgeFade2")] 		public CFloat ShadowEdgeFade2 { get; set;}

		[Ordinal(0)] [RED("shadowEdgeFade3")] 		public CFloat ShadowEdgeFade3 { get; set;}

		[Ordinal(0)] [RED("shadowEdgeFade4")] 		public CFloat ShadowEdgeFade4 { get; set;}

		[Ordinal(0)] [RED("shadowBiasOffsetSlopeMul")] 		public CFloat ShadowBiasOffsetSlopeMul { get; set;}

		[Ordinal(0)] [RED("shadowBiasOffsetConst")] 		public CFloat ShadowBiasOffsetConst { get; set;}

		[Ordinal(0)] [RED("shadowBiasOffsetConstCascade1")] 		public CFloat ShadowBiasOffsetConstCascade1 { get; set;}

		[Ordinal(0)] [RED("shadowBiasOffsetConstCascade2")] 		public CFloat ShadowBiasOffsetConstCascade2 { get; set;}

		[Ordinal(0)] [RED("shadowBiasOffsetConstCascade3")] 		public CFloat ShadowBiasOffsetConstCascade3 { get; set;}

		[Ordinal(0)] [RED("shadowBiasOffsetConstCascade4")] 		public CFloat ShadowBiasOffsetConstCascade4 { get; set;}

		[Ordinal(0)] [RED("shadowBiasCascadeMultiplier")] 		public CFloat ShadowBiasCascadeMultiplier { get; set;}

		[Ordinal(0)] [RED("speedTreeShadowFilterSize1")] 		public CFloat SpeedTreeShadowFilterSize1 { get; set;}

		[Ordinal(0)] [RED("speedTreeShadowFilterSize2")] 		public CFloat SpeedTreeShadowFilterSize2 { get; set;}

		[Ordinal(0)] [RED("speedTreeShadowFilterSize3")] 		public CFloat SpeedTreeShadowFilterSize3 { get; set;}

		[Ordinal(0)] [RED("speedTreeShadowFilterSize4")] 		public CFloat SpeedTreeShadowFilterSize4 { get; set;}

		[Ordinal(0)] [RED("speedTreeShadowGradient")] 		public CFloat SpeedTreeShadowGradient { get; set;}

		[Ordinal(0)] [RED("hiResShadowBiasOffsetSlopeMul")] 		public CFloat HiResShadowBiasOffsetSlopeMul { get; set;}

		[Ordinal(0)] [RED("hiResShadowBiasOffsetConst")] 		public CFloat HiResShadowBiasOffsetConst { get; set;}

		[Ordinal(0)] [RED("hiResShadowTexelRadius")] 		public CFloat HiResShadowTexelRadius { get; set;}

		[Ordinal(0)] [RED("useTerrainShadows")] 		public CBool UseTerrainShadows { get; set;}

		[Ordinal(0)] [RED("terrainShadowsDistance")] 		public CFloat TerrainShadowsDistance { get; set;}

		[Ordinal(0)] [RED("terrainShadowsFadeRange")] 		public CFloat TerrainShadowsFadeRange { get; set;}

		[Ordinal(0)] [RED("terrainShadowsBaseSmoothing")] 		public CFloat TerrainShadowsBaseSmoothing { get; set;}

		[Ordinal(0)] [RED("terrainShadowsTerrainDistanceSoftness")] 		public CFloat TerrainShadowsTerrainDistanceSoftness { get; set;}

		[Ordinal(0)] [RED("terrainShadowsMeshDistanceSoftness")] 		public CFloat TerrainShadowsMeshDistanceSoftness { get; set;}

		[Ordinal(0)] [RED("terrainMeshShadowDistance")] 		public CFloat TerrainMeshShadowDistance { get; set;}

		[Ordinal(0)] [RED("terrainMeshShadowFadeRange")] 		public CFloat TerrainMeshShadowFadeRange { get; set;}

		public CWorldShadowConfig(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CWorldShadowConfig(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}