using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameCursorInterpolationOverrides : inkUserData
	{
		private Vector2 _minSpeed;
		private CFloat _enterTime;

		[Ordinal(0)] 
		[RED("minSpeed")] 
		public Vector2 MinSpeed
		{
			get => GetProperty(ref _minSpeed);
			set => SetProperty(ref _minSpeed, value);
		}

		[Ordinal(1)] 
		[RED("enterTime")] 
		public CFloat EnterTime
		{
			get => GetProperty(ref _enterTime);
			set => SetProperty(ref _enterTime, value);
		}
	}
}
