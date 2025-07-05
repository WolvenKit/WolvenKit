using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animOverrideAnimSetRef : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("animSet")] 
		public CResourceAsyncReference<animAnimSet> AnimSet
		{
			get => GetPropertyValue<CResourceAsyncReference<animAnimSet>>();
			set => SetPropertyValue<CResourceAsyncReference<animAnimSet>>(value);
		}

		[Ordinal(1)] 
		[RED("variableName")] 
		public CName VariableName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public animOverrideAnimSetRef()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
