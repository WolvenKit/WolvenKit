using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class BaseActionOperations : DeviceOperations
	{
		[Ordinal(2)] 
		[RED("baseActionsOperations")] 
		public CArray<SBaseActionOperationData> BaseActionsOperations
		{
			get => GetPropertyValue<CArray<SBaseActionOperationData>>();
			set => SetPropertyValue<CArray<SBaseActionOperationData>>(value);
		}

		public BaseActionOperations()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
