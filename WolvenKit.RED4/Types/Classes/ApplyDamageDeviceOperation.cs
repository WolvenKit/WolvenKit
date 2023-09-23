using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ApplyDamageDeviceOperation : DeviceOperationBase
	{
		[Ordinal(5)] 
		[RED("damages")] 
		public CArray<SDamageOperationData> Damages
		{
			get => GetPropertyValue<CArray<SDamageOperationData>>();
			set => SetPropertyValue<CArray<SDamageOperationData>>(value);
		}

		public ApplyDamageDeviceOperation()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
