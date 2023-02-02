using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AIbehaviorSelectCoverTaskDefinition : AIbehaviorTaskDefinition
	{
		[Ordinal(1)] 
		[RED("cover")] 
		public CHandle<AIArgumentMapping> Cover
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(2)] 
		[RED("coverID")] 
		public CHandle<AIArgumentMapping> CoverID
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(3)] 
		[RED("multiCoverID")] 
		public CHandle<AIArgumentMapping> MultiCoverID
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(4)] 
		[RED("combatTarget")] 
		public CHandle<AIArgumentMapping> CombatTarget
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(5)] 
		[RED("friendlyTarget")] 
		public CHandle<AIArgumentMapping> FriendlyTarget
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(6)] 
		[RED("combatZone")] 
		public CHandle<AIArgumentMapping> CombatZone
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(7)] 
		[RED("sectorSelection")] 
		public CName SectorSelection
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(8)] 
		[RED("ignoreRestrictMovementArea")] 
		public CHandle<AIArgumentMapping> IgnoreRestrictMovementArea
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(9)] 
		[RED("selectionPreset")] 
		public CHandle<AIArgumentMapping> SelectionPreset
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(10)] 
		[RED("onActivationSelectionPreset")] 
		public CHandle<AIArgumentMapping> OnActivationSelectionPreset
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(11)] 
		[RED("secondStagePreset")] 
		public CHandle<AIArgumentMapping> SecondStagePreset
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(12)] 
		[RED("coverChangeThreshold")] 
		public CHandle<AIArgumentMapping> CoverChangeThreshold
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(13)] 
		[RED("coverGatheringCenterObject")] 
		public CHandle<AIArgumentMapping> CoverGatheringCenterObject
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(14)] 
		[RED("coverDisablingDuration")] 
		public CHandle<AIArgumentMapping> CoverDisablingDuration
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		public AIbehaviorSelectCoverTaskDefinition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
