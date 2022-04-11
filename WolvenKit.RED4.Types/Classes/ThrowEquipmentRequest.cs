using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ThrowEquipmentRequest : gamePlayerScriptableSystemRequest
	{
		[Ordinal(1)] 
		[RED("itemObject")] 
		public CWeakHandle<gameItemObject> ItemObject
		{
			get => GetPropertyValue<CWeakHandle<gameItemObject>>();
			set => SetPropertyValue<CWeakHandle<gameItemObject>>(value);
		}
	}
}
