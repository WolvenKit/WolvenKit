using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class StatusEffectPresentHitPrereqCondition : BaseHitPrereqCondition
	{
		[Ordinal(3)] 
		[RED("checkType")] 
		public CEnum<gamedataCheckType> CheckType
		{
			get => GetPropertyValue<CEnum<gamedataCheckType>>();
			set => SetPropertyValue<CEnum<gamedataCheckType>>(value);
		}

		[Ordinal(4)] 
		[RED("statusEffectParam")] 
		public CName StatusEffectParam
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(5)] 
		[RED("tag")] 
		public CName Tag
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(6)] 
		[RED("objectToCheck")] 
		public CName ObjectToCheck
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public StatusEffectPresentHitPrereqCondition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
