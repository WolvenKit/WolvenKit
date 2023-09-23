using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questCharacterRoleFinished_ConditionType : questICharacterConditionType
	{
		[Ordinal(0)] 
		[RED("objectRef")] 
		public gameEntityReference ObjectRef
		{
			get => GetPropertyValue<gameEntityReference>();
			set => SetPropertyValue<gameEntityReference>(value);
		}

		[Ordinal(1)] 
		[RED("role")] 
		public CEnum<AIFiniteRoleType> Role
		{
			get => GetPropertyValue<CEnum<AIFiniteRoleType>>();
			set => SetPropertyValue<CEnum<AIFiniteRoleType>>(value);
		}

		public questCharacterRoleFinished_ConditionType()
		{
			ObjectRef = new gameEntityReference { Names = new() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
