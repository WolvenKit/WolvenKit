using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class vehicleUnmountPosition : RedBaseClass
	{
		private CEnum<vehicleExitDirection> _direction;
		private WorldPosition _position;

		[Ordinal(0)] 
		[RED("direction")] 
		public CEnum<vehicleExitDirection> Direction
		{
			get => GetProperty(ref _direction);
			set => SetProperty(ref _direction, value);
		}

		[Ordinal(1)] 
		[RED("position")] 
		public WorldPosition Position
		{
			get => GetProperty(ref _position);
			set => SetProperty(ref _position, value);
		}
	}
}
