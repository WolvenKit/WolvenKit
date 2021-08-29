using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class scnUseSceneWorkspotParamsV1 : questUseWorkspotParamsV1
	{
		private scnSceneWorkspotInstanceId _workspotInstanceId;
		private CBool _playAtActorLocation;
		private workWorkspotItemOverride _itemOverride;

		[Ordinal(21)] 
		[RED("workspotInstanceId")] 
		public scnSceneWorkspotInstanceId WorkspotInstanceId
		{
			get => GetProperty(ref _workspotInstanceId);
			set => SetProperty(ref _workspotInstanceId, value);
		}

		[Ordinal(22)] 
		[RED("playAtActorLocation")] 
		public CBool PlayAtActorLocation
		{
			get => GetProperty(ref _playAtActorLocation);
			set => SetProperty(ref _playAtActorLocation, value);
		}

		[Ordinal(23)] 
		[RED("itemOverride")] 
		public workWorkspotItemOverride ItemOverride
		{
			get => GetProperty(ref _itemOverride);
			set => SetProperty(ref _itemOverride, value);
		}
	}
}
