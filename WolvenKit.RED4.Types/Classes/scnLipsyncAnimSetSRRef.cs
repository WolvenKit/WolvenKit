using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class scnLipsyncAnimSetSRRef : RedBaseClass
	{
		private CResourceReference<animAnimSet> _lipsyncAnimSet;
		private CResourceAsyncReference<animAnimSet> _asyncRefLipsyncAnimSet;

		[Ordinal(0)] 
		[RED("lipsyncAnimSet")] 
		public CResourceReference<animAnimSet> LipsyncAnimSet
		{
			get => GetProperty(ref _lipsyncAnimSet);
			set => SetProperty(ref _lipsyncAnimSet, value);
		}

		[Ordinal(1)] 
		[RED("asyncRefLipsyncAnimSet")] 
		public CResourceAsyncReference<animAnimSet> AsyncRefLipsyncAnimSet
		{
			get => GetProperty(ref _asyncRefLipsyncAnimSet);
			set => SetProperty(ref _asyncRefLipsyncAnimSet, value);
		}
	}
}
