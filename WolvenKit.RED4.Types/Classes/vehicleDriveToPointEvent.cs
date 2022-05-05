using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class vehicleDriveToPointEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("targetPos")] 
		public Vector3 TargetPos
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}

		[Ordinal(1)] 
		[RED("useTraffic")] 
		public CBool UseTraffic
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("speedInTraffic")] 
		public CFloat SpeedInTraffic
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public vehicleDriveToPointEvent()
		{
			TargetPos = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
