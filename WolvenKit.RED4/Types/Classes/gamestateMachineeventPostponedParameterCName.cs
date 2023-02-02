using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gamestateMachineeventPostponedParameterCName : gamestateMachineeventPostponedParameterBase
	{
		[Ordinal(2)] 
		[RED("value")] 
		public CName Value
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public gamestateMachineeventPostponedParameterCName()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
