using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class LibTreeSharedVarRegistrationName : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("name")] 
		public CName Name
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public LibTreeSharedVarRegistrationName()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
