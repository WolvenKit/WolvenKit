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
			InfiniteSequenceEntryId = new() { Id = 4294967295 };
			SceneInstanceId = new() { SceneId = new(), OwnerId = new(), InternalId = 255, Hash = 6242570315725555409 };
			WorkspotInstanceId = new() { Id = 4294967295 };
			ItemOverride = new() { PropOverrides = new(), ItemOverrides = new() };
			NodeId = new() { Id = 4294967295 };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
