using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class sampleGranade : BaseProjectile
	{
		private CFloat _countTime;
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
		[RED("energyLossFactor")] 
		public CFloat EnergyLossFactor
		{
			get => GetProperty(ref _energyLossFactor);
			set => SetProperty(ref _energyLossFactor, value);
		}

		[Ordinal(53)] 
		[RED("startVelocity")] 
		public CFloat StartVelocity
		{
			get => GetProperty(ref _startVelocity);
			set => SetProperty(ref _startVelocity, value);
		}

		[Ordinal(54)] 
		[RED("grenadeLifetime")] 
		public CFloat GrenadeLifetime
		{
			get => GetProperty(ref _grenadeLifetime);
			set => SetProperty(ref _grenadeLifetime, value);
		}

		[Ordinal(55)] 
		[RED("gravitySimulation")] 
		public CFloat GravitySimulation
		{
			get => GetProperty(ref _gravitySimulation);
			set => SetProperty(ref _gravitySimulation, value);
		}

		[Ordinal(56)] 
		[RED("trailEffectName")] 
		public CName TrailEffectName
		{
			get => GetProperty(ref _trailEffectName);
			set => SetProperty(ref _trailEffectName, value);
		}

		[Ordinal(57)] 
		[RED("alive")] 
		public CBool Alive
		{
			get => GetProperty(ref _alive);
			set => SetProperty(ref _alive, value);
		}

		public sampleGranade(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
