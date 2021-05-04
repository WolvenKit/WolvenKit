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
			get => GetProperty(ref _nearAutoHideDistance);
			set => SetProperty(ref _nearAutoHideDistance, value);
		}

		[Ordinal(16)] 
		[RED("ancestorPrefabProxyMeshNodeID")] 
		public worldGlobalNodeID AncestorPrefabProxyMeshNodeID
		{
			get => GetProperty(ref _ancestorPrefabProxyMeshNodeID);
			set => SetProperty(ref _ancestorPrefabProxyMeshNodeID, value);
		}

		[Ordinal(17)] 
		[RED("ownerPrefabNodeId")] 
		public worldGlobalNodeID OwnerPrefabNodeId
		{
			get => GetProperty(ref _ownerPrefabNodeId);
			set => SetProperty(ref _ownerPrefabNodeId, value);
		}

		[Ordinal(18)] 
		[RED("nbNodesUnderProxy")] 
		public CUInt32 NbNodesUnderProxy
		{
			get => GetProperty(ref _nbNodesUnderProxy);
			set => SetProperty(ref _nbNodesUnderProxy, value);
		}

		public worldPrefabProxyMeshNode(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
