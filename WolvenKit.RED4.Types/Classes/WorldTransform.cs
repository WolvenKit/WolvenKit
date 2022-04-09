using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDClass(SerializeDefault = true)]
	public partial class WorldTransform : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("Position")] 
		public WorldPosition Position
		{
			get => GetPropertyValue<WorldPosition>();
			set => SetPropertyValue<WorldPosition>(value);
		}

		[Ordinal(1)] 
		[RED("Orientation")] 
		public Quaternion Orientation
		{
			get => GetPropertyValue<Quaternion>();
			set => SetPropertyValue<Quaternion>(value);
		}

		public WorldTransform()
		{
			Position = new() { X = new(), Y = new(), Z = new() };
			Orientation = new() { R = 1.000000F };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
