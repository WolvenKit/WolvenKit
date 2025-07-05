using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class scnLipsyncAnimSetSRRef : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("lipsyncAnimSet")] 
		public CResourceReference<animAnimSet> LipsyncAnimSet
		{
			get => GetPropertyValue<CResourceReference<animAnimSet>>();
			set => SetPropertyValue<CResourceReference<animAnimSet>>(value);
		}

		[Ordinal(1)] 
		[RED("asyncRefLipsyncAnimSet")] 
		public CResourceAsyncReference<animAnimSet> AsyncRefLipsyncAnimSet
		{
			get => GetPropertyValue<CResourceAsyncReference<animAnimSet>>();
			set => SetPropertyValue<CResourceAsyncReference<animAnimSet>>(value);
		}

		public scnLipsyncAnimSetSRRef()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
