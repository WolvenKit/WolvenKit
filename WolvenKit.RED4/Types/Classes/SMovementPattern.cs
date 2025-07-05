using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SMovementPattern : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("speed")] 
		public CFloat Speed
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(1)] 
		[RED("distance")] 
		public CFloat Distance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("direction")] 
		public CEnum<EMovementDirection> Direction
		{
			get => GetPropertyValue<CEnum<EMovementDirection>>();
			set => SetPropertyValue<CEnum<EMovementDirection>>(value);
		}

		public SMovementPattern()
		{
			Speed = 2.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
