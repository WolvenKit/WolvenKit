using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class vehicleUnmountPosition : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("direction")] 
		public CEnum<vehicleExitDirection> Direction
		{
			get => GetPropertyValue<CEnum<vehicleExitDirection>>();
			set => SetPropertyValue<CEnum<vehicleExitDirection>>(value);
		}

		[Ordinal(1)] 
		[RED("position")] 
		public WorldPosition Position
		{
			get => GetPropertyValue<WorldPosition>();
			set => SetPropertyValue<WorldPosition>(value);
		}

		public vehicleUnmountPosition()
		{
			Position = new() { X = new(), Y = new(), Z = new() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
