using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questInventoryDuplicate_ConditionType : questIObjectConditionType
	{
		[Ordinal(0)] 
		[RED("objectRef")] 
		public gameEntityReference ObjectRef
		{
			get => GetPropertyValue<gameEntityReference>();
			set => SetPropertyValue<gameEntityReference>(value);
		}

		[Ordinal(1)] 
		[RED("isPlayer")] 
		public CBool IsPlayer
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("itemID")] 
		public TweakDBID ItemID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		public questInventoryDuplicate_ConditionType()
		{
			ObjectRef = new gameEntityReference();
			IsPlayer = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
