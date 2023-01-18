using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class scnVehicleMoveOnSpline_Overrides : questIVehicleMoveOnSpline_Overrides
	{
		[Ordinal(0)] 
		[RED("useEntry")] 
		public CBool UseEntry
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("useExit")] 
		public CBool UseExit
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("entrySpeed")] 
		public CFloat EntrySpeed
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("exitSpeed")] 
		public CFloat ExitSpeed
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(4)] 
		[RED("entryTransform")] 
		public Transform EntryTransform
		{
			get => GetPropertyValue<Transform>();
			set => SetPropertyValue<Transform>(value);
		}

		[Ordinal(5)] 
		[RED("exitTransform")] 
		public Transform ExitTransform
		{
			get => GetPropertyValue<Transform>();
			set => SetPropertyValue<Transform>(value);
		}

		[Ordinal(6)] 
		[RED("entryMarker")] 
		public scnMarker EntryMarker
		{
			get => GetPropertyValue<scnMarker>();
			set => SetPropertyValue<scnMarker>(value);
		}

		[Ordinal(7)] 
		[RED("exitMarker")] 
		public scnMarker ExitMarker
		{
			get => GetPropertyValue<scnMarker>();
			set => SetPropertyValue<scnMarker>(value);
		}

		public scnVehicleMoveOnSpline_Overrides()
		{
			EntrySpeed = -1.000000F;
			ExitSpeed = -1.000000F;
			EntryTransform = new() { Position = new(), Orientation = new() { R = 1.000000F } };
			ExitTransform = new() { Position = new(), Orientation = new() { R = 1.000000F } };
			EntryMarker = new() { Type = Enums.scnMarkerType.Global, EntityRef = new() { Names = new() }, IsMounted = true };
			ExitMarker = new() { Type = Enums.scnMarkerType.Global, EntityRef = new() { Names = new() }, IsMounted = true };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
