using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entSkinnedClothComponent : entISkinTargetComponent
	{
		private raRef<CMesh> _graphicsMesh;
		private raRef<CMesh> _physicalMesh;
		private CBool _isEnabled;
		private CEnum<entMeshComponentLODMode> _lODMode;
		private CName _meshAppearance;
		private CUInt64 _chunkMask;
		private meshCookedClothMeshTopologyData _compiledTopologyData;

		[Ordinal(10)] 
		[RED("graphicsMesh")] 
		public raRef<CMesh> GraphicsMesh
		{
			get
			{
				if (_graphicsMesh == null)
				{
					_graphicsMesh = (raRef<CMesh>) CR2WTypeManager.Create("raRef:CMesh", "graphicsMesh", cr2w, this);
				}
				return _graphicsMesh;
			}
			set
			{
				if (_graphicsMesh == value)
				{
					return;
				}
				_graphicsMesh = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("physicalMesh")] 
		public raRef<CMesh> PhysicalMesh
		{
			get
			{
				if (_physicalMesh == null)
				{
					_physicalMesh = (raRef<CMesh>) CR2WTypeManager.Create("raRef:CMesh", "physicalMesh", cr2w, this);
				}
				return _physicalMesh;
			}
			set
			{
				if (_physicalMesh == value)
				{
					return;
				}
				_physicalMesh = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("isEnabled")] 
		public CBool IsEnabled
		{
			get
			{
				if (_isEnabled == null)
				{
					_isEnabled = (CBool) CR2WTypeManager.Create("Bool", "isEnabled", cr2w, this);
				}
				return _isEnabled;
			}
			set
			{
				if (_isEnabled == value)
				{
					return;
				}
				_isEnabled = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("LODMode")] 
		public CEnum<entMeshComponentLODMode> LODMode
		{
			get
			{
				if (_lODMode == null)
				{
					_lODMode = (CEnum<entMeshComponentLODMode>) CR2WTypeManager.Create("entMeshComponentLODMode", "LODMode", cr2w, this);
				}
				return _lODMode;
			}
			set
			{
				if (_lODMode == value)
				{
					return;
				}
				_lODMode = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
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

		[Ordinal(15)] 
		[RED("chunkMask")] 
		public CUInt64 ChunkMask
		{
			get
			{
				if (_chunkMask == null)
				{
					_chunkMask = (CUInt64) CR2WTypeManager.Create("Uint64", "chunkMask", cr2w, this);
				}
				return _chunkMask;
			}
			set
			{
				if (_chunkMask == value)
				{
					return;
				}
				_chunkMask = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("compiledTopologyData")] 
		public meshCookedClothMeshTopologyData CompiledTopologyData
		{
			get
			{
				if (_compiledTopologyData == null)
				{
					_compiledTopologyData = (meshCookedClothMeshTopologyData) CR2WTypeManager.Create("meshCookedClothMeshTopologyData", "compiledTopologyData", cr2w, this);
				}
				return _compiledTopologyData;
			}
			set
			{
				if (_compiledTopologyData == value)
				{
					return;
				}
				_compiledTopologyData = value;
				PropertySet(this);
			}
		}

		public entSkinnedClothComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
