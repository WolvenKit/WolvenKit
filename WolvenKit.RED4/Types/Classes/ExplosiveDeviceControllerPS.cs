using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ExplosiveDeviceControllerPS : BasicDistractionDeviceControllerPS
	{
		[Ordinal(109)] 
		[RED("explosiveSkillChecks")] 
		public CHandle<EngDemoContainer> ExplosiveSkillChecks
		{
			get => GetPropertyValue<CHandle<EngDemoContainer>>();
			set => SetPropertyValue<CHandle<EngDemoContainer>>(value);
		}

		[Ordinal(110)] 
		[RED("explosionDefinition")] 
		public CArray<ExplosiveDeviceResourceDefinition> ExplosionDefinition
		{
			get => GetPropertyValue<CArray<ExplosiveDeviceResourceDefinition>>();
			set => SetPropertyValue<CArray<ExplosiveDeviceResourceDefinition>>(value);
		}

		[Ordinal(111)] 
		[RED("explosiveWithQhacks")] 
		public CBool ExplosiveWithQhacks
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(112)] 
		[RED("HealthDecay")] 
		public CFloat HealthDecay
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(113)] 
		[RED("timeToMeshSwap")] 
		public CFloat TimeToMeshSwap
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(114)] 
		[RED("shouldDistractionHitVFXIgnoreHitPosition")] 
		public CBool ShouldDistractionHitVFXIgnoreHitPosition
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(115)] 
		[RED("canBeDisabledWithQhacks")] 
		public CBool CanBeDisabledWithQhacks
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(116)] 
		[RED("disarmed")] 
		public CBool Disarmed
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(117)] 
		[RED("exploded")] 
		public CBool Exploded
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(118)] 
		[RED("provideExplodeAction")] 
		public CBool ProvideExplodeAction
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(119)] 
		[RED("doExplosiveEngineerLogic")] 
		public CBool DoExplosiveEngineerLogic
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public ExplosiveDeviceControllerPS()
		{
			DeviceName = "LocKey#42163";
			TweakDBRecord = "Devices.ExplosiveDevice";
			TweakDBDescriptionRecord = 151932573733;
			ShouldScannerShowStatus = false;
			ShouldScannerShowNetwork = false;
			ShouldScannerShowHealth = true;
			ExplosionDefinition = new();
			TimeToMeshSwap = 0.100000F;
			ProvideExplodeAction = true;
			DoExplosiveEngineerLogic = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
