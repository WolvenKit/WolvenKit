using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AIAIBlackboardSerializableID : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("id")] 
		public gameBlackboardSerializableID Id
		{
			get => GetPropertyValue<gameBlackboardSerializableID>();
			set => SetPropertyValue<gameBlackboardSerializableID>(value);
		}

		public AIAIBlackboardSerializableID()
		{
			Id = new gameBlackboardSerializableID();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
