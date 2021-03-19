using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorSelectCoverTaskDefinition : AIbehaviorTaskDefinition
	{
		private CHandle<AIArgumentMapping> _cover;
		private CHandle<AIArgumentMapping> _coverID;
		private CHandle<AIArgumentMapping> _multiCoverID;
		private CHandle<AIArgumentMapping> _combatTarget;
		private CHandle<AIArgumentMapping> _friendlyTarget;
		private CHandle<AIArgumentMapping> _combatZone;
		private CName _sectorSelection;
		private CHandle<AIArgumentMapping> _ignoreRestrictMovementArea;
		private CHandle<AIArgumentMapping> _selectionPreset;
		private CHandle<AIArgumentMapping> _onActivationSelectionPreset;
		private CHandle<AIArgumentMapping> _secondStagePreset;
		private CHandle<AIArgumentMapping> _coverChangeThreshold;
		private CHandle<AIArgumentMapping> _coverGatheringCenterObject;
		private CHandle<AIArgumentMapping> _coverDisablingDuration;

		[Ordinal(1)] 
		[RED("cover")] 
		public CHandle<AIArgumentMapping> Cover
		{
			get => GetProperty(ref _cover);
			set => SetProperty(ref _cover, value);
		}

		[Ordinal(2)] 
		[RED("coverID")] 
		public CHandle<AIArgumentMapping> CoverID
		{
			get => GetProperty(ref _coverID);
			set => SetProperty(ref _coverID, value);
		}

		[Ordinal(3)] 
		[RED("multiCoverID")] 
		public CHandle<AIArgumentMapping> MultiCoverID
		{
			get => GetProperty(ref _multiCoverID);
			set => SetProperty(ref _multiCoverID, value);
		}

		[Ordinal(4)] 
		[RED("combatTarget")] 
		public CHandle<AIArgumentMapping> CombatTarget
		{
			get => GetProperty(ref _combatTarget);
			set => SetProperty(ref _combatTarget, value);
		}

		[Ordinal(5)] 
		[RED("friendlyTarget")] 
		public CHandle<AIArgumentMapping> FriendlyTarget
		{
			get => GetProperty(ref _friendlyTarget);
			set => SetProperty(ref _friendlyTarget, value);
		}

		[Ordinal(6)] 
		[RED("combatZone")] 
		public CHandle<AIArgumentMapping> CombatZone
		{
			get => GetProperty(ref _combatZone);
			set => SetProperty(ref _combatZone, value);
		}

		[Ordinal(7)] 
		[RED("sectorSelection")] 
		public CName SectorSelection
		{
			get => GetProperty(ref _sectorSelection);
			set => SetProperty(ref _sectorSelection, value);
		}

		[Ordinal(8)] 
		[RED("ignoreRestrictMovementArea")] 
		public CHandle<AIArgumentMapping> IgnoreRestrictMovementArea
		{
			get => GetProperty(ref _ignoreRestrictMovementArea);
			set => SetProperty(ref _ignoreRestrictMovementArea, value);
		}

		[Ordinal(9)] 
		[RED("selectionPreset")] 
		public CHandle<AIArgumentMapping> SelectionPreset
		{
			get => GetProperty(ref _selectionPreset);
			set => SetProperty(ref _selectionPreset, value);
		}

		[Ordinal(10)] 
		[RED("onActivationSelectionPreset")] 
		public CHandle<AIArgumentMapping> OnActivationSelectionPreset
		{
			get => GetProperty(ref _onActivationSelectionPreset);
			set => SetProperty(ref _onActivationSelectionPreset, value);
		}

		[Ordinal(11)] 
		[RED("secondStagePreset")] 
		public CHandle<AIArgumentMapping> SecondStagePreset
		{
			get => GetProperty(ref _secondStagePreset);
			set => SetProperty(ref _secondStagePreset, value);
		}

		[Ordinal(12)] 
		[RED("coverChangeThreshold")] 
		public CHandle<AIArgumentMapping> CoverChangeThreshold
		{
			get => GetProperty(ref _coverChangeThreshold);
			set => SetProperty(ref _coverChangeThreshold, value);
		}

		[Ordinal(13)] 
		[RED("coverGatheringCenterObject")] 
		public CHandle<AIArgumentMapping> CoverGatheringCenterObject
		{
			get => GetProperty(ref _coverGatheringCenterObject);
			set => SetProperty(ref _coverGatheringCenterObject, value);
		}

		[Ordinal(14)] 
		[RED("coverDisablingDuration")] 
		public CHandle<AIArgumentMapping> CoverDisablingDuration
		{
			get => GetProperty(ref _coverDisablingDuration);
			set => SetProperty(ref _coverDisablingDuration, value);
		}

		public AIbehaviorSelectCoverTaskDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
