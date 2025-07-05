using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ActivatedDeviceCover : ActivatedDeviceTransfromAnim
	{
		[Ordinal(99)] 
		[RED("offMeshConnection")] 
		public CHandle<AIOffMeshConnectionComponent> OffMeshConnection
		{
			get => GetPropertyValue<CHandle<AIOffMeshConnectionComponent>>();
			set => SetPropertyValue<CHandle<AIOffMeshConnectionComponent>>(value);
		}

		public ActivatedDeviceCover()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
