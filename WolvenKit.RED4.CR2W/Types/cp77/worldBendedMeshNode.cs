using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldBendedMeshNode : worldNode
	{
		private raRef<CMesh> _mesh;
		private CName _meshAppearance;
		private CArray<CMatrix> _deformationData;
		private Box _deformedBox;
		private CBool _isBendedRoad;
		private CBool _castShadows;
		private CBool _castLocalShadows;
		private CBool _removeFromRainMap;
		private NavGenNavigationSetting _navigationSetting;

		[Ordinal(4)] 
		[RED("mesh")] 
		public raRef<CMesh> Mesh
		{
			get
			{
				if (_mesh == null)
				{
					_mesh = (raRef<CMesh>) CR2WTypeManager.Create("raRef:CMesh", "mesh", cr2w, this);
				}
				return _mesh;
			}
			set
			{
				if (_mesh == value)
				{
					return;
				}
				_mesh = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("meshAppearance")] 
		public CName MeshAppearance
		{
			get
			{
				if (_meshAppearance == null)
				{
					_meshAppearance = (CName) CR2WTypeManager.Create("CName", "meshAppearance", cr2w, this);
				}
				return _meshAppearance;
			}
			set
			{
				if (_meshAppearance == value)
				{
					return;
				}
				_meshAppearance = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("deformationData")] 
		public CArray<CMatrix> DeformationData
		{
			get
			{
				if (_deformationData == null)
				{
					_deformationData = (CArray<CMatrix>) CR2WTypeManager.Create("array:Matrix", "deformationData", cr2w, this);
				}
				return _deformationData;
			}
			set
			{
				if (_deformationData == value)
				{
					return;
				}
				_deformationData = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("deformedBox")] 
		public Box DeformedBox
		{
			get
			{
				if (_deformedBox == null)
				{
					_deformedBox = (Box) CR2WTypeManager.Create("Box", "deformedBox", cr2w, this);
				}
				return _deformedBox;
			}
			set
			{
				if (_deformedBox == value)
				{
					return;
				}
				_deformedBox = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("isBendedRoad")] 
		public CBool IsBendedRoad
		{
			get
			{
				if (_isBendedRoad == null)
				{
					_isBendedRoad = (CBool) CR2WTypeManager.Create("Bool", "isBendedRoad", cr2w, this);
				}
				return _isBendedRoad;
			}
			set
			{
				if (_isBendedRoad == value)
				{
					return;
				}
				_isBendedRoad = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("castShadows")] 
		public CBool CastShadows
		{
			get
			{
				if (_castShadows == null)
				{
					_castShadows = (CBool) CR2WTypeManager.Create("Bool", "castShadows", cr2w, this);
				}
				return _castShadows;
			}
			set
			{
				if (_castShadows == value)
				{
					return;
				}
				_castShadows = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("castLocalShadows")] 
		public CBool CastLocalShadows
		{
			get
			{
				if (_castLocalShadows == null)
				{
					_castLocalShadows = (CBool) CR2WTypeManager.Create("Bool", "castLocalShadows", cr2w, this);
				}
				return _castLocalShadows;
			}
			set
			{
				if (_castLocalShadows == value)
				{
					return;
				}
				_castLocalShadows = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("removeFromRainMap")] 
		public CBool RemoveFromRainMap
		{
			get
			{
				if (_removeFromRainMap == null)
				{
					_removeFromRainMap = (CBool) CR2WTypeManager.Create("Bool", "removeFromRainMap", cr2w, this);
				}
				return _removeFromRainMap;
			}
			set
			{
				if (_removeFromRainMap == value)
				{
					return;
				}
				_removeFromRainMap = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("navigationSetting")] 
		public NavGenNavigationSetting NavigationSetting
		{
			get
			{
				if (_navigationSetting == null)
				{
					_navigationSetting = (NavGenNavigationSetting) CR2WTypeManager.Create("NavGenNavigationSetting", "navigationSetting", cr2w, this);
				}
				return _navigationSetting;
			}
			set
			{
				if (_navigationSetting == value)
				{
					return;
				}
				_navigationSetting = value;
				PropertySet(this);
			}
		}

		public worldBendedMeshNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
