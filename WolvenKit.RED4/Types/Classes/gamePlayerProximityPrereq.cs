using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gamePlayerProximityPrereq : gameIPrereq
	{
		[Ordinal(0)] 
		[RED("squaredRange")] 
		public CFloat SquaredRange
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public gamePlayerProximityPrereq()
		{
			SquaredRange = 1.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
