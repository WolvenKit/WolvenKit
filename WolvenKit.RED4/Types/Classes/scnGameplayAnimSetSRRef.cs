using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class scnGameplayAnimSetSRRef : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("asyncAnimSet")] 
		public CResourceAsyncReference<animAnimSet> AsyncAnimSet
		{
			get => GetPropertyValue<CResourceAsyncReference<animAnimSet>>();
			set => SetPropertyValue<CResourceAsyncReference<animAnimSet>>(value);
		}

		public scnGameplayAnimSetSRRef()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
