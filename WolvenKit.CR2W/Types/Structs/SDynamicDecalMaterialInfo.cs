using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[REDMeta(EREDMetaInfo.REDStruct)]
	public class SDynamicDecalMaterialInfo : CVariable
	{
		[RED("diffuseTexture")] public CHandle<CBitmapTexture> DiffuseTexture { get; set; }

		[RED("diffuseRandomColor0")] public CColor DiffuseRandomColor0 { get; set; }

		[RED("diffuseRandomColor1")] public CColor DiffuseRandomColor1 { get; set; }

		[RED("subUVType")] public ERenderDynamicDecalAtlas SubUVType { get; set; }

		[RED("normalTexture")] public CHandle<CBitmapTexture> NormalTexture { get; set; }

		[RED("additiveNormals")] public CBool AdditiveNormals { get; set; }

		[RED("specularColor")] public CColor SpecularColor { get; set; }

		[RED("specularScale")] public CFloat SpecularScale { get; set; }

		[RED("specularBase")] public CFloat SpecularBase { get; set; }

		[RED("specularity")] public CFloat Specularity { get; set; }

		public SDynamicDecalMaterialInfo(CR2WFile cr2w) : base(cr2w) { }



		public override CVariable Create(CR2WFile cr2w) => new SDynamicDecalMaterialInfo(cr2w);

	}
}