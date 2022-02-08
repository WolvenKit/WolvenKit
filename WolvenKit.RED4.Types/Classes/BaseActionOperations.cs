using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
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
			Components = new();
			FxInstances = new();
			BaseActionsOperations = new();
		}
	}
}
