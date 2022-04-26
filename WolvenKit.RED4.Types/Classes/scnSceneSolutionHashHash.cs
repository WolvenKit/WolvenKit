using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class scnSceneSolutionHashHash : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("sceneSolutionHashDate")] 
		public CUInt64 SceneSolutionHashDate
		{
			get => GetPropertyValue<CUInt64>();
			set => SetPropertyValue<CUInt64>(value);
		}

		public scnSceneSolutionHashHash()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
