using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class scnWorkspotInstance : RedBaseClass
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
	}
}
