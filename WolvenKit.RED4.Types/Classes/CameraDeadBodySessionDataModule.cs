using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CameraDeadBodySessionDataModule : GameSessionDataModule
	{
		private CArray<CHandle<CameraDeadBodyInternalData>> _cameraDeadBodyData;

		[Ordinal(1)] 
		[RED("cameraDeadBodyData")] 
		public CArray<CHandle<CameraDeadBodyInternalData>> CameraDeadBodyData
		{
			get => GetProperty(ref _cameraDeadBodyData);
			set => SetProperty(ref _cameraDeadBodyData, value);
		}
	}
}
