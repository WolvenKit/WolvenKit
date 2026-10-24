using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questCharacterQuickHackUploadBegin_ConditionType : questICharacterConditionType
	{
		[Ordinal(0)] 
		[RED("objectRef")] 
		public gameEntityReference ObjectRef
		{
			get => GetPropertyValue<gameEntityReference>();
			set => SetPropertyValue<gameEntityReference>(value);
		}

		public questCharacterQuickHackUploadBegin_ConditionType()
		{
			ObjectRef = new gameEntityReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
