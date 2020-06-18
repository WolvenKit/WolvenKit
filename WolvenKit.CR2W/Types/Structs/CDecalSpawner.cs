using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[REDMeta(EREDMetaInfo.REDStruct)]
	public class CDecalSpawner : CObject
	{
		[RED("material")] 		public SDynamicDecalMaterialInfo Material { get; set;}

		[RED("farZ")] 		public CFloat FarZ { get; set;}

		[RED("nearZ")] 		public CFloat NearZ { get; set;}

		[RED("size")] 		public CPtr<IEvaluatorFloat> Size { get; set;}

		[RED("depthFadePower")] 		public CFloat DepthFadePower { get; set;}

		[RED("normalFadeBias")] 		public CFloat NormalFadeBias { get; set;}

		[RED("normalFadeScale")] 		public CFloat NormalFadeScale { get; set;}

		[RED("doubleSided")] 		public CBool DoubleSided { get; set;}

		[RED("projectionMode")] 		public ERenderDynamicDecalProjection ProjectionMode { get; set;}

		[RED("decalLifetime")] 		public CPtr<IEvaluatorFloat> DecalLifetime { get; set;}

		[RED("decalFadeTime")] 		public CFloat DecalFadeTime { get; set;}

		[RED("decalFadeInTime")] 		public CFloat DecalFadeInTime { get; set;}

		[RED("projectOnlyOnStatic")] 		public CBool ProjectOnlyOnStatic { get; set;}

		[RED("startScale")] 		public CFloat StartScale { get; set;}

		[RED("scaleTime")] 		public CFloat ScaleTime { get; set;}

		[RED("useVerticalProjection")] 		public CBool UseVerticalProjection { get; set;}

		[RED("spawnPriority")] 		public EDynamicDecalSpawnPriority SpawnPriority { get; set;}

		[RED("autoHideDistance")] 		public CFloat AutoHideDistance { get; set;}

		[RED("chance")] 		public CFloat Chance { get; set;}

		[RED("spawnFrequency")] 		public CFloat SpawnFrequency { get; set;}

		public CDecalSpawner(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CDecalSpawner(cr2w);

	}
}