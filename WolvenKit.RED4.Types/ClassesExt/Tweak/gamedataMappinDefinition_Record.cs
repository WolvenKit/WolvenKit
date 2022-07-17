
namespace WolvenKit.RED4.Types
{
	public partial class gamedataMappinDefinition_Record
	{
		[RED("possibleVariants")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> PossibleVariants
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
	}
}
