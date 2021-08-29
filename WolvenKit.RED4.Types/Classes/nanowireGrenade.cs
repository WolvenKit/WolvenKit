using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class nanowireGrenade : BaseProjectile
	{
		private CFloat _countTime;
		private CFloat _timeToActivation;
		private CFloat _energyLossFactor;
		private CFloat _startVelocity;
		private CFloat _grenadeLifetime;
		private CFloat _gravitySimulation;
		private CName _trailEffectName;
		private CBool _alive;

		[Ordinal(51)] 
		[RED("countTime")] 
		public CFloat CountTime
		{
			get => GetProperty(ref _countTime);
			set => SetProperty(ref _countTime, value);
		}

		[Ordinal(52)] 
		[RED("timeToActivation")] 
		public CFloat TimeToActivation
		{
			get => GetProperty(ref _timeToActivation);
			set => SetProperty(ref _timeToActivation, value);
		}

		[Ordinal(53)] 
		[RED("energyLossFactor")] 
		public CFloat EnergyLossFactor
		{
			get => GetProperty(ref _energyLossFactor);
			set => SetProperty(ref _energyLossFactor, value);
		}

		[Ordinal(54)] 
		[RED("startVelocity")] 
		public CFloat StartVelocity
		{
			get => GetProperty(ref _startVelocity);
			set => SetProperty(ref _startVelocity, value);
		}

		[Ordinal(55)] 
		[RED("grenadeLifetime")] 
		public CFloat GrenadeLifetime
		{
			get => GetProperty(ref _grenadeLifetime);
			set => SetProperty(ref _grenadeLifetime, value);
		}

		[Ordinal(56)] 
		[RED("gravitySimulation")] 
		public CFloat GravitySimulation
		{
			get => GetProperty(ref _gravitySimulation);
			set => SetProperty(ref _gravitySimulation, value);
		}

		[Ordinal(57)] 
		[RED("trailEffectName")] 
		public CName TrailEffectName
		{
			get => GetProperty(ref _trailEffectName);
			set => SetProperty(ref _trailEffectName, value);
		}

		[Ordinal(58)] 
		[RED("alive")] 
		public CBool Alive
		{
			get => GetProperty(ref _alive);
			set => SetProperty(ref _alive, value);
		}
	}
}
