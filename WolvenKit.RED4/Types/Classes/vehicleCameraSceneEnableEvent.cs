using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class vehicleCameraSceneEnableEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("scene")] 
		public CBool Scene
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public vehicleCameraSceneEnableEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
