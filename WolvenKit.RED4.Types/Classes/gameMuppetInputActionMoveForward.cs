using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameMuppetInputActionMoveForward : gameIMuppetInputAction
	{
		private Vector2 _direction;
		private CBool _isSprinting;

		[Ordinal(0)] 
		[RED("direction")] 
		public Vector2 Direction
		{
			get => GetProperty(ref _direction);
			set => SetProperty(ref _direction, value);
		}

		[Ordinal(1)] 
		[RED("isSprinting")] 
		public CBool IsSprinting
		{
			get => GetProperty(ref _isSprinting);
			set => SetProperty(ref _isSprinting, value);
		}
	}
}
