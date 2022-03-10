
namespace WolvenKit.RED4.Types
{
	public partial class gamedataAIPatternsPackage_Record
	{
		[RED("activationConditions")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> ActivationConditions
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
		
		[RED("patterns")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> Patterns
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
	}
}
