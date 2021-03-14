using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldPrefabProxyMeshNode : worldMeshNode
	{
		private CFloat _nearAutoHideDistance;
		private worldGlobalNodeID _ancestorPrefabProxyMeshNodeID;
		private worldGlobalNodeID _ownerPrefabNodeId;
		private CUInt32 _nbNodesUnderProxy;

		[Ordinal(15)] 
		[RED("nearAutoHideDistance")] 
		public CFloat NearAutoHideDistance
		{
			get
			{
				if (_nearAutoHideDistance == null)
				{
					_nearAutoHideDistance = (CFloat) CR2WTypeManager.Create("Float", "nearAutoHideDistance", cr2w, this);
				}
				return _nearAutoHideDistance;
			}
			set
			{
				if (_nearAutoHideDistance == value)
				{
					return;
				}
				_nearAutoHideDistance = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("ancestorPrefabProxyMeshNodeID")] 
		public worldGlobalNodeID AncestorPrefabProxyMeshNodeID
		{
			get
			{
				if (_ancestorPrefabProxyMeshNodeID == null)
				{
					_ancestorPrefabProxyMeshNodeID = (worldGlobalNodeID) CR2WTypeManager.Create("worldGlobalNodeID", "ancestorPrefabProxyMeshNodeID", cr2w, this);
				}
				return _ancestorPrefabProxyMeshNodeID;
			}
			set
			{
				if (_ancestorPrefabProxyMeshNodeID == value)
				{
					return;
				}
				_ancestorPrefabProxyMeshNodeID = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("ownerPrefabNodeId")] 
		public worldGlobalNodeID OwnerPrefabNodeId
		{
			get
			{
				if (_ownerPrefabNodeId == null)
				{
					_ownerPrefabNodeId = (worldGlobalNodeID) CR2WTypeManager.Create("worldGlobalNodeID", "ownerPrefabNodeId", cr2w, this);
				}
				return _ownerPrefabNodeId;
			}
			set
			{
				if (_ownerPrefabNodeId == value)
				{
					return;
				}
				_ownerPrefabNodeId = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("nbNodesUnderProxy")] 
		public CUInt32 NbNodesUnderProxy
		{
			get
			{
				if (_nbNodesUnderProxy == null)
				{
					_nbNodesUnderProxy = (CUInt32) CR2WTypeManager.Create("Uint32", "nbNodesUnderProxy", cr2w, this);
				}
				return _nbNodesUnderProxy;
			}
			set
			{
				if (_nbNodesUnderProxy == value)
				{
					return;
				}
				_nbNodesUnderProxy = value;
				PropertySet(this);
			}
		}

		public worldPrefabProxyMeshNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
