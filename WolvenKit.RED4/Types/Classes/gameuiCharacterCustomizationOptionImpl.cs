
namespace WolvenKit.RED4.Types
{
	public partial class gameuiCharacterCustomizationOptionImpl : gameuiCharacterCustomizationOption
	{
		public gameuiCharacterCustomizationOptionImpl()
		{
			PrevIndex = uint.MaxValue;
			CurrIndex = uint.MaxValue;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
