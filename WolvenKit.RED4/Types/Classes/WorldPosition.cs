using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDClass(SerializeDefault = true)]
	public partial class WorldPosition : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("x")] 
		public FixedPoint X
		{
			get => GetPropertyValue<FixedPoint>();
			set => SetPropertyValue<FixedPoint>(value);
		}

		[Ordinal(1)] 
		[RED("y")] 
		public FixedPoint Y
		{
			get => GetPropertyValue<FixedPoint>();
			set => SetPropertyValue<FixedPoint>(value);
		}

		[Ordinal(2)] 
		[RED("z")] 
		public FixedPoint Z
		{
			get => GetPropertyValue<FixedPoint>();
			set => SetPropertyValue<FixedPoint>(value);
		}

		public WorldPosition()
		{
			X = new FixedPoint();
			Y = new FixedPoint();
			Z = new FixedPoint();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
