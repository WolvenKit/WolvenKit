using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiSetCharacterCreationDataRequest : gamePlayerScriptableSystemRequest
	{
		[Ordinal(1)] 
		[RED("lifepath")] 
		public TweakDBID Lifepath
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(2)] 
		[RED("attributes")] 
		public CArray<gameuiCharacterCustomizationAttribute> Attributes
		{
			get => GetPropertyValue<CArray<gameuiCharacterCustomizationAttribute>>();
			set => SetPropertyValue<CArray<gameuiCharacterCustomizationAttribute>>(value);
		}

		public gameuiSetCharacterCreationDataRequest()
		{
			Attributes = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
