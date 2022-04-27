using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AIArgumentSerializableValue : AIArgumentDefinition
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
		public CHandle<ISerializable> DefaultValue
		{
			get => GetPropertyValue<CHandle<ISerializable>>();
			set => SetPropertyValue<CHandle<ISerializable>>(value);
		}

		public AIArgumentSerializableValue()
		{
			Type = Enums.AIArgumentType.Serializable;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
