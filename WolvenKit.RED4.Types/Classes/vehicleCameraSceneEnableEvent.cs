using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class vehicleCameraSceneEnableEvent : redEvent
	{
		private CBool _scene;

		[Ordinal(0)] 
		[RED("scene")] 
		public CBool Scene
		{
			get => GetProperty(ref _scene);
			set => SetProperty(ref _scene, value);
		}
	}
}
