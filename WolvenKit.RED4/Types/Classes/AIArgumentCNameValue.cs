using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AIArgumentCNameValue : AIArgumentDefinition
	{
		[Ordinal(3)] 
		[RED("type")] 
		public CEnum<AIArgumentType> Type
		{
			get => GetPropertyValue<CEnum<AIArgumentType>>();
			set => SetPropertyValue<CEnum<AIArgumentType>>(value);
		}

		[Ordinal(4)] 
		[RED("defaultValue")] 
		public CName DefaultValue
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public AIArgumentCNameValue()
		{
			Type = Enums.AIArgumentType.CName;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
