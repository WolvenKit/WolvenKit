using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AISharedVarDefinition : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("type")] 
		public CEnum<AIESharedVarDefinitionType> Type
		{
			get => GetPropertyValue<CEnum<AIESharedVarDefinitionType>>();
			set => SetPropertyValue<CEnum<AIESharedVarDefinitionType>>(value);
		}

		[Ordinal(1)] 
		[RED("name")] 
		public LibTreeSharedVarRegistrationName Name
		{
			get => GetPropertyValue<LibTreeSharedVarRegistrationName>();
			set => SetPropertyValue<LibTreeSharedVarRegistrationName>(value);
		}

		public AISharedVarDefinition()
		{
			Name = new LibTreeSharedVarRegistrationName();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
