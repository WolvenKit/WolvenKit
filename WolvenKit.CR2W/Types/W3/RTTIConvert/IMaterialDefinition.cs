using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class IMaterialDefinition : IMaterial
	{
		[RED("pixelParamBlockSize")] 		public CUInt32 PixelParamBlockSize { get; set;}

		[RED("vertexParamBlockSize")] 		public CUInt32 VertexParamBlockSize { get; set;}

		[RED("compileAllTechniques")] 		public CBool CompileAllTechniques { get; set;}

		[RED("canUseOnMeshes")] 		public CBool CanUseOnMeshes { get; set;}

		[RED("canUseOnDestructionMeshes")] 		public CBool CanUseOnDestructionMeshes { get; set;}

		[RED("canUseOnApexMeshes")] 		public CBool CanUseOnApexMeshes { get; set;}

		[RED("canUseOnParticles")] 		public CBool CanUseOnParticles { get; set;}

		[RED("canUseOnCollapsableObjects")] 		public CBool CanUseOnCollapsableObjects { get; set;}

		[RED("canUseSkinning")] 		public CBool CanUseSkinning { get; set;}

		[RED("canUseSkinnedInstancing")] 		public CBool CanUseSkinnedInstancing { get; set;}

		[RED("canUseOnMorphMeshes")] 		public CBool CanUseOnMorphMeshes { get; set;}

		public IMaterialDefinition(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new IMaterialDefinition(cr2w);

	}
}