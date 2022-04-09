using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AIArgumentGlobalNodeIdValue : AIArgumentDefinition
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
		public worldGlobalNodeID DefaultValue
		{
			get => GetPropertyValue<worldGlobalNodeID>();
			set => SetPropertyValue<worldGlobalNodeID>(value);
		}

		public AIArgumentGlobalNodeIdValue()
		{
			Type = Enums.AIArgumentType.GlobalNodeId;
			DefaultValue = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
