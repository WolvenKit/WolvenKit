using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class scnSceneSolutionHash : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("sceneSolutionHash")] 
		public scnSceneSolutionHashHash SceneSolutionHash
		{
			get => GetPropertyValue<scnSceneSolutionHashHash>();
			set => SetPropertyValue<scnSceneSolutionHashHash>(value);
		}

		public scnSceneSolutionHash()
		{
			SceneSolutionHash = new scnSceneSolutionHashHash();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
