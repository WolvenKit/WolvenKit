using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta()]
	public class CParticleSystem : CResource
	{
		[Ordinal(1)] [RED("previewBackgroundColor")] 		public CColor PreviewBackgroundColor { get; set;}

		[Ordinal(2)] [RED("previewShowGrid")] 		public CBool PreviewShowGrid { get; set;}

		[Ordinal(3)] [RED("visibleThroughWalls")] 		public CBool VisibleThroughWalls { get; set;}

		[Ordinal(4)] [RED("prewarmingTime")] 		public CFloat PrewarmingTime { get; set;}

		[Ordinal(5)] [RED("emitters", 2,0)] 		public CArray<CPtr<CParticleEmitter>> Emitters { get; set;}

		[Ordinal(6)] [RED("lods", 2,0)] 		public CArray<SParticleSystemLODLevel> Lods { get; set;}

		[Ordinal(7)] [RED("autoHideDistance")] 		public CFloat AutoHideDistance { get; set;}

		[Ordinal(8)] [RED("autoHideRange")] 		public CFloat AutoHideRange { get; set;}

		[Ordinal(9)] [RED("renderingPlane")] 		public CEnum<ERenderingPlane> RenderingPlane { get; set;}

		public CParticleSystem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CParticleSystem(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}