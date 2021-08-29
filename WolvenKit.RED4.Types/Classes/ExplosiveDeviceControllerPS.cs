using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ExplosiveDeviceControllerPS : BasicDistractionDeviceControllerPS
	{
		private CHandle<EngDemoContainer> _explosiveSkillChecks;
		private CArray<ExplosiveDeviceResourceDefinition> _explosionDefinition;
		private CBool _explosiveWithQhacks;
		private CFloat _healthDecay;
		private CFloat _timeToMeshSwap;
		private CBool _shouldDistractionHitVFXIgnoreHitPosition;
		private CBool _canBeDisabledWithQhacks;
		private CBool _disarmed;
		private CBool _exploded;
		private CBool _provideExplodeAction;
		private CBool _doExplosiveEngineerLogic;

		[Ordinal(109)] 
		[RED("explosiveSkillChecks")] 
		public CHandle<EngDemoContainer> ExplosiveSkillChecks
		{
			get => GetProperty(ref _explosiveSkillChecks);
			set => SetProperty(ref _explosiveSkillChecks, value);
		}

		[Ordinal(110)] 
		[RED("explosionDefinition")] 
		public CArray<ExplosiveDeviceResourceDefinition> ExplosionDefinition
		{
			get => GetProperty(ref _explosionDefinition);
			set => SetProperty(ref _explosionDefinition, value);
		}

		[Ordinal(111)] 
		[RED("explosiveWithQhacks")] 
		public CBool ExplosiveWithQhacks
		{
			get => GetProperty(ref _explosiveWithQhacks);
			set => SetProperty(ref _explosiveWithQhacks, value);
		}

		[Ordinal(112)] 
		[RED("HealthDecay")] 
		public CFloat HealthDecay
		{
			get => GetProperty(ref _healthDecay);
			set => SetProperty(ref _healthDecay, value);
		}

		[Ordinal(113)] 
		[RED("timeToMeshSwap")] 
		public CFloat TimeToMeshSwap
		{
			get => GetProperty(ref _timeToMeshSwap);
			set => SetProperty(ref _timeToMeshSwap, value);
		}

		[Ordinal(114)] 
		[RED("shouldDistractionHitVFXIgnoreHitPosition")] 
		public CBool ShouldDistractionHitVFXIgnoreHitPosition
		{
			get => GetProperty(ref _shouldDistractionHitVFXIgnoreHitPosition);
			set => SetProperty(ref _shouldDistractionHitVFXIgnoreHitPosition, value);
		}

		[Ordinal(115)] 
		[RED("canBeDisabledWithQhacks")] 
		public CBool CanBeDisabledWithQhacks
		{
			get => GetProperty(ref _canBeDisabledWithQhacks);
			set => SetProperty(ref _canBeDisabledWithQhacks, value);
		}

		[Ordinal(116)] 
		[RED("disarmed")] 
		public CBool Disarmed
		{
			get => GetProperty(ref _disarmed);
			set => SetProperty(ref _disarmed, value);
		}

		[Ordinal(117)] 
		[RED("exploded")] 
		public CBool Exploded
		{
			get => GetProperty(ref _exploded);
			set => SetProperty(ref _exploded, value);
		}

		[Ordinal(118)] 
		[RED("provideExplodeAction")] 
		public CBool ProvideExplodeAction
		{
			get => GetProperty(ref _provideExplodeAction);
			set => SetProperty(ref _provideExplodeAction, value);
		}

		[Ordinal(119)] 
		[RED("doExplosiveEngineerLogic")] 
		public CBool DoExplosiveEngineerLogic
		{
			get => GetProperty(ref _doExplosiveEngineerLogic);
			set => SetProperty(ref _doExplosiveEngineerLogic, value);
		}
	}
}
