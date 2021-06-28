using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldEntityProxyMeshNode : worldPrefabProxyMeshNode
	{
		private worldGlobalNodeID _ownerGlobalId;
		private CFloat _entityAttachDistance;

		[Ordinal(19)] 
		[RED("ownerGlobalId")] 
		public worldGlobalNodeID OwnerGlobalId
		{
			get => GetProperty(ref _ownerGlobalId);
			set => SetProperty(ref _ownerGlobalId, value);
		}

		[Ordinal(20)] 
		[RED("entityAttachDistance")] 
		public CFloat EntityAttachDistance
		{
			get => GetProperty(ref _entityAttachDistance);
			set => SetProperty(ref _entityAttachDistance, value);
		}

		public worldEntityProxyMeshNode(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
