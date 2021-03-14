using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnUseSceneWorkspotCommand : AIBaseUseWorkspotCommand
	{
		private scnSceneInstanceId _sceneInstanceId;
		private scnSceneWorkspotInstanceId _workspotInstanceId;
		private workWorkspotItemOverride _itemOverride;
		private scnNodeId _nodeId;

		[Ordinal(11)] 
		[RED("sceneInstanceId")] 
		public scnSceneInstanceId SceneInstanceId
		{
			get
			{
				if (_sceneInstanceId == null)
				{
					_sceneInstanceId = (scnSceneInstanceId) CR2WTypeManager.Create("scnSceneInstanceId", "sceneInstanceId", cr2w, this);
				}
				return _sceneInstanceId;
			}
			set
			{
				if (_sceneInstanceId == value)
				{
					return;
				}
				_sceneInstanceId = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("workspotInstanceId")] 
		public scnSceneWorkspotInstanceId WorkspotInstanceId
		{
			get
			{
				if (_workspotInstanceId == null)
				{
					_workspotInstanceId = (scnSceneWorkspotInstanceId) CR2WTypeManager.Create("scnSceneWorkspotInstanceId", "workspotInstanceId", cr2w, this);
				}
				return _workspotInstanceId;
			}
			set
			{
				if (_workspotInstanceId == value)
				{
					return;
				}
				_workspotInstanceId = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("itemOverride")] 
		public workWorkspotItemOverride ItemOverride
		{
			get
			{
				if (_itemOverride == null)
				{
					_itemOverride = (workWorkspotItemOverride) CR2WTypeManager.Create("workWorkspotItemOverride", "itemOverride", cr2w, this);
				}
				return _itemOverride;
			}
			set
			{
				if (_itemOverride == value)
				{
					return;
				}
				_itemOverride = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("nodeId")] 
		public scnNodeId NodeId
		{
			get
			{
				if (_nodeId == null)
				{
					_nodeId = (scnNodeId) CR2WTypeManager.Create("scnNodeId", "nodeId", cr2w, this);
				}
				return _nodeId;
			}
			set
			{
				if (_nodeId == value)
				{
					return;
				}
				_nodeId = value;
				PropertySet(this);
			}
		}

		public scnUseSceneWorkspotCommand(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
