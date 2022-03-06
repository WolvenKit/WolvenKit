
namespace WolvenKit.RED4.Types
{
	public partial class gamedataMiniGame_AllSymbols_Record
	{
		[RED("symbolsWithRarity")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> SymbolsWithRarity
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
	}
}
