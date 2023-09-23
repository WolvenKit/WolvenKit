using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class StatBonusFromFactEffector : gameEffector
	{
		[Ordinal(0)] 
		[RED("applicationTarget")] 
		public CName ApplicationTarget
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("stat")] 
		public CHandle<gamedataStat_Record> Stat
		{
			get => GetPropertyValue<CHandle<gamedataStat_Record>>();
			set => SetPropertyValue<CHandle<gamedataStat_Record>>(value);
		}

		[Ordinal(2)] 
		[RED("bonusPerStack")] 
		public CFloat BonusPerStack
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("fact")] 
		public CName Fact
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(4)] 
		[RED("modifier")] 
		public CHandle<gameConstantStatModifierData_Deprecated> Modifier
		{
			get => GetPropertyValue<CHandle<gameConstantStatModifierData_Deprecated>>();
			set => SetPropertyValue<CHandle<gameConstantStatModifierData_Deprecated>>(value);
		}

		public StatBonusFromFactEffector()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
