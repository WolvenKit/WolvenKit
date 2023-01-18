using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldVehicleForbiddenAreaNotifier : worldITriggerAreaNotifer
	{
		[Ordinal(3)] 
		[RED("innerAreaBoundToOuterArea")] 
		public CBool InnerAreaBoundToOuterArea
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(4)] 
		[RED("innerAreaOutline")] 
		public CHandle<AreaShapeOutline> InnerAreaOutline
		{
			get => GetPropertyValue<CHandle<AreaShapeOutline>>();
			set => SetPropertyValue<CHandle<AreaShapeOutline>>(value);
		}

		[Ordinal(5)] 
		[RED("parkingSpots")] 
		public CArray<NodeRef> ParkingSpots
		{
			get => GetPropertyValue<CArray<NodeRef>>();
			set => SetPropertyValue<CArray<NodeRef>>(value);
		}

		[Ordinal(6)] 
		[RED("innerAreaSpeedLimit")] 
		public CFloat InnerAreaSpeedLimit
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(7)] 
		[RED("areaSpeedLimit")] 
		public CFloat AreaSpeedLimit
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(8)] 
		[RED("enableNullArea")] 
		public CBool EnableNullArea
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(9)] 
		[RED("dismount")] 
		public CBool Dismount
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(10)] 
		[RED("enableSummoning")] 
		public CBool EnableSummoning
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public worldVehicleForbiddenAreaNotifier()
		{
			IsEnabled = true;
			IncludeChannels = Enums.TriggerChannel.TC_Player | Enums.TriggerChannel.TC_Vehicle;
			ParkingSpots = new();
			AreaSpeedLimit = 30.000000F;
			EnableNullArea = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
