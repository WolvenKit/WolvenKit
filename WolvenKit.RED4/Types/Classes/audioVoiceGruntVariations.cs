using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class audioVoiceGruntVariations : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("cachedVariations")] 
		public CArray<CName> CachedVariations
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		public audioVoiceGruntVariations()
		{
			CachedVariations = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
