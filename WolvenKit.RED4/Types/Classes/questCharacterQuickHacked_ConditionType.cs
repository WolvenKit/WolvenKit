using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questCharacterQuickHacked_ConditionType : questICharacterConditionType
	{
		[Ordinal(0)] 
		[RED("objectRef")] 
		public gameEntityReference ObjectRef
		{
			get => GetPropertyValue<gameEntityReference>();
			set => SetPropertyValue<gameEntityReference>(value);
		}

		[Ordinal(1)] 
		[RED("quickHacked")] 
		public CBool QuickHacked
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public questCharacterQuickHacked_ConditionType()
		{
			ObjectRef = new gameEntityReference { Names = new() };
			QuickHacked = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
