using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class scnRidSerialNumber : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("serialNumber")] 
		public CUInt32 SerialNumber
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		public scnRidSerialNumber()
		{
			SerialNumber = 4294967295;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
