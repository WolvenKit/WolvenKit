using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta()]
	public class CDecalSpawner : CObject
	{
		[Ordinal(1)] [RED("material")] 		public SDynamicDecalMaterialInfo Material { get; set;}

		[Ordinal(2)] [RED("farZ")] 		public CFloat FarZ { get; set;}

		[Ordinal(3)] [RED("nearZ")] 		public CFloat NearZ { get; set;}

		[Ordinal(4)] [RED("size")] 		public CPtr<IEvaluatorFloat> Size { get; set;}

		[Ordinal(5)] [RED("depthFadePower")] 		public CFloat DepthFadePower { get; set;}

		[Ordinal(6)] [RED("normalFadeBias")] 		public CFloat NormalFadeBias { get; set;}

		[Ordinal(7)] [RED("normalFadeScale")] 		public CFloat NormalFadeScale { get; set;}

		[Ordinal(8)] [RED("doubleSided")] 		public CBool DoubleSided { get; set;}

		[Ordinal(9)] [RED("projectionMode")] 		public CEnum<ERenderDynamicDecalProjection> ProjectionMode { get; set;}

		[Ordinal(10)] [RED("decalLifetime")] 		public CPtr<IEvaluatorFloat> DecalLifetime { get; set;}

		[Ordinal(11)] [RED("decalFadeTime")] 		public CFloat DecalFadeTime { get; set;}

		[Ordinal(12)] [RED("decalFadeInTime")] 		public CFloat DecalFadeInTime { get; set;}

		[Ordinal(13)] [RED("projectOnlyOnStatic")] 		public CBool ProjectOnlyOnStatic { get; set;}

		[Ordinal(14)] [RED("startScale")] 		public CFloat StartScale { get; set;}

		[Ordinal(15)] [RED("scaleTime")] 		public CFloat ScaleTime { get; set;}

		[Ordinal(16)] [RED("useVerticalProjection")] 		public CBool UseVerticalProjection { get; set;}

		[Ordinal(17)] [RED("spawnPriority")] 		public CEnum<EDynamicDecalSpawnPriority> SpawnPriority { get; set;}

		[Ordinal(18)] [RED("autoHideDistance")] 		public CFloat AutoHideDistance { get; set;}

		[Ordinal(19)] [RED("chance")] 		public CFloat Chance { get; set;}

		[Ordinal(20)] [RED("spawnFrequency")] 		public CFloat SpawnFrequency { get; set;}

		public CDecalSpawner(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CDecalSpawner(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}