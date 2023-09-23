using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class PlayerDevelopmentData : IScriptable
	{
		[Ordinal(0)] 
		[RED("owner")] 
		public CWeakHandle<gameObject> Owner
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		[Ordinal(1)] 
		[RED("ownerID")] 
		public entEntityID OwnerID
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		[Ordinal(2)] 
		[RED("queuedCombatExp")] 
		public CArray<SExperiencePoints> QueuedCombatExp
		{
			get => GetPropertyValue<CArray<SExperiencePoints>>();
			set => SetPropertyValue<CArray<SExperiencePoints>>(value);
		}

		[Ordinal(3)] 
		[RED("proficiencies")] 
		public CArray<SProficiency> Proficiencies
		{
			get => GetPropertyValue<CArray<SProficiency>>();
			set => SetPropertyValue<CArray<SProficiency>>(value);
		}

		[Ordinal(4)] 
		[RED("attributes")] 
		public CArray<SAttribute> Attributes
		{
			get => GetPropertyValue<CArray<SAttribute>>();
			set => SetPropertyValue<CArray<SAttribute>>(value);
		}

		[Ordinal(5)] 
		[RED("perkAreas")] 
		public CArray<SPerkArea> PerkAreas
		{
			get => GetPropertyValue<CArray<SPerkArea>>();
			set => SetPropertyValue<CArray<SPerkArea>>(value);
		}

		[Ordinal(6)] 
		[RED("traits")] 
		public CArray<STrait> Traits
		{
			get => GetPropertyValue<CArray<STrait>>();
			set => SetPropertyValue<CArray<STrait>>(value);
		}

		[Ordinal(7)] 
		[RED("devPoints")] 
		public CArray<SDevelopmentPoints> DevPoints
		{
			get => GetPropertyValue<CArray<SDevelopmentPoints>>();
			set => SetPropertyValue<CArray<SDevelopmentPoints>>(value);
		}

		[Ordinal(8)] 
		[RED("skillPrereqs")] 
		public CArray<CHandle<SkillCheckPrereqState>> SkillPrereqs
		{
			get => GetPropertyValue<CArray<CHandle<SkillCheckPrereqState>>>();
			set => SetPropertyValue<CArray<CHandle<SkillCheckPrereqState>>>(value);
		}

		[Ordinal(9)] 
		[RED("statPrereqs")] 
		public CArray<CHandle<StatCheckPrereqState>> StatPrereqs
		{
			get => GetPropertyValue<CArray<CHandle<StatCheckPrereqState>>>();
			set => SetPropertyValue<CArray<CHandle<StatCheckPrereqState>>>(value);
		}

		[Ordinal(10)] 
		[RED("knownRecipes")] 
		public CArray<ItemRecipe> KnownRecipes
		{
			get => GetPropertyValue<CArray<ItemRecipe>>();
			set => SetPropertyValue<CArray<ItemRecipe>>(value);
		}

		[Ordinal(11)] 
		[RED("attributesData")] 
		public CArray<SAttributeData> AttributesData
		{
			get => GetPropertyValue<CArray<SAttributeData>>();
			set => SetPropertyValue<CArray<SAttributeData>>(value);
		}

		[Ordinal(12)] 
		[RED("highestCompletedMinigameLevel")] 
		public CInt32 HighestCompletedMinigameLevel
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(13)] 
		[RED("startingLevel")] 
		public CInt32 StartingLevel
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(14)] 
		[RED("startingExperience")] 
		public CInt32 StartingExperience
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(15)] 
		[RED("lifePath")] 
		public CEnum<gamedataLifePath> LifePath
		{
			get => GetPropertyValue<CEnum<gamedataLifePath>>();
			set => SetPropertyValue<CEnum<gamedataLifePath>>(value);
		}

		[Ordinal(16)] 
		[RED("displayActivityLog")] 
		public CBool DisplayActivityLog
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(17)] 
		[RED("progressionBuildSetCompleted")] 
		public CBool ProgressionBuildSetCompleted
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public PlayerDevelopmentData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
