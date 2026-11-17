using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class weaponSourceHasModWithTagPrereqCondition : BaseHitPrereqCondition
	{
		[Ordinal(3)] 
		[RED("weaponRecordID")] 
		public TweakDBID WeaponRecordID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(4)] 
		[RED("requierdModTag")] 
		public CName RequierdModTag
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public weaponSourceHasModWithTagPrereqCondition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
