using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ThrowEquipmentRequest : gamePlayerScriptableSystemRequest
	{
		[Ordinal(1)] 
		[RED("itemObject")] 
		public CWeakHandle<gameItemObject> ItemObject
		{
			get => GetPropertyValue<CWeakHandle<gameItemObject>>();
			set => SetPropertyValue<CWeakHandle<gameItemObject>>(value);
		}

		public ThrowEquipmentRequest()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
