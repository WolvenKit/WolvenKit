using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class CDecalSpawner : ISerializable
	{
		[Ordinal(0)]  [RED("materialStatic")] public rRef<IMaterial> MaterialStatic { get; set; }
		[Ordinal(1)]  [RED("materialSkinned")] public rRef<IMaterial> MaterialSkinned { get; set; }
		[Ordinal(2)]  [RED("specularColor")] public CColor SpecularColor { get; set; }
		[Ordinal(3)]  [RED("specularScale")] public CFloat SpecularScale { get; set; }
		[Ordinal(4)]  [RED("specularBase")] public CFloat SpecularBase { get; set; }
		[Ordinal(5)]  [RED("specularity")] public CFloat Specularity { get; set; }
		[Ordinal(6)]  [RED("roughnessScale")] public CFloat RoughnessScale { get; set; }
		[Ordinal(7)]  [RED("normalThreshold")] public CFloat NormalThreshold { get; set; }
		[Ordinal(8)]  [RED("additiveNormals")] public CBool AdditiveNormals { get; set; }
		[Ordinal(9)]  [RED("diffuseRandomColor0")] public CColor DiffuseRandomColor0 { get; set; }
		[Ordinal(10)]  [RED("diffuseRandomColor1")] public CColor DiffuseRandomColor1 { get; set; }
		[Ordinal(11)]  [RED("subUVType")] public CEnum<ERenderDynamicDecalAtlas> SubUVType { get; set; }
		[Ordinal(12)]  [RED("farZ")] public CFloat FarZ { get; set; }
		[Ordinal(13)]  [RED("nearZ")] public CFloat NearZ { get; set; }
		[Ordinal(14)]  [RED("size")] public CHandle<IEvaluatorFloat> Size { get; set; }
		[Ordinal(15)]  [RED("depthFadePower")] public CFloat DepthFadePower { get; set; }
		[Ordinal(16)]  [RED("normalFadeBias")] public CFloat NormalFadeBias { get; set; }
		[Ordinal(17)]  [RED("normalFadeScale")] public CFloat NormalFadeScale { get; set; }
		[Ordinal(18)]  [RED("doubleSided")] public CBool DoubleSided { get; set; }
		[Ordinal(19)]  [RED("projectionMode")] public CEnum<ERenderDynamicDecalProjection> ProjectionMode { get; set; }
		[Ordinal(20)]  [RED("decalLifetime")] public CHandle<IEvaluatorFloat> DecalLifetime { get; set; }
		[Ordinal(21)]  [RED("decalFadeTime")] public CFloat DecalFadeTime { get; set; }
		[Ordinal(22)]  [RED("decalFadeInTime")] public CFloat DecalFadeInTime { get; set; }
		[Ordinal(23)]  [RED("projectOnStatic")] public CBool ProjectOnStatic { get; set; }
		[Ordinal(24)]  [RED("projectOnSkinned")] public CBool ProjectOnSkinned { get; set; }
		[Ordinal(25)]  [RED("startScale")] public CFloat StartScale { get; set; }
		[Ordinal(26)]  [RED("scaleTime")] public CFloat ScaleTime { get; set; }
		[Ordinal(27)]  [RED("useVerticalProjection")] public CBool UseVerticalProjection { get; set; }
		[Ordinal(28)]  [RED("spawnPriority")] public CEnum<EDynamicDecalSpawnPriority> SpawnPriority { get; set; }
		[Ordinal(29)]  [RED("autoHideDistance")] public CFloat AutoHideDistance { get; set; }

		public CDecalSpawner(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
