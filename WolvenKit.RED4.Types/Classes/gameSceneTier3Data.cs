using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameSceneTier3Data : gameSceneTierDataMotionConstrained
	{
		private gameTier3CameraSettings _cameraSettings;

		[Ordinal(3)] 
		[RED("cameraSettings")] 
		public gameTier3CameraSettings CameraSettings
		{
			get => GetProperty(ref _cameraSettings);
			set => SetProperty(ref _cameraSettings, value);
		}
	}
}
