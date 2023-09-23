using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
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
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
