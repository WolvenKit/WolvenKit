using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questSetLootInteractionAccess_NodeType : questIItemManagerNodeType
	{
		[Ordinal(0)] 
		[RED("objectRef")] 
		public gameEntityReference ObjectRef
		{
			get => GetPropertyValue<gameEntityReference>();
			set => SetPropertyValue<gameEntityReference>(value);
		}

		[Ordinal(1)] 
		[RED("accessible")] 
		public CBool Accessible
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public questSetLootInteractionAccess_NodeType()
		{
			ObjectRef = new gameEntityReference { Names = new() };
			Accessible = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
