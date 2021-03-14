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
			get
			{
				if (_exportVertexColor == null)
				{
					_exportVertexColor = (CBool) CR2WTypeManager.Create("Bool", "exportVertexColor", cr2w, this);
				}
				return _exportVertexColor;
			}
			set
			{
				if (_exportVertexColor == value)
				{
					return;
				}
				_exportVertexColor = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("albedoTextureResolution")] 
		public CEnum<worldProxyMeshTexRes> AlbedoTextureResolution
		{
			get
			{
				if (_albedoTextureResolution == null)
				{
					_albedoTextureResolution = (CEnum<worldProxyMeshTexRes>) CR2WTypeManager.Create("worldProxyMeshTexRes", "albedoTextureResolution", cr2w, this);
				}
				return _albedoTextureResolution;
			}
			set
			{
				if (_albedoTextureResolution == value)
				{
					return;
				}
				_albedoTextureResolution = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("generateAlbedo")] 
		public CBool GenerateAlbedo
		{
			get
			{
				if (_generateAlbedo == null)
				{
					_generateAlbedo = (CBool) CR2WTypeManager.Create("Bool", "generateAlbedo", cr2w, this);
				}
				return _generateAlbedo;
			}
			set
			{
				if (_generateAlbedo == value)
				{
					return;
				}
				_generateAlbedo = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("normalTextureResolution")] 
		public CEnum<worldProxyMeshTexRes> NormalTextureResolution
		{
			get
			{
				if (_normalTextureResolution == null)
				{
					_normalTextureResolution = (CEnum<worldProxyMeshTexRes>) CR2WTypeManager.Create("worldProxyMeshTexRes", "normalTextureResolution", cr2w, this);
				}
				return _normalTextureResolution;
			}
			set
			{
				if (_normalTextureResolution == value)
				{
					return;
				}
				_normalTextureResolution = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("generateNormal")] 
		public CBool GenerateNormal
		{
			get
			{
				if (_generateNormal == null)
				{
					_generateNormal = (CBool) CR2WTypeManager.Create("Bool", "generateNormal", cr2w, this);
				}
				return _generateNormal;
			}
			set
			{
				if (_generateNormal == value)
				{
					return;
				}
				_generateNormal = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("roughnessTextureResolution")] 
		public CEnum<worldProxyMeshTexRes> RoughnessTextureResolution
		{
			get
			{
				if (_roughnessTextureResolution == null)
				{
					_roughnessTextureResolution = (CEnum<worldProxyMeshTexRes>) CR2WTypeManager.Create("worldProxyMeshTexRes", "roughnessTextureResolution", cr2w, this);
				}
				return _roughnessTextureResolution;
			}
			set
			{
				if (_roughnessTextureResolution == value)
				{
					return;
				}
				_roughnessTextureResolution = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("generateRoughness")] 
		public CBool GenerateRoughness
		{
			get
			{
				if (_generateRoughness == null)
				{
					_generateRoughness = (CBool) CR2WTypeManager.Create("Bool", "generateRoughness", cr2w, this);
				}
				return _generateRoughness;
			}
			set
			{
				if (_generateRoughness == value)
				{
					return;
				}
				_generateRoughness = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("metalnessTextureResolution")] 
		public CEnum<worldProxyMeshTexRes> MetalnessTextureResolution
		{
			get
			{
				if (_metalnessTextureResolution == null)
				{
					_metalnessTextureResolution = (CEnum<worldProxyMeshTexRes>) CR2WTypeManager.Create("worldProxyMeshTexRes", "metalnessTextureResolution", cr2w, this);
				}
				return _metalnessTextureResolution;
			}
			set
			{
				if (_metalnessTextureResolution == value)
				{
					return;
				}
				_metalnessTextureResolution = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("generateMetalness")] 
		public CBool GenerateMetalness
		{
			get
			{
				if (_generateMetalness == null)
				{
					_generateMetalness = (CBool) CR2WTypeManager.Create("Bool", "generateMetalness", cr2w, this);
				}
				return _generateMetalness;
			}
			set
			{
				if (_generateMetalness == value)
				{
					return;
				}
				_generateMetalness = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("disableTextureFilter")] 
		public CBool DisableTextureFilter
		{
			get
			{
				if (_disableTextureFilter == null)
				{
					_disableTextureFilter = (CBool) CR2WTypeManager.Create("Bool", "disableTextureFilter", cr2w, this);
				}
				return _disableTextureFilter;
			}
			set
			{
				if (_disableTextureFilter == value)
				{
					return;
				}
				_disableTextureFilter = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("diffuseAlphaAsEmissive")] 
		public CBool DiffuseAlphaAsEmissive
		{
			get
			{
				if (_diffuseAlphaAsEmissive == null)
				{
					_diffuseAlphaAsEmissive = (CBool) CR2WTypeManager.Create("Bool", "diffuseAlphaAsEmissive", cr2w, this);
				}
				return _diffuseAlphaAsEmissive;
			}
			set
			{
				if (_diffuseAlphaAsEmissive == value)
				{
					return;
				}
				_diffuseAlphaAsEmissive = value;
				PropertySet(this);
			}
		}

		public worldProxyTextureParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
