using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questvehiclePanicParams : questVehicleSpecificCommandParams
	{
		[Ordinal(3)] 
		[RED("allowSimplifiedMovement")] 
		public CBool AllowSimplifiedMovement
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(4)] 
		[RED("ignoreTickets")] 
		public CBool IgnoreTickets
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(5)] 
		[RED("disableStuckDetection")] 
		public CBool DisableStuckDetection
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(6)] 
		[RED("useSpeedBasedLookupRange")] 
		public CBool UseSpeedBasedLookupRange
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(7)] 
		[RED("tryDriveAwayFromPlayer")] 
		public CBool TryDriveAwayFromPlayer
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public questvehiclePanicParams()
		{
			PushOtherVehiclesAside = true;
			SecureTimeOut = 60.000000F;
			AllowSimplifiedMovement = true;
			IgnoreTickets = true;
			UseSpeedBasedLookupRange = true;
			TryDriveAwayFromPlayer = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
