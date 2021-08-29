using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class BaseActionOperations : DeviceOperations
	{
		private CArray<SBaseActionOperationData> _baseActionsOperations;

		[Ordinal(2)] 
		[RED("baseActionsOperations")] 
		public CArray<SBaseActionOperationData> BaseActionsOperations
		{
			get => GetProperty(ref _baseActionsOperations);
			set => SetProperty(ref _baseActionsOperations, value);
		}
	}
}
