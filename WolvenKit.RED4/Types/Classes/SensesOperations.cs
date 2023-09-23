using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SensesOperations : DeviceOperations
	{
		[Ordinal(2)] 
		[RED("sensesOperations")] 
		public CArray<SSensesOperationData> SensesOperations_
		{
			get => GetPropertyValue<CArray<SSensesOperationData>>();
			set => SetPropertyValue<CArray<SSensesOperationData>>(value);
		}

		public SensesOperations()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
