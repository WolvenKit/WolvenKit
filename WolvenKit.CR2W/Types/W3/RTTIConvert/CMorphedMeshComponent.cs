using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CMorphedMeshComponent : CMeshTypeComponent
	{
		[RED("morphSource")] 		public CHandle<CMesh> MorphSource { get; set;}

		[RED("morphTarget")] 		public CHandle<CMesh> MorphTarget { get; set;}

		[RED("morphControlTextures", 2,0)] 		public CArray<CHandle<CBitmapTexture>> MorphControlTextures { get; set;}

		[RED("useMorphBlendMaterials", 2,0)] 		public CArray<CBool> UseMorphBlendMaterials { get; set;}

		[RED("useControlTexturesForMorph")] 		public CBool UseControlTexturesForMorph { get; set;}

		[RED("morphRatio")] 		public CFloat MorphRatio { get; set;}

		[RED("morphComponentId")] 		public CName MorphComponentId { get; set;}

		public CMorphedMeshComponent(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CMorphedMeshComponent(cr2w);

	}
}