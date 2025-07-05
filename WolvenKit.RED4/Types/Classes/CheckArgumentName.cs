using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CheckArgumentName : CheckArguments
	{
		[Ordinal(1)] 
		[RED("customVar")] 
		public CName CustomVar
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public CheckArgumentName()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
