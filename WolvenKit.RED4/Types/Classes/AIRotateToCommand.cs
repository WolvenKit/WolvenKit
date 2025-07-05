using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AIRotateToCommand : AIMoveCommand
	{
		[Ordinal(7)] 
		[RED("target")] 
		public AIPositionSpec Target
		{
			get => GetPropertyValue<AIPositionSpec>();
			set => SetPropertyValue<AIPositionSpec>(value);
		}

		[Ordinal(8)] 
		[RED("angleTolerance")] 
		public CFloat AngleTolerance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(9)] 
		[RED("angleOffset")] 
		public CFloat AngleOffset
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(10)] 
		[RED("speed")] 
		public CFloat Speed
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public AIRotateToCommand()
		{
			Target = new AIPositionSpec { WorldPosition = new WorldPosition { X = new FixedPoint(), Y = new FixedPoint(), Z = new FixedPoint() } };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
