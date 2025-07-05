using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questUpdateEntityHealthListeners_NodeType : questIUIManagerNodeType
	{
		[Ordinal(0)] 
		[RED("entityRef")] 
		public gameEntityReference EntityRef
		{
			get => GetPropertyValue<gameEntityReference>();
			set => SetPropertyValue<gameEntityReference>(value);
		}

		public questUpdateEntityHealthListeners_NodeType()
		{
			EntityRef = new gameEntityReference { Names = new() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
