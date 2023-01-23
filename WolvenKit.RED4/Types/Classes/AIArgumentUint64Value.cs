using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AIArgumentUint64Value : AIArgumentDefinition
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
		public CUInt64 DefaultValue
		{
			get => GetPropertyValue<CUInt64>();
			set => SetPropertyValue<CUInt64>(value);
		}

		public AIArgumentUint64Value()
		{
			Type = Enums.AIArgumentType.Uint64;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
