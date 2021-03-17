using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldProxyTextureParams : CVariable
	{
		private CBool _exportVertexColor;
		private CEnum<worldProxyMeshTexRes> _albedoTextureResolution;
		private CBool _generateAlbedo;
		private CEnum<worldProxyMeshTexRes> _normalTextureResolution;
		private CBool _generateNormal;
		private CEnum<worldProxyMeshTexRes> _roughnessTextureResolution;
		private CBool _generateRoughness;
		private CEnum<worldProxyMeshTexRes> _metalnessTextureResolution;
		private CBool _generateMetalness;
		private CBool _disableTextureFilter;
		private CBool _diffuseAlphaAsEmissive;

		[Ordinal(0)] 
		[RED("exportVertexColor")] 
		public CBool ExportVertexColor
		{
			get => GetProperty(ref _exportVertexColor);
			set => SetProperty(ref _exportVertexColor, value);
		}

		[Ordinal(1)] 
		[RED("albedoTextureResolution")] 
		public CEnum<worldProxyMeshTexRes> AlbedoTextureResolution
		{
			get => GetProperty(ref _albedoTextureResolution);
			set => SetProperty(ref _albedoTextureResolution, value);
		}

		[Ordinal(2)] 
		[RED("generateAlbedo")] 
		public CBool GenerateAlbedo
		{
			get => GetProperty(ref _generateAlbedo);
			set => SetProperty(ref _generateAlbedo, value);
		}

		[Ordinal(3)] 
		[RED("normalTextureResolution")] 
		public CEnum<worldProxyMeshTexRes> NormalTextureResolution
		{
			get => GetProperty(ref _normalTextureResolution);
			set => SetProperty(ref _normalTextureResolution, value);
		}

		[Ordinal(4)] 
		[RED("generateNormal")] 
		public CBool GenerateNormal
		{
			get => GetProperty(ref _generateNormal);
			set => SetProperty(ref _generateNormal, value);
		}

		[Ordinal(5)] 
		[RED("roughnessTextureResolution")] 
		public CEnum<worldProxyMeshTexRes> RoughnessTextureResolution
		{
			get => GetProperty(ref _roughnessTextureResolution);
			set => SetProperty(ref _roughnessTextureResolution, value);
		}

		[Ordinal(6)] 
		[RED("generateRoughness")] 
		public CBool GenerateRoughness
		{
			get => GetProperty(ref _generateRoughness);
			set => SetProperty(ref _generateRoughness, value);
		}

		[Ordinal(7)] 
		[RED("metalnessTextureResolution")] 
		public CEnum<worldProxyMeshTexRes> MetalnessTextureResolution
		{
			get => GetProperty(ref _metalnessTextureResolution);
			set => SetProperty(ref _metalnessTextureResolution, value);
		}

		[Ordinal(8)] 
		[RED("generateMetalness")] 
		public CBool GenerateMetalness
		{
			get => GetProperty(ref _generateMetalness);
			set => SetProperty(ref _generateMetalness, value);
		}

		[Ordinal(9)] 
		[RED("disableTextureFilter")] 
		public CBool DisableTextureFilter
		{
			get => GetProperty(ref _disableTextureFilter);
			set => SetProperty(ref _disableTextureFilter, value);
		}

		[Ordinal(10)] 
		[RED("diffuseAlphaAsEmissive")] 
		public CBool DiffuseAlphaAsEmissive
		{
			get => GetProperty(ref _diffuseAlphaAsEmissive);
			set => SetProperty(ref _diffuseAlphaAsEmissive, value);
		}

		public worldProxyTextureParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
