
namespace WolvenKit.RED4.Types
{
	public partial class gamedataRandomStatModifier_Record
	{
		[RED("max")]
		[REDProperty(IsIgnored = true)]
		public CFloat Max
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("min")]
		[REDProperty(IsIgnored = true)]
		public CFloat Min
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("modifierType")]
		[REDProperty(IsIgnored = true)]
		public CName ModifierType
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
		
		[RED("useControlledRandom")]
		[REDProperty(IsIgnored = true)]
		public CBool UseControlledRandom
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
	}
}
