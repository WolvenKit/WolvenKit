using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class scnRidSerialNumber : RedBaseClass
	{
		private CUInt32 _serialNumber;

		[Ordinal(0)] 
		[RED("serialNumber")] 
		public CUInt32 SerialNumber
		{
			get => GetProperty(ref _serialNumber);
			set => SetProperty(ref _serialNumber, value);
		}
	}
}
