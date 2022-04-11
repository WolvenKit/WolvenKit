using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameDrawItemRequest : gamePlayerScriptableSystemRequest
	{
		[Ordinal(1)] 
		[RED("itemID")] 
		public gameItemID ItemID
		{
			get => GetPropertyValue<gameItemID>();
			set => SetPropertyValue<gameItemID>(value);
		}

		[Ordinal(2)] 
		[RED("equipAnimationType")] 
		public CEnum<gameEquipAnimationType> EquipAnimationType
		{
			get => GetPropertyValue<CEnum<gameEquipAnimationType>>();
			set => SetPropertyValue<CEnum<gameEquipAnimationType>>(value);
		}

		[Ordinal(3)] 
		[RED("assignOnly")] 
		public CBool AssignOnly
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public gameDrawItemRequest()
		{
			ItemID = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
