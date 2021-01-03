using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class worldProxyTextureParams : CVariable
	{
		[Ordinal(0)]  [RED("albedoTextureResolution")] public CEnum<worldProxyMeshTexRes> AlbedoTextureResolution { get; set; }
		[Ordinal(1)]  [RED("diffuseAlphaAsEmissive")] public CBool DiffuseAlphaAsEmissive { get; set; }
		[Ordinal(2)]  [RED("disableTextureFilter")] public CBool DisableTextureFilter { get; set; }
		[Ordinal(3)]  [RED("exportVertexColor")] public CBool ExportVertexColor { get; set; }
		[Ordinal(4)]  [RED("generateAlbedo")] public CBool GenerateAlbedo { get; set; }
		[Ordinal(5)]  [RED("generateMetalness")] public CBool GenerateMetalness { get; set; }
		[Ordinal(6)]  [RED("generateNormal")] public CBool GenerateNormal { get; set; }
		[Ordinal(7)]  [RED("generateRoughness")] public CBool GenerateRoughness { get; set; }
		[Ordinal(8)]  [RED("metalnessTextureResolution")] public CEnum<worldProxyMeshTexRes> MetalnessTextureResolution { get; set; }
		[Ordinal(9)]  [RED("normalTextureResolution")] public CEnum<worldProxyMeshTexRes> NormalTextureResolution { get; set; }
		[Ordinal(10)]  [RED("roughnessTextureResolution")] public CEnum<worldProxyMeshTexRes> RoughnessTextureResolution { get; set; }

		public worldProxyTextureParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
