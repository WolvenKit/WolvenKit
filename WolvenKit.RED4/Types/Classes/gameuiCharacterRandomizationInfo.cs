using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiCharacterRandomizationInfo : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("minRating")] 
		public CUInt32 MinRating
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(1)] 
		[RED("maxRating")] 
		public CUInt32 MaxRating
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		public gameuiCharacterRandomizationInfo()
		{
			MinRating = 1;
			MaxRating = 10;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
