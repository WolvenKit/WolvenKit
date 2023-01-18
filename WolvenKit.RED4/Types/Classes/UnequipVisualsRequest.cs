using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class UnequipVisualsRequest : gamePlayerScriptableSystemRequest
	{
		[Ordinal(1)] 
		[RED("area")] 
		public CEnum<gamedataEquipmentArea> Area
		{
			get => GetPropertyValue<CEnum<gamedataEquipmentArea>>();
			set => SetPropertyValue<CEnum<gamedataEquipmentArea>>(value);
		}

		[Ordinal(2)] 
		[RED("removeItem")] 
		public CBool RemoveItem
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public UnequipVisualsRequest()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
