using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AIParametrizedResourceReference : AIResourceReference
	{
		[Ordinal(2)] 
		[RED("overrides")] 
		public LibTreeParametersForwarder Overrides
		{
			get => GetPropertyValue<LibTreeParametersForwarder>();
			set => SetPropertyValue<LibTreeParametersForwarder>(value);
		}

		public AIParametrizedResourceReference()
		{
			Overrides = new LibTreeParametersForwarder { Overrides = new() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
