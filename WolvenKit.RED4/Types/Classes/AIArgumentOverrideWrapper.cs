using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AIArgumentOverrideWrapper : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("name")] 
		public CName Name
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("type")] 
		public CEnum<AIArgumentType> Type
		{
			get => GetPropertyValue<CEnum<AIArgumentType>>();
			set => SetPropertyValue<CEnum<AIArgumentType>>(value);
		}

		[Ordinal(2)] 
		[RED("definition")] 
		public CHandle<AIArgumentDefinition> Definition
		{
			get => GetPropertyValue<CHandle<AIArgumentDefinition>>();
			set => SetPropertyValue<CHandle<AIArgumentDefinition>>(value);
		}

		public AIArgumentOverrideWrapper()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
