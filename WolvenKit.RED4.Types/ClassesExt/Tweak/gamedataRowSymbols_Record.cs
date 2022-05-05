
namespace WolvenKit.RED4.Types
{
	public partial class gamedataRowSymbols_Record
	{
		[RED("symbols")]
		[REDProperty(IsIgnored = true)]
		public CArray<CInt32> Symbols
		{
			get => GetPropertyValue<CArray<CInt32>>();
			set => SetPropertyValue<CArray<CInt32>>(value);
		}
	}
}
