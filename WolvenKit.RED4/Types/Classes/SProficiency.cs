using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SProficiency : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("type")] 
		public CEnum<gamedataProficiencyType> Type
		{
			get => GetPropertyValue<CEnum<gamedataProficiencyType>>();
			set => SetPropertyValue<CEnum<gamedataProficiencyType>>(value);
		}

		[Ordinal(1)] 
		[RED("currentLevel")] 
		public CInt32 CurrentLevel
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(2)] 
		[RED("maxLevel")] 
		public CInt32 MaxLevel
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(3)] 
		[RED("isAtMaxLevel")] 
		public CBool IsAtMaxLevel
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(4)] 
		[RED("currentExp")] 
		public CInt32 CurrentExp
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(5)] 
		[RED("expToLevel")] 
		public CInt32 ExpToLevel
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(6)] 
		[RED("spentPerkPoints")] 
		public CInt32 SpentPerkPoints
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public SProficiency()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
