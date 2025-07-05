using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questTeleportPuppetParams : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("destinationRef")] 
		public CHandle<questUniversalRef> DestinationRef
		{
			get => GetPropertyValue<CHandle<questUniversalRef>>();
			set => SetPropertyValue<CHandle<questUniversalRef>>(value);
		}

		[Ordinal(1)] 
		[RED("destinationOffset")] 
		public Vector3 DestinationOffset
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}

		public questTeleportPuppetParams()
		{
			DestinationOffset = new Vector3();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
