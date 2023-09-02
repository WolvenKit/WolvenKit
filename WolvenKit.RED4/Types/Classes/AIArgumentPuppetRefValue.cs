using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AIArgumentPuppetRefValue : AIArgumentDefinition
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
		public gameEntityReference DefaultValue
		{
			get => GetPropertyValue<gameEntityReference>();
			set => SetPropertyValue<gameEntityReference>(value);
		}

		public AIArgumentPuppetRefValue()
		{
			Type = Enums.AIArgumentType.PuppetRef;
			DefaultValue = new gameEntityReference { Names = new() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
