using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class StimDeviceOperation : DeviceOperationBase
	{
		[Ordinal(5)] 
		[RED("stims")] 
		public CArray<SStimOperationData> Stims
		{
			get => GetPropertyValue<CArray<SStimOperationData>>();
			set => SetPropertyValue<CArray<SStimOperationData>>(value);
		}

		public StimDeviceOperation()
		{
			IsEnabled = true;
			ToggleOperations = new();
			Stims = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
