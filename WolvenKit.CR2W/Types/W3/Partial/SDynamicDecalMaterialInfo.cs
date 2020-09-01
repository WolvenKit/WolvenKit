using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta()]
	public class SDynamicDecalMaterialInfo : CVariable
	{
		[Ordinal(0)] [RED("diffuseTexture")] 		public CHandle<CBitmapTexture> DiffuseTexture { get; set;}

		[Ordinal(0)] [RED("diffuseRandomColor0")] 		public CColor DiffuseRandomColor0 { get; set;}

		[Ordinal(0)] [RED("diffuseRandomColor1")] 		public CColor DiffuseRandomColor1 { get; set;}

		[Ordinal(0)] [RED("subUVType")] 		public CEnum<ERenderDynamicDecalAtlas> SubUVType { get; set;}

		[Ordinal(0)] [RED("normalTexture")] 		public CHandle<CBitmapTexture> NormalTexture { get; set;}

		[Ordinal(0)] [RED("additiveNormals")] 		public CBool AdditiveNormals { get; set;}

		[Ordinal(0)] [RED("specularColor")] 		public CColor SpecularColor { get; set;}

		[Ordinal(0)] [RED("specularScale")] 		public CFloat SpecularScale { get; set;}

		[Ordinal(0)] [RED("specularBase")] 		public CFloat SpecularBase { get; set;}

		[Ordinal(0)] [RED("specularity")] 		public CFloat Specularity { get; set;}

		public SDynamicDecalMaterialInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SDynamicDecalMaterialInfo(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}