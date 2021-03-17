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
			get => GetProperty(ref _workspotInstanceId);
			set => SetProperty(ref _workspotInstanceId, value);
		}

		[Ordinal(1)] 
		[RED("dataId")] 
		public scnSceneWorkspotDataId DataId
		{
			get => GetProperty(ref _dataId);
			set => SetProperty(ref _dataId, value);
		}

		[Ordinal(2)] 
		[RED("localTransform")] 
		public Transform LocalTransform
		{
			get => GetProperty(ref _localTransform);
			set => SetProperty(ref _localTransform, value);
		}

		[Ordinal(3)] 
		[RED("playAtActorLocation")] 
		public CBool PlayAtActorLocation
		{
			get => GetProperty(ref _playAtActorLocation);
			set => SetProperty(ref _playAtActorLocation, value);
		}

		[Ordinal(4)] 
		[RED("originMarker")] 
		public scnMarker OriginMarker
		{
			get => GetProperty(ref _originMarker);
			set => SetProperty(ref _originMarker, value);
		}

		public scnWorkspotInstance(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
