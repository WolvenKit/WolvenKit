using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class scnUseSceneWorkspotParamsV1 : questUseWorkspotParamsV1
	{
		[Ordinal(22)] 
		[RED("workspotInstanceId")] 
		public scnSceneWorkspotInstanceId WorkspotInstanceId
		{
			get => GetPropertyValue<scnSceneWorkspotInstanceId>();
			set => SetPropertyValue<scnSceneWorkspotInstanceId>(value);
		}

		[Ordinal(23)] 
		[RED("playAtActorLocation")] 
		public CBool PlayAtActorLocation
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(24)] 
		[RED("itemOverride")] 
		public workWorkspotItemOverride ItemOverride
		{
			get => GetPropertyValue<workWorkspotItemOverride>();
			set => SetPropertyValue<workWorkspotItemOverride>(value);
		}

		public scnUseSceneWorkspotParamsV1()
		{
			WorkspotInstanceId = new() { Id = 4294967295 };
			ItemOverride = new() { PropOverrides = new(), ItemOverrides = new() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
