using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gamePhotoModeBackgroundViewComponent : entIComponent
	{
		[Ordinal(3)] 
		[RED("backgroundPrefabRef")] 
		public NodeRef BackgroundPrefabRef
		{
			get => GetPropertyValue<NodeRef>();
			set => SetPropertyValue<NodeRef>(value);
		}

		[Ordinal(4)] 
		[RED("targetPointRef")] 
		public NodeRef TargetPointRef
		{
			get => GetPropertyValue<NodeRef>();
			set => SetPropertyValue<NodeRef>(value);
		}

		public gamePhotoModeBackgroundViewComponent()
		{
			Name = "Component";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
