using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questLevelUpData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("lvl")] 
		public CInt32 Lvl
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(1)] 
		[RED("type")] 
		public CEnum<gamedataProficiencyType> Type
		{
			get => GetPropertyValue<CEnum<gamedataProficiencyType>>();
			set => SetPropertyValue<CEnum<gamedataProficiencyType>>(value);
		}

		[Ordinal(2)] 
		[RED("perkPoints")] 
		public CInt32 PerkPoints
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(3)] 
		[RED("attributePoints")] 
		public CInt32 AttributePoints
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(4)] 
		[RED("disableAction")] 
		public CBool DisableAction
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public questLevelUpData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
