using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animFacialSetup_TracksMapping : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("numEnvelopes")] 
		public CUInt16 NumEnvelopes
		{
			get => GetPropertyValue<CUInt16>();
			set => SetPropertyValue<CUInt16>(value);
		}

		[Ordinal(1)] 
		[RED("numMainPoses")] 
		public CUInt16 NumMainPoses
		{
			get => GetPropertyValue<CUInt16>();
			set => SetPropertyValue<CUInt16>(value);
		}

		[Ordinal(2)] 
		[RED("numLipsyncOverrides")] 
		public CUInt16 NumLipsyncOverrides
		{
			get => GetPropertyValue<CUInt16>();
			set => SetPropertyValue<CUInt16>(value);
		}

		[Ordinal(3)] 
		[RED("numWrinkles")] 
		public CUInt16 NumWrinkles
		{
			get => GetPropertyValue<CUInt16>();
			set => SetPropertyValue<CUInt16>(value);
		}

		public animFacialSetup_TracksMapping()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
