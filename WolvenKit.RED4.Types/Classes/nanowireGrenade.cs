using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class nanowireGrenade : BaseProjectile
	{
		[Ordinal(46)] 
		[RED("countTime")] 
		public CFloat CountTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(47)] 
		[RED("timeToActivation")] 
		public CFloat TimeToActivation
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(48)] 
		[RED("energyLossFactor")] 
		public CFloat EnergyLossFactor
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(49)] 
		[RED("startVelocity")] 
		public CFloat StartVelocity
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(50)] 
		[RED("grenadeLifetime")] 
		public CFloat GrenadeLifetime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(51)] 
		[RED("gravitySimulation")] 
		public CFloat GravitySimulation
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(52)] 
		[RED("trailEffectName")] 
		public CName TrailEffectName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(53)] 
		[RED("alive")] 
		public CBool Alive
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public nanowireGrenade()
		{
			TrailEffectName = "trail";
			Alive = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
