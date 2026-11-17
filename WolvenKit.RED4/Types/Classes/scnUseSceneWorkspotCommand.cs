using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class scnUseSceneWorkspotCommand : AIBaseUseWorkspotCommand
	{
		[Ordinal(11)] 
		[RED("sceneInstanceId")] 
		public scnSceneInstanceId SceneInstanceId
		{
			get => GetPropertyValue<scnSceneInstanceId>();
			set => SetPropertyValue<scnSceneInstanceId>(value);
		}

		[Ordinal(12)] 
		[RED("workspotInstanceId")] 
		public scnSceneWorkspotInstanceId WorkspotInstanceId
		{
			get => GetPropertyValue<scnSceneWorkspotInstanceId>();
			set => SetPropertyValue<scnSceneWorkspotInstanceId>(value);
		}

		[Ordinal(13)] 
		[RED("itemOverride")] 
		public workWorkspotItemOverride ItemOverride
		{
			get => GetPropertyValue<workWorkspotItemOverride>();
			set => SetPropertyValue<workWorkspotItemOverride>(value);
		}

		[Ordinal(14)] 
		[RED("nodeId")] 
		public scnNodeId NodeId
		{
			get => GetPropertyValue<scnNodeId>();
			set => SetPropertyValue<scnNodeId>(value);
		}

		public scnUseSceneWorkspotCommand()
		{
			WorkExcludedGestures = new();
			InfiniteSequenceEntryId = new workWorkEntryId();
			SceneInstanceId = new scnSceneInstanceId();
			WorkspotInstanceId = new scnSceneWorkspotInstanceId();
			ItemOverride = new workWorkspotItemOverride();
			NodeId = new scnNodeId();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
