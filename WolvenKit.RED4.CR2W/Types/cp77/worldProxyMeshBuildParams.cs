using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldProxyMeshBuildParams : CVariable
	{
		private CBool _buildProxy;
		private CEnum<worldProxyMeshBuildType> _type;
		private CEnum<worldProxyMeshOutputType> _usedMesh;
		private CUInt32 _resolution;
		private CUInt32 _polycount;
		private CFloat _polycountPercentage;
		private CEnum<worldProxyCoreAxis> _coreAxis;
		private CEnum<worldProxyGroupingNormals> _groupingNormals;
		private CBool _forceSurfaceFlattening;
		private CBool _forceSeamlessModule;
		private CBool _enableAlphaMask;
		private worldProxyWindowsParams _windows;
		private worldProxyTextureParams _textures;
		private worldProxyCustomGeometryParams _customGeometry;
		private worldProxyMeshAdvancedBuildParams _advancedParams;

		[Ordinal(0)] 
		[RED("buildProxy")] 
		public CBool BuildProxy
		{
			get
			{
				if (_buildProxy == null)
				{
					_buildProxy = (CBool) CR2WTypeManager.Create("Bool", "buildProxy", cr2w, this);
				}
				return _buildProxy;
			}
			set
			{
				if (_buildProxy == value)
				{
					return;
				}
				_buildProxy = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("type")] 
		public CEnum<worldProxyMeshBuildType> Type
		{
			get
			{
				if (_type == null)
				{
					_type = (CEnum<worldProxyMeshBuildType>) CR2WTypeManager.Create("worldProxyMeshBuildType", "type", cr2w, this);
				}
				return _type;
			}
			set
			{
				if (_type == value)
				{
					return;
				}
				_type = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("usedMesh")] 
		public CEnum<worldProxyMeshOutputType> UsedMesh
		{
			get
			{
				if (_usedMesh == null)
				{
					_usedMesh = (CEnum<worldProxyMeshOutputType>) CR2WTypeManager.Create("worldProxyMeshOutputType", "usedMesh", cr2w, this);
				}
				return _usedMesh;
			}
			set
			{
				if (_usedMesh == value)
				{
					return;
				}
				_usedMesh = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("resolution")] 
		public CUInt32 Resolution
		{
			get
			{
				if (_resolution == null)
				{
					_resolution = (CUInt32) CR2WTypeManager.Create("Uint32", "resolution", cr2w, this);
				}
				return _resolution;
			}
			set
			{
				if (_resolution == value)
				{
					return;
				}
				_resolution = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("polycount")] 
		public CUInt32 Polycount
		{
			get
			{
				if (_polycount == null)
				{
					_polycount = (CUInt32) CR2WTypeManager.Create("Uint32", "polycount", cr2w, this);
				}
				return _polycount;
			}
			set
			{
				if (_polycount == value)
				{
					return;
				}
				_polycount = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("polycountPercentage")] 
		public CFloat PolycountPercentage
		{
			get
			{
				if (_polycountPercentage == null)
				{
					_polycountPercentage = (CFloat) CR2WTypeManager.Create("Float", "polycountPercentage", cr2w, this);
				}
				return _polycountPercentage;
			}
			set
			{
				if (_polycountPercentage == value)
				{
					return;
				}
				_polycountPercentage = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("coreAxis")] 
		public CEnum<worldProxyCoreAxis> CoreAxis
		{
			get
			{
				if (_coreAxis == null)
				{
					_coreAxis = (CEnum<worldProxyCoreAxis>) CR2WTypeManager.Create("worldProxyCoreAxis", "coreAxis", cr2w, this);
				}
				return _coreAxis;
			}
			set
			{
				if (_coreAxis == value)
				{
					return;
				}
				_coreAxis = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("groupingNormals")] 
		public CEnum<worldProxyGroupingNormals> GroupingNormals
		{
			get
			{
				if (_groupingNormals == null)
				{
					_groupingNormals = (CEnum<worldProxyGroupingNormals>) CR2WTypeManager.Create("worldProxyGroupingNormals", "groupingNormals", cr2w, this);
				}
				return _groupingNormals;
			}
			set
			{
				if (_groupingNormals == value)
				{
					return;
				}
				_groupingNormals = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("forceSurfaceFlattening")] 
		public CBool ForceSurfaceFlattening
		{
			get
			{
				if (_forceSurfaceFlattening == null)
				{
					_forceSurfaceFlattening = (CBool) CR2WTypeManager.Create("Bool", "forceSurfaceFlattening", cr2w, this);
				}
				return _forceSurfaceFlattening;
			}
			set
			{
				if (_forceSurfaceFlattening == value)
				{
					return;
				}
				_forceSurfaceFlattening = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("forceSeamlessModule")] 
		public CBool ForceSeamlessModule
		{
			get
			{
				if (_forceSeamlessModule == null)
				{
					_forceSeamlessModule = (CBool) CR2WTypeManager.Create("Bool", "forceSeamlessModule", cr2w, this);
				}
				return _forceSeamlessModule;
			}
			set
			{
				if (_forceSeamlessModule == value)
				{
					return;
				}
				_forceSeamlessModule = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("enableAlphaMask")] 
		public CBool EnableAlphaMask
		{
			get
			{
				if (_enableAlphaMask == null)
				{
					_enableAlphaMask = (CBool) CR2WTypeManager.Create("Bool", "enableAlphaMask", cr2w, this);
				}
				return _enableAlphaMask;
			}
			set
			{
				if (_enableAlphaMask == value)
				{
					return;
				}
				_enableAlphaMask = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("windows")] 
		public worldProxyWindowsParams Windows
		{
			get
			{
				if (_windows == null)
				{
					_windows = (worldProxyWindowsParams) CR2WTypeManager.Create("worldProxyWindowsParams", "windows", cr2w, this);
				}
				return _windows;
			}
			set
			{
				if (_windows == value)
				{
					return;
				}
				_windows = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("textures")] 
		public worldProxyTextureParams Textures
		{
			get
			{
				if (_textures == null)
				{
					_textures = (worldProxyTextureParams) CR2WTypeManager.Create("worldProxyTextureParams", "textures", cr2w, this);
				}
				return _textures;
			}
			set
			{
				if (_textures == value)
				{
					return;
				}
				_textures = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("customGeometry")] 
		public worldProxyCustomGeometryParams CustomGeometry
		{
			get
			{
				if (_customGeometry == null)
				{
					_customGeometry = (worldProxyCustomGeometryParams) CR2WTypeManager.Create("worldProxyCustomGeometryParams", "customGeometry", cr2w, this);
				}
				return _customGeometry;
			}
			set
			{
				if (_customGeometry == value)
				{
					return;
				}
				_customGeometry = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("advancedParams")] 
		public worldProxyMeshAdvancedBuildParams AdvancedParams
		{
			get
			{
				if (_advancedParams == null)
				{
					_advancedParams = (worldProxyMeshAdvancedBuildParams) CR2WTypeManager.Create("worldProxyMeshAdvancedBuildParams", "advancedParams", cr2w, this);
				}
				return _advancedParams;
			}
			set
			{
				if (_advancedParams == value)
				{
					return;
				}
				_advancedParams = value;
				PropertySet(this);
			}
		}

		public worldProxyMeshBuildParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
