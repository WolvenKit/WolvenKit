using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta(EREDMetaInfo.REDStruct)]
	public class CParticleSystem : CResource
	{
		[RED("previewBackgroundColor")] 		public CColor PreviewBackgroundColor { get; set;}

		[RED("previewShowGrid")] 		public CBool PreviewShowGrid { get; set;}

		[RED("visibleThroughWalls")] 		public CBool VisibleThroughWalls { get; set;}

		[RED("prewarmingTime")] 		public CFloat PrewarmingTime { get; set;}

		[RED("emitters", 2,0)] 		public CArray<CPtr<CParticleEmitter>> Emitters { get; set;}

		[RED("lods", 2,0)] 		public CArray<SParticleSystemLODLevel> Lods { get; set;}

		[RED("autoHideDistance")] 		public CFloat AutoHideDistance { get; set;}

		[RED("autoHideRange")] 		public CFloat AutoHideRange { get; set;}

		[RED("renderingPlane")] 		public CEnum<ERenderingPlane> RenderingPlane { get; set;}

		public CParticleSystem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public override CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CParticleSystem(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}