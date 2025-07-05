using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AIArgumentBoolValue : AIArgumentDefinition
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
		public CBool DefaultValue
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public AIArgumentBoolValue()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
