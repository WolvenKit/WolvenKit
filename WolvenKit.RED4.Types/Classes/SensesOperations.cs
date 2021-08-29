using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SensesOperations : DeviceOperations
	{
		private CArray<SSensesOperationData> _sensesOperations;

		[Ordinal(2)] 
		[RED("sensesOperations")] 
		public CArray<SSensesOperationData> SensesOperations_
		{
			get => GetProperty(ref _sensesOperations);
			set => SetProperty(ref _sensesOperations, value);
		}
	}
}
