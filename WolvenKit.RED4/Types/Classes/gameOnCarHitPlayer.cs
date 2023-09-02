using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameOnCarHitPlayer : redEvent
	{
		[Ordinal(0)] 
		[RED("hitDirection")] 
		public Vector4 HitDirection
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(1)] 
		[RED("carId")] 
		public entEntityID CarId
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		public gameOnCarHitPlayer()
		{
			HitDirection = new Vector4();
			CarId = new entEntityID();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
