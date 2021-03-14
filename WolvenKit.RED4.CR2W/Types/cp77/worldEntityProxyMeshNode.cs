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
			get
			{
				if (_ownerGlobalId == null)
				{
					_ownerGlobalId = (worldGlobalNodeID) CR2WTypeManager.Create("worldGlobalNodeID", "ownerGlobalId", cr2w, this);
				}
				return _ownerGlobalId;
			}
			set
			{
				if (_ownerGlobalId == value)
				{
					return;
				}
				_ownerGlobalId = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
		[RED("entityAttachDistance")] 
		public CFloat EntityAttachDistance
		{
			get
			{
				if (_entityAttachDistance == null)
				{
					_entityAttachDistance = (CFloat) CR2WTypeManager.Create("Float", "entityAttachDistance", cr2w, this);
				}
				return _entityAttachDistance;
			}
			set
			{
				if (_entityAttachDistance == value)
				{
					return;
				}
				_entityAttachDistance = value;
				PropertySet(this);
			}
		}

		public worldEntityProxyMeshNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
