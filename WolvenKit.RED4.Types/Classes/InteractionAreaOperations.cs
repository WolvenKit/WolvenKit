using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class InteractionAreaOperations : DeviceOperations
	{
		[Ordinal(2)] 
		[RED("interactionAreaOperations")] 
		public CArray<SInteractionAreaOperationData> InteractionAreaOperations_
		{
			get => GetPropertyValue<CArray<SInteractionAreaOperationData>>();
			set => SetPropertyValue<CArray<SInteractionAreaOperationData>>(value);
		}

		public InteractionAreaOperations()
		{
			Components = new();
			FxInstances = new();
			InteractionAreaOperations_ = new();
		}
	}
}
