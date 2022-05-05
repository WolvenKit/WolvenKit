using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CheckArguments : AIbehaviorconditionScript
	{
		[Ordinal(0)] 
		[RED("argumentVar")] 
		public CName ArgumentVar
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public CheckArguments()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
