using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnWorkspotInstance : CVariable
	{
		private scnSceneWorkspotInstanceId _workspotInstanceId;
		private scnSceneWorkspotDataId _dataId;
		private Transform _localTransform;
		private CBool _playAtActorLocation;
		private scnMarker _originMarker;

		[Ordinal(0)] 
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

		[Ordinal(1)] 
		[RED("dataId")] 
		public scnSceneWorkspotDataId DataId
		{
			get
			{
				if (_dataId == null)
				{
					_dataId = (scnSceneWorkspotDataId) CR2WTypeManager.Create("scnSceneWorkspotDataId", "dataId", cr2w, this);
				}
				return _dataId;
			}
			set
			{
				if (_dataId == value)
				{
					return;
				}
				_dataId = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("localTransform")] 
		public Transform LocalTransform
		{
			get
			{
				if (_localTransform == null)
				{
					_localTransform = (Transform) CR2WTypeManager.Create("Transform", "localTransform", cr2w, this);
				}
				return _localTransform;
			}
			set
			{
				if (_localTransform == value)
				{
					return;
				}
				_localTransform = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
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

		[Ordinal(4)] 
		[RED("originMarker")] 
		public scnMarker OriginMarker
		{
			get
			{
				if (_originMarker == null)
				{
					_originMarker = (scnMarker) CR2WTypeManager.Create("scnMarker", "originMarker", cr2w, this);
				}
				return _originMarker;
			}
			set
			{
				if (_originMarker == value)
				{
					return;
				}
				_originMarker = value;
				PropertySet(this);
			}
		}

		public scnWorkspotInstance(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
