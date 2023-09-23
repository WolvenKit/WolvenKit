using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class vehicleTryKnockPlayerCarSurfingDownEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("impactPoint")] 
		public Vector3 ImpactPoint
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}

		public vehicleTryKnockPlayerCarSurfingDownEvent()
		{
			ImpactPoint = new Vector3();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
