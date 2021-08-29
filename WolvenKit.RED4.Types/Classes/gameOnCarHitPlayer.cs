using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameOnCarHitPlayer : redEvent
	{
		private Vector4 _hitDirection;
		private entEntityID _carId;

		[Ordinal(0)] 
		[RED("hitDirection")] 
		public Vector4 HitDirection
		{
			get => GetProperty(ref _hitDirection);
			set => SetProperty(ref _hitDirection, value);
		}

		[Ordinal(1)] 
		[RED("carId")] 
		public entEntityID CarId
		{
			get => GetProperty(ref _carId);
			set => SetProperty(ref _carId, value);
		}
	}
}
