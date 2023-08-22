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
			InfiniteSequenceEntryId = new workWorkEntryId { Id = uint.MaxValue };
			SceneInstanceId = new scnSceneInstanceId { SceneId = new scnSceneId(), OwnerId = new scnSceneInstanceOwnerId(), InternalId = 255, Hash = 6242570315725555409 };
			WorkspotInstanceId = new scnSceneWorkspotInstanceId { Id = uint.MaxValue };
			ItemOverride = new workWorkspotItemOverride { PropOverrides = new(), ItemOverrides = new() };
			NodeId = new scnNodeId { Id = uint.MaxValue };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
