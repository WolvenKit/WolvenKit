
namespace WolvenKit.RED4.Types
{
	public partial class gamedataAISubActionGameplayLogicPackage_Record
	{
		[RED("packages")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> Packages
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
	}
}
