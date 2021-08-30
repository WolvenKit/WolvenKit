using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class audioFlybySettings : RedBaseClass
	{
		private CFloat _movementSpeed;
		private CName _flybyEvent;

		[Ordinal(0)] 
		[RED("movementSpeed")] 
		public CFloat MovementSpeed
		{
			get => GetProperty(ref _movementSpeed);
			set => SetProperty(ref _movementSpeed, value);
		}

		[Ordinal(1)] 
		[RED("flybyEvent")] 
		public CName FlybyEvent
		{
			get => GetProperty(ref _flybyEvent);
			set => SetProperty(ref _flybyEvent, value);
		}

		public audioFlybySettings()
		{
			_movementSpeed = 15.000000F;
		}
	}
}
