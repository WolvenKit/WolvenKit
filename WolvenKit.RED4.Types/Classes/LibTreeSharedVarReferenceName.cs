using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class LibTreeSharedVarReferenceName : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("name")] 
		public CName Name
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public LibTreeSharedVarReferenceName()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
