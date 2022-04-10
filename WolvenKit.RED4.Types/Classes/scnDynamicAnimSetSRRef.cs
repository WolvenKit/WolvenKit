using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class scnDynamicAnimSetSRRef : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("asyncAnimSet")] 
		public CResourceAsyncReference<animAnimSet> AsyncAnimSet
		{
			get => GetPropertyValue<CResourceAsyncReference<animAnimSet>>();
			set => SetPropertyValue<CResourceAsyncReference<animAnimSet>>(value);
		}

		public scnDynamicAnimSetSRRef()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
