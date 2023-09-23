using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class DisposalDeviceControllerPS : ScriptableDeviceComponentPS
	{
		[Ordinal(107)] 
		[RED("DisposalDeviceSetup")] 
		public DisposalDeviceSetup DisposalDeviceSetup
		{
			get => GetPropertyValue<DisposalDeviceSetup>();
			set => SetPropertyValue<DisposalDeviceSetup>(value);
		}

		[Ordinal(108)] 
		[RED("distractionSetup")] 
		public DistractionSetup DistractionSetup
		{
			get => GetPropertyValue<DistractionSetup>();
			set => SetPropertyValue<DistractionSetup>(value);
		}

		[Ordinal(109)] 
		[RED("explosionSetup")] 
		public DistractionSetup ExplosionSetup
		{
			get => GetPropertyValue<DistractionSetup>();
			set => SetPropertyValue<DistractionSetup>(value);
		}

		[Ordinal(110)] 
		[RED("isDistractionDisabled")] 
		public CBool IsDistractionDisabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(111)] 
		[RED("wasActivated")] 
		public CBool WasActivated
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(112)] 
		[RED("wasLethalTakedownPerformed")] 
		public CBool WasLethalTakedownPerformed
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(113)] 
		[RED("isPlayerCurrentlyPerformingDisposal")] 
		public CBool IsPlayerCurrentlyPerformingDisposal
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public DisposalDeviceControllerPS()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
