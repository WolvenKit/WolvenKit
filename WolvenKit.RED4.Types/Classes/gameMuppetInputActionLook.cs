using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameMuppetInputActionLook : gameIMuppetInputAction
	{
		private Vector2 _rotation;

		[Ordinal(0)] 
		[RED("rotation")] 
		public Vector2 Rotation
		{
			get => GetProperty(ref _rotation);
			set => SetProperty(ref _rotation, value);
		}
	}
}
