using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameItemID : RedBaseClass
	{
		private TweakDBID _id;
		private CUInt32 _rngSeed;
		private CUInt16 _uniqueCounter;

		[Ordinal(0)] 
		[RED("id")] 
		public TweakDBID Id
		{
			get => GetProperty(ref _id);
			set => SetProperty(ref _id, value);
		}

		[Ordinal(1)] 
		[RED("rngSeed")] 
		public CUInt32 RngSeed
		{
			get => GetProperty(ref _rngSeed);
			set => SetProperty(ref _rngSeed, value);
		}

		[Ordinal(2)] 
		[RED("uniqueCounter")] 
		public CUInt16 UniqueCounter
		{
			get => GetProperty(ref _uniqueCounter);
			set => SetProperty(ref _uniqueCounter, value);
		}
	}
}
