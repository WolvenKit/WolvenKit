using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CMorphedMeshComponent : CMeshTypeComponent
	{
		[Ordinal(0)] [RED("morphSource")] 		public CHandle<CMesh> MorphSource { get; set;}

		[Ordinal(0)] [RED("morphTarget")] 		public CHandle<CMesh> MorphTarget { get; set;}

		[Ordinal(0)] [RED("morphControlTextures", 2,0)] 		public CArray<CHandle<CBitmapTexture>> MorphControlTextures { get; set;}

		[Ordinal(0)] [RED("useMorphBlendMaterials", 2,0)] 		public CArray<CBool> UseMorphBlendMaterials { get; set;}

		[Ordinal(0)] [RED("useControlTexturesForMorph")] 		public CBool UseControlTexturesForMorph { get; set;}

		[Ordinal(0)] [RED("morphRatio")] 		public CFloat MorphRatio { get; set;}

		[Ordinal(0)] [RED("morphComponentId")] 		public CName MorphComponentId { get; set;}

		public CMorphedMeshComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CMorphedMeshComponent(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}