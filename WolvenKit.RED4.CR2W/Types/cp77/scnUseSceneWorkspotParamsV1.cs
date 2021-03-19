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

		public scnUseSceneWorkspotParamsV1(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
