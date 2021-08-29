using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class WorldTransform : RedBaseClass
	{
		private WorldPosition _position;
		private Quaternion _orientation;

		[Ordinal(0)] 
		[RED("Position")] 
		public WorldPosition Position
		{
			get => GetProperty(ref _position);
			set => SetProperty(ref _position, value);
		}

		[Ordinal(1)] 
		[RED("Orientation")] 
		public Quaternion Orientation
		{
			get => GetProperty(ref _orientation);
			set => SetProperty(ref _orientation, value);
		}
	}
}
