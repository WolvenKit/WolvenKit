using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class EffectNamePresentHitPrereqCondition : BaseHitPrereqCondition
	{
		[Ordinal(3)] 
		[RED("effectName")] 
		public CName EffectName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public EffectNamePresentHitPrereqCondition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
