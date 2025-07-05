using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questCharacterAttack_ConditionType : questICharacterConditionType
	{
		[Ordinal(0)] 
		[RED("attackerRef")] 
		public gameEntityReference AttackerRef
		{
			get => GetPropertyValue<gameEntityReference>();
			set => SetPropertyValue<gameEntityReference>(value);
		}

		[Ordinal(1)] 
		[RED("targetRef")] 
		public gameEntityReference TargetRef
		{
			get => GetPropertyValue<gameEntityReference>();
			set => SetPropertyValue<gameEntityReference>(value);
		}

		[Ordinal(2)] 
		[RED("isTargetPlayer")] 
		public CBool IsTargetPlayer
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public questCharacterAttack_ConditionType()
		{
			AttackerRef = new gameEntityReference { Names = new() };
			TargetRef = new gameEntityReference { Names = new() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
