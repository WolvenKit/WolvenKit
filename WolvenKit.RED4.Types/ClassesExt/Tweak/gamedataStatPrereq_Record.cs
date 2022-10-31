
namespace WolvenKit.RED4.Types
{
	public partial class gamedataStatPrereq_Record
	{
		[RED("comparisonType")]
		[REDProperty(IsIgnored = true)]
		public CName ComparisonType
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("statModifiers")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> StatModifiers
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
		
		[RED("statType")]
		[REDProperty(IsIgnored = true)]
		public CName StatType
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("valueToCheck")]
		[REDProperty(IsIgnored = true)]
		public CFloat ValueToCheck
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
	}
}
