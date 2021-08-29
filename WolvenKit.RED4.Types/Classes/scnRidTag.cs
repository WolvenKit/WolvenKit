using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class scnRidTag : RedBaseClass
	{
		private CName _signature;
		private scnRidSerialNumber _serialNumber;

		[Ordinal(0)] 
		[RED("signature")] 
		public CName Signature
		{
			get => GetProperty(ref _signature);
			set => SetProperty(ref _signature, value);
		}

		[Ordinal(1)] 
		[RED("serialNumber")] 
		public scnRidSerialNumber SerialNumber
		{
			get => GetProperty(ref _serialNumber);
			set => SetProperty(ref _serialNumber, value);
		}
	}
}
