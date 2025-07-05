
namespace WolvenKit.RED4.Types
{
	public partial class gamedataRemoveAllModifiersEffector_Record
	{
		[RED("applicationTarget")]
		[REDProperty(IsIgnored = true)]
		public CName ApplicationTarget
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("statType")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID StatType
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
	}
}
