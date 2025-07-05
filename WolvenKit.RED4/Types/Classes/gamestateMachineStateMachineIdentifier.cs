using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gamestateMachineStateMachineIdentifier : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("definitionName")] 
		public CName DefinitionName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("referenceName")] 
		public CName ReferenceName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public gamestateMachineStateMachineIdentifier()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
