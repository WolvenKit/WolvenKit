using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class PlaySoundDeviceOperation : DeviceOperationBase
	{
		[Ordinal(5)] 
		[RED("SFXs")] 
		public CArray<SSFXOperationData> SFXs
		{
			get => GetPropertyValue<CArray<SSFXOperationData>>();
			set => SetPropertyValue<CArray<SSFXOperationData>>(value);
		}

		public PlaySoundDeviceOperation()
		{
			IsEnabled = true;
			ToggleOperations = new();
			SFXs = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
