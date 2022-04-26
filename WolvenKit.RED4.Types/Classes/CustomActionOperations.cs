using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CustomActionOperations : DeviceOperations
	{
		[Ordinal(2)] 
		[RED("customActions")] 
		public SCustomDeviceActionsData CustomActions
		{
			get => GetPropertyValue<SCustomDeviceActionsData>();
			set => SetPropertyValue<SCustomDeviceActionsData>(value);
		}

		[Ordinal(3)] 
		[RED("customActionsOperations")] 
		public CArray<SCustomActionOperationData> CustomActionsOperations
		{
			get => GetPropertyValue<CArray<SCustomActionOperationData>>();
			set => SetPropertyValue<CArray<SCustomActionOperationData>>(value);
		}

		public CustomActionOperations()
		{
			Components = new();
			FxInstances = new();
			CustomActions = new() { Actions = new() };
			CustomActionsOperations = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
