using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnUseSceneWorkspotParamsV1 : questUseWorkspotParamsV1
	{
		private scnSceneWorkspotInstanceId _workspotInstanceId;
		private CBool _playAtActorLocation;
		private workWorkspotItemOverride _itemOverride;

		[Ordinal(21)] 
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

		[Ordinal(22)] 
		[RED("playAtActorLocation")] 
		public CBool PlayAtActorLocation
		{
			get
			{
				if (_playAtActorLocation == null)
				{
					_playAtActorLocation = (CBool) CR2WTypeManager.Create("Bool", "playAtActorLocation", cr2w, this);
				}
				return _playAtActorLocation;
			}
			set
			{
				if (_playAtActorLocation == value)
				{
					return;
				}
				_playAtActorLocation = value;
				PropertySet(this);
			}
		}

		[Ordinal(23)] 
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

		public scnUseSceneWorkspotParamsV1(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
