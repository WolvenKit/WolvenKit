using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta()]
	public class SDynamicDecalMaterialInfo : CVariable
	{
		[RED("diffuseTexture")] 		public CHandle<CBitmapTexture> DiffuseTexture { get; set;}

		[RED("diffuseRandomColor0")] 		public CColor DiffuseRandomColor0 { get; set;}

		[RED("diffuseRandomColor1")] 		public CColor DiffuseRandomColor1 { get; set;}

		[RED("subUVType")] 		public CEnum<ERenderDynamicDecalAtlas> SubUVType { get; set;}

		[RED("normalTexture")] 		public CHandle<CBitmapTexture> NormalTexture { get; set;}

		[RED("additiveNormals")] 		public CBool AdditiveNormals { get; set;}

		[RED("specularColor")] 		public CColor SpecularColor { get; set;}

		[RED("specularScale")] 		public CFloat SpecularScale { get; set;}

		[RED("specularBase")] 		public CFloat SpecularBase { get; set;}

		[RED("specularity")] 		public CFloat Specularity { get; set;}

		public SDynamicDecalMaterialInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SDynamicDecalMaterialInfo(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}