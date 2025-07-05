using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SuperheroLandEvents : AbstractLandEvents
	{
		[Ordinal(7)] 
		[RED("spawnedLandingAttack")] 
		public CBool SpawnedLandingAttack
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(8)] 
		[RED("superheroFallTime")] 
		public CFloat SuperheroFallTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public SuperheroLandEvents()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
