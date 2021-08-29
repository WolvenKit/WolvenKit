using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class FactsDeviceOperation : DeviceOperationBase
	{
		private CArray<SFactOperationData> _facts;

		[Ordinal(5)] 
		[RED("facts")] 
		public CArray<SFactOperationData> Facts
		{
			get => GetProperty(ref _facts);
			set => SetProperty(ref _facts, value);
		}
	}
}
