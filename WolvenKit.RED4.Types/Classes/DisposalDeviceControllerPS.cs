using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class DisposalDeviceControllerPS : ScriptableDeviceComponentPS
	{
		[Ordinal(104)] 
		[RED("DisposalDeviceSetup")] 
		public DisposalDeviceSetup DisposalDeviceSetup
		{
			get => GetPropertyValue<DisposalDeviceSetup>();
			set => SetPropertyValue<DisposalDeviceSetup>(value);
		}

		[Ordinal(105)] 
		[RED("distractionSetup")] 
		public DistractionSetup DistractionSetup
		{
			get => GetPropertyValue<DistractionSetup>();
			set => SetPropertyValue<DistractionSetup>(value);
		}

		[Ordinal(106)] 
		[RED("explosionSetup")] 
		public DistractionSetup ExplosionSetup
		{
			get => GetPropertyValue<DistractionSetup>();
			set => SetPropertyValue<DistractionSetup>(value);
		}

		[Ordinal(107)] 
		[RED("isDistractionDisabled")] 
		public CBool IsDistractionDisabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(108)] 
		[RED("wasActivated")] 
		public CBool WasActivated
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(109)] 
		[RED("wasLethalTakedownPerformed")] 
		public CBool WasLethalTakedownPerformed
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(110)] 
		[RED("isPlayerCurrentlyPerformingDisposal")] 
		public CBool IsPlayerCurrentlyPerformingDisposal
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public DisposalDeviceControllerPS()
		{
			DeviceName = "LocKey#102";
			TweakDBRecord = 95792479614;
			TweakDBDescriptionRecord = 148853104190;
			ShouldScannerShowStatus = false;
			ShouldScannerShowNetwork = false;
			ShouldScannerShowRole = true;
			DisposalDeviceSetup = new() { NumberOfUses = 1, IsBodyRequired = true };
			DistractionSetup = new() { StimuliRange = 10.000000F, ExplosionDefinition = new() };
			ExplosionSetup = new() { StimuliRange = 10.000000F, ExplosionDefinition = new() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
