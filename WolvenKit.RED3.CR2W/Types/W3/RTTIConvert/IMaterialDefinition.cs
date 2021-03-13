using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class IMaterialDefinition : IMaterial
	{
		[Ordinal(1)] [RED("pixelParamBlockSize")] 		public CUInt32 PixelParamBlockSize { get; set;}

		[Ordinal(2)] [RED("vertexParamBlockSize")] 		public CUInt32 VertexParamBlockSize { get; set;}

		[Ordinal(3)] [RED("compileAllTechniques")] 		public CBool CompileAllTechniques { get; set;}

		[Ordinal(4)] [RED("canUseOnMeshes")] 		public CBool CanUseOnMeshes { get; set;}

		[Ordinal(5)] [RED("canUseOnDestructionMeshes")] 		public CBool CanUseOnDestructionMeshes { get; set;}

		[Ordinal(6)] [RED("canUseOnApexMeshes")] 		public CBool CanUseOnApexMeshes { get; set;}

		[Ordinal(7)] [RED("canUseOnParticles")] 		public CBool CanUseOnParticles { get; set;}

		[Ordinal(8)] [RED("canUseOnCollapsableObjects")] 		public CBool CanUseOnCollapsableObjects { get; set;}

		[Ordinal(9)] [RED("canUseSkinning")] 		public CBool CanUseSkinning { get; set;}

		[Ordinal(10)] [RED("canUseSkinnedInstancing")] 		public CBool CanUseSkinnedInstancing { get; set;}

		[Ordinal(11)] [RED("canUseOnMorphMeshes")] 		public CBool CanUseOnMorphMeshes { get; set;}

		public IMaterialDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new IMaterialDefinition(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}