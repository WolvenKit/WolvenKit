using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public abstract partial class CompareArguments : AIbehaviorconditionScript
	{
		[Ordinal(0)] 
		[RED("var1")] 
		public CName Var1
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("var2")] 
		public CName Var2
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public CompareArguments()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
