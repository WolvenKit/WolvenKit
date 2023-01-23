using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gamestateMachineeventPostponedParameterFloat : gamestateMachineeventPostponedParameterBase
	{
		[Ordinal(2)] 
		[RED("value")] 
		public CFloat Value
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public gamestateMachineeventPostponedParameterFloat()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
