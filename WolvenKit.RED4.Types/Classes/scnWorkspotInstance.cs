using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class scnWorkspotInstance : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("workspotInstanceId")] 
		public scnSceneWorkspotInstanceId WorkspotInstanceId
		{
			get => GetPropertyValue<scnSceneWorkspotInstanceId>();
			set => SetPropertyValue<scnSceneWorkspotInstanceId>(value);
		}

		[Ordinal(1)] 
		[RED("dataId")] 
		public scnSceneWorkspotDataId DataId
		{
			get => GetPropertyValue<scnSceneWorkspotDataId>();
			set => SetPropertyValue<scnSceneWorkspotDataId>(value);
		}

		[Ordinal(2)] 
		[RED("localTransform")] 
		public Transform LocalTransform
		{
			get => GetPropertyValue<Transform>();
			set => SetPropertyValue<Transform>(value);
		}

		[Ordinal(3)] 
		[RED("playAtActorLocation")] 
		public CBool PlayAtActorLocation
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(4)] 
		[RED("originMarker")] 
		public scnMarker OriginMarker
		{
			get => GetPropertyValue<scnMarker>();
			set => SetPropertyValue<scnMarker>(value);
		}

		public scnWorkspotInstance()
		{
			WorkspotInstanceId = new() { Id = 4294967295 };
			DataId = new() { Id = 4294967295 };
			LocalTransform = new() { Position = new(), Orientation = new() { R = 1.000000F } };
			OriginMarker = new() { Type = Enums.scnMarkerType.Global, EntityRef = new() { Names = new() }, IsMounted = true };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
