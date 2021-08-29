using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class InteractionAreaOperations : DeviceOperations
	{
		private CArray<SInteractionAreaOperationData> _interactionAreaOperations;

		[Ordinal(2)] 
		[RED("interactionAreaOperations")] 
		public CArray<SInteractionAreaOperationData> InteractionAreaOperations_
		{
			get => GetProperty(ref _interactionAreaOperations);
			set => SetProperty(ref _interactionAreaOperations, value);
		}
	}
}
