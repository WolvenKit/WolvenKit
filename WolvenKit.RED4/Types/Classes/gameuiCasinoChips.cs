using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiCasinoChips : gameObject
	{
		[Ordinal(36)] 
		[RED("digitNames")] 
		public CArray<CName> DigitNames
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		[Ordinal(37)] 
		[RED("flippedDigitNames")] 
		public CArray<CName> FlippedDigitNames
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		public gameuiCasinoChips()
		{
			DigitNames = new();
			FlippedDigitNames = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
