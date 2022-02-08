using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class StatusEffectPresentHitPrereqCondition : BaseHitPrereqCondition
	{
		[Ordinal(1)] 
		[RED("checkType")] 
		public CName CheckType
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("statusEffectParam")] 
		public CName StatusEffectParam
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(3)] 
		[RED("tag")] 
		public CName Tag
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(4)] 
		[RED("objectToCheck")] 
		public CName ObjectToCheck
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public StatusEffectPresentHitPrereqCondition()
		{
			ObjectToCheck = "Target";
		}
	}
}
