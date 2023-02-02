
namespace WolvenKit.RED4.Types
{
	public partial class gamedataRandomVariant_Record
	{
		[RED("statModifierGroups")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> StatModifierGroups
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
		
		[RED("statModifiers")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> StatModifiers
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
		
		[RED("variantPrereqs")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> VariantPrereqs
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
		
		[RED("weight")]
		[REDProperty(IsIgnored = true)]
		public CFloat Weight
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
	}
}
