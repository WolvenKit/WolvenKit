using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIParametrizedResourceReference : AIResourceReference
	{
		private LibTreeParametersForwarder _overrides;

		[Ordinal(2)] 
		[RED("overrides")] 
		public LibTreeParametersForwarder Overrides
		{
			get => GetProperty(ref _overrides);
			set => SetProperty(ref _overrides, value);
		}
	}
}
