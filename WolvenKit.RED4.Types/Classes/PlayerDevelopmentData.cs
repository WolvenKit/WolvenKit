using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class PlayerDevelopmentData : IScriptable
	{
		private CWeakHandle<gameObject> _owner;
		private entEntityID _ownerID;
		private CArray<SExperiencePoints> _queuedCombatExp;
		private CArray<SProficiency> _proficiencies;
		private CArray<SAttribute> _attributes;
		private CArray<SPerkArea> _perkAreas;
		private CArray<STrait> _traits;
		private CArray<SDevelopmentPoints> _devPoints;
		private CArray<CHandle<SkillCheckPrereqState>> _skillPrereqs;
		private CArray<CHandle<StatCheckPrereqState>> _statPrereqs;
		private CArray<ItemRecipe> _knownRecipes;
		private CInt32 _highestCompletedMinigameLevel;
		private CInt32 _startingLevel;
		private CInt32 _startingExperience;
		private CEnum<gamedataLifePath> _lifePath;
		private CBool _displayActivityLog;

		[Ordinal(0)] 
		[RED("owner")] 
		public CWeakHandle<gameObject> Owner
		{
			get => GetProperty(ref _owner);
			set => SetProperty(ref _owner, value);
		}

		[Ordinal(1)] 
		[RED("ownerID")] 
		public entEntityID OwnerID
		{
			get => GetProperty(ref _ownerID);
			set => SetProperty(ref _ownerID, value);
		}

		[Ordinal(2)] 
		[RED("queuedCombatExp")] 
		public CArray<SExperiencePoints> QueuedCombatExp
		{
			get => GetProperty(ref _queuedCombatExp);
			set => SetProperty(ref _queuedCombatExp, value);
		}

		[Ordinal(3)] 
		[RED("proficiencies")] 
		public CArray<SProficiency> Proficiencies
		{
			get => GetProperty(ref _proficiencies);
			set => SetProperty(ref _proficiencies, value);
		}

		[Ordinal(4)] 
		[RED("attributes")] 
		public CArray<SAttribute> Attributes
		{
			get => GetProperty(ref _attributes);
			set => SetProperty(ref _attributes, value);
		}

		[Ordinal(5)] 
		[RED("perkAreas")] 
		public CArray<SPerkArea> PerkAreas
		{
			get => GetProperty(ref _perkAreas);
			set => SetProperty(ref _perkAreas, value);
		}

		[Ordinal(6)] 
		[RED("traits")] 
		public CArray<STrait> Traits
		{
			get => GetProperty(ref _traits);
			set => SetProperty(ref _traits, value);
		}

		[Ordinal(7)] 
		[RED("devPoints")] 
		public CArray<SDevelopmentPoints> DevPoints
		{
			get => GetProperty(ref _devPoints);
			set => SetProperty(ref _devPoints, value);
		}

		[Ordinal(8)] 
		[RED("skillPrereqs")] 
		public CArray<CHandle<SkillCheckPrereqState>> SkillPrereqs
		{
			get => GetProperty(ref _skillPrereqs);
			set => SetProperty(ref _skillPrereqs, value);
		}

		[Ordinal(9)] 
		[RED("statPrereqs")] 
		public CArray<CHandle<StatCheckPrereqState>> StatPrereqs
		{
			get => GetProperty(ref _statPrereqs);
			set => SetProperty(ref _statPrereqs, value);
		}

		[Ordinal(10)] 
		[RED("knownRecipes")] 
		public CArray<ItemRecipe> KnownRecipes
		{
			get => GetProperty(ref _knownRecipes);
			set => SetProperty(ref _knownRecipes, value);
		}

		[Ordinal(11)] 
		[RED("highestCompletedMinigameLevel")] 
		public CInt32 HighestCompletedMinigameLevel
		{
			get => GetProperty(ref _highestCompletedMinigameLevel);
			set => SetProperty(ref _highestCompletedMinigameLevel, value);
		}

		[Ordinal(12)] 
		[RED("startingLevel")] 
		public CInt32 StartingLevel
		{
			get => GetProperty(ref _startingLevel);
			set => SetProperty(ref _startingLevel, value);
		}

		[Ordinal(13)] 
		[RED("startingExperience")] 
		public CInt32 StartingExperience
		{
			get => GetProperty(ref _startingExperience);
			set => SetProperty(ref _startingExperience, value);
		}

		[Ordinal(14)] 
		[RED("lifePath")] 
		public CEnum<gamedataLifePath> LifePath
		{
			get => GetProperty(ref _lifePath);
			set => SetProperty(ref _lifePath, value);
		}

		[Ordinal(15)] 
		[RED("displayActivityLog")] 
		public CBool DisplayActivityLog
		{
			get => GetProperty(ref _displayActivityLog);
			set => SetProperty(ref _displayActivityLog, value);
		}
	}
}
