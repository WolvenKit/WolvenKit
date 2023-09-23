using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CameraDeadBodySessionDataModule : GameSessionDataModule
	{
		[Ordinal(1)] 
		[RED("cameraDeadBodyData")] 
		public CArray<CHandle<CameraDeadBodyInternalData>> CameraDeadBodyData
		{
			get => GetPropertyValue<CArray<CHandle<CameraDeadBodyInternalData>>>();
			set => SetPropertyValue<CArray<CHandle<CameraDeadBodyInternalData>>>(value);
		}

		public CameraDeadBodySessionDataModule()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
