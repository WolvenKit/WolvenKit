using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questTeleportPuppetParamsV1 : questAICommandParams
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

		[Ordinal(2)] 
		[RED("doNavTest")] 
		public CBool DoNavTest
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("resetLookAt")] 
		public CBool ResetLookAt
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(4)] 
		[RED("useFastTravelMechanism")] 
		public CBool UseFastTravelMechanism
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(5)] 
		[RED("healAtTeleport")] 
		public CBool HealAtTeleport
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public questTeleportPuppetParamsV1()
		{
			DestinationOffset = new();
			ResetLookAt = true;
			HealAtTeleport = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
