using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ProficiencyDisplayData : IDisplayData
	{
		[Ordinal(0)] 
		[RED("attributeId")] 
		public TweakDBID AttributeId
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(1)] 
		[RED("proficiency")] 
		public CEnum<gamedataProficiencyType> Proficiency
		{
			get => GetPropertyValue<CEnum<gamedataProficiencyType>>();
			set => SetPropertyValue<CEnum<gamedataProficiencyType>>(value);
		}

		[Ordinal(2)] 
		[RED("index")] 
		public CInt32 Index
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(3)] 
		[RED("areas")] 
		public CArray<CHandle<AreaDisplayData>> Areas
		{
			get => GetPropertyValue<CArray<CHandle<AreaDisplayData>>>();
			set => SetPropertyValue<CArray<CHandle<AreaDisplayData>>>(value);
		}

		[Ordinal(4)] 
		[RED("passiveBonusesData")] 
		public CArray<CHandle<LevelRewardDisplayData>> PassiveBonusesData
		{
			get => GetPropertyValue<CArray<CHandle<LevelRewardDisplayData>>>();
			set => SetPropertyValue<CArray<CHandle<LevelRewardDisplayData>>>(value);
		}

		[Ordinal(5)] 
		[RED("traitData")] 
		public CHandle<TraitDisplayData> TraitData
		{
			get => GetPropertyValue<CHandle<TraitDisplayData>>();
			set => SetPropertyValue<CHandle<TraitDisplayData>>(value);
		}

		[Ordinal(6)] 
		[RED("localizedName")] 
		public CString LocalizedName
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(7)] 
		[RED("localizedDescription")] 
		public CString LocalizedDescription
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(8)] 
		[RED("level")] 
		public CInt32 Level
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(9)] 
		[RED("maxLevel")] 
		public CInt32 MaxLevel
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(10)] 
		[RED("expPoints")] 
		public CInt32 ExpPoints
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(11)] 
		[RED("maxExpPoints")] 
		public CInt32 MaxExpPoints
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(12)] 
		[RED("unlockedLevel")] 
		public CInt32 UnlockedLevel
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public ProficiencyDisplayData()
		{
			Areas = new();
			PassiveBonusesData = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
