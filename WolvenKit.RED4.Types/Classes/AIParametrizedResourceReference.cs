using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
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
			Overrides = new() { Overrides = new() };
		}
	}
}
