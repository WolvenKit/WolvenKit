using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animFacialSetup_TracksMapping : RedBaseClass
	{
		private CUInt16 _numEnvelopes;
		private CUInt16 _numMainPoses;
		private CUInt16 _numLipsyncOverrides;
		private CUInt16 _numWrinkles;

		[Ordinal(0)] 
		[RED("numEnvelopes")] 
		public CUInt16 NumEnvelopes
		{
			get => GetProperty(ref _numEnvelopes);
			set => SetProperty(ref _numEnvelopes, value);
		}

		[Ordinal(1)] 
		[RED("numMainPoses")] 
		public CUInt16 NumMainPoses
		{
			get => GetProperty(ref _numMainPoses);
			set => SetProperty(ref _numMainPoses, value);
		}

		[Ordinal(2)] 
		[RED("numLipsyncOverrides")] 
		public CUInt16 NumLipsyncOverrides
		{
			get => GetProperty(ref _numLipsyncOverrides);
			set => SetProperty(ref _numLipsyncOverrides, value);
		}

		[Ordinal(3)] 
		[RED("numWrinkles")] 
		public CUInt16 NumWrinkles
		{
			get => GetProperty(ref _numWrinkles);
			set => SetProperty(ref _numWrinkles, value);
		}
	}
}
