using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class DistractionSetup : RedBaseClass
	{
		private CFloat _stimuliRange;
		private CBool _disableOnActivation;
		private CBool _hasSimpleInteraction;
		private CBool _hasSpiderbotInteraction;
		private CBool _hasQuickHack;
		private CBool _hasComputerInteraction;
		private TweakDBID _alternativeInteractionName;
		private TweakDBID _alternativeSpiderbotInteractionName;
		private TweakDBID _alternativeQuickHackName;
		private CHandle<EngDemoContainer> _skillChecks;
		private CArray<ExplosiveDeviceResourceDefinition> _explosionDefinition;

		[Ordinal(0)] 
		[RED("StimuliRange")] 
		public CFloat StimuliRange
		{
			get => GetProperty(ref _stimuliRange);
			set => SetProperty(ref _stimuliRange, value);
		}

		[Ordinal(1)] 
		[RED("disableOnActivation")] 
		public CBool DisableOnActivation
		{
			get => GetProperty(ref _disableOnActivation);
			set => SetProperty(ref _disableOnActivation, value);
		}

		[Ordinal(2)] 
		[RED("hasSimpleInteraction")] 
		public CBool HasSimpleInteraction
		{
			get => GetProperty(ref _hasSimpleInteraction);
			set => SetProperty(ref _hasSimpleInteraction, value);
		}

		[Ordinal(3)] 
		[RED("hasSpiderbotInteraction")] 
		public CBool HasSpiderbotInteraction
		{
			get => GetProperty(ref _hasSpiderbotInteraction);
			set => SetProperty(ref _hasSpiderbotInteraction, value);
		}

		[Ordinal(4)] 
		[RED("hasQuickHack")] 
		public CBool HasQuickHack
		{
			get => GetProperty(ref _hasQuickHack);
			set => SetProperty(ref _hasQuickHack, value);
		}

		[Ordinal(5)] 
		[RED("hasComputerInteraction")] 
		public CBool HasComputerInteraction
		{
			get => GetProperty(ref _hasComputerInteraction);
			set => SetProperty(ref _hasComputerInteraction, value);
		}

		[Ordinal(6)] 
		[RED("alternativeInteractionName")] 
		public TweakDBID AlternativeInteractionName
		{
			get => GetProperty(ref _alternativeInteractionName);
			set => SetProperty(ref _alternativeInteractionName, value);
		}

		[Ordinal(7)] 
		[RED("alternativeSpiderbotInteractionName")] 
		public TweakDBID AlternativeSpiderbotInteractionName
		{
			get => GetProperty(ref _alternativeSpiderbotInteractionName);
			set => SetProperty(ref _alternativeSpiderbotInteractionName, value);
		}

		[Ordinal(8)] 
		[RED("alternativeQuickHackName")] 
		public TweakDBID AlternativeQuickHackName
		{
			get => GetProperty(ref _alternativeQuickHackName);
			set => SetProperty(ref _alternativeQuickHackName, value);
		}

		[Ordinal(9)] 
		[RED("skillChecks")] 
		public CHandle<EngDemoContainer> SkillChecks
		{
			get => GetProperty(ref _skillChecks);
			set => SetProperty(ref _skillChecks, value);
		}

		[Ordinal(10)] 
		[RED("explosionDefinition")] 
		public CArray<ExplosiveDeviceResourceDefinition> ExplosionDefinition
		{
			get => GetProperty(ref _explosionDefinition);
			set => SetProperty(ref _explosionDefinition, value);
		}

		public DistractionSetup()
		{
			_stimuliRange = 10.000000F;
		}
	}
}
