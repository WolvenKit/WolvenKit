using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldProxyTextureParams : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("exportVertexColor")] 
		public CBool ExportVertexColor
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("albedoTextureResolution")] 
		public CEnum<worldProxyMeshTexRes> AlbedoTextureResolution
		{
			get => GetPropertyValue<CEnum<worldProxyMeshTexRes>>();
			set => SetPropertyValue<CEnum<worldProxyMeshTexRes>>(value);
		}

		[Ordinal(2)] 
		[RED("generateAlbedo")] 
		public CBool GenerateAlbedo
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("normalTextureResolution")] 
		public CEnum<worldProxyMeshTexRes> NormalTextureResolution
		{
			get => GetPropertyValue<CEnum<worldProxyMeshTexRes>>();
			set => SetPropertyValue<CEnum<worldProxyMeshTexRes>>(value);
		}

		[Ordinal(4)] 
		[RED("generateNormal")] 
		public CBool GenerateNormal
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(5)] 
		[RED("roughnessTextureResolution")] 
		public CEnum<worldProxyMeshTexRes> RoughnessTextureResolution
		{
			get => GetPropertyValue<CEnum<worldProxyMeshTexRes>>();
			set => SetPropertyValue<CEnum<worldProxyMeshTexRes>>(value);
		}

		[Ordinal(6)] 
		[RED("generateRoughness")] 
		public CBool GenerateRoughness
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(7)] 
		[RED("metalnessTextureResolution")] 
		public CEnum<worldProxyMeshTexRes> MetalnessTextureResolution
		{
			get => GetPropertyValue<CEnum<worldProxyMeshTexRes>>();
			set => SetPropertyValue<CEnum<worldProxyMeshTexRes>>(value);
		}

		[Ordinal(8)] 
		[RED("generateMetalness")] 
		public CBool GenerateMetalness
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(9)] 
		[RED("disableTextureFilter")] 
		public CBool DisableTextureFilter
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(10)] 
		[RED("diffuseAlphaAsEmissive")] 
		public CBool DiffuseAlphaAsEmissive
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public worldProxyTextureParams()
		{
			AlbedoTextureResolution = Enums.worldProxyMeshTexRes.RES_256;
			GenerateAlbedo = true;
			NormalTextureResolution = Enums.worldProxyMeshTexRes.RES_128;
			RoughnessTextureResolution = Enums.worldProxyMeshTexRes.RES_128;
			GenerateRoughness = true;
			MetalnessTextureResolution = Enums.worldProxyMeshTexRes.RES_128;
			DiffuseAlphaAsEmissive = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
