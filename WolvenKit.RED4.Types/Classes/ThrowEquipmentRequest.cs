using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ThrowEquipmentRequest : gamePlayerScriptableSystemRequest
	{
		private CWeakHandle<gameItemObject> _itemObject;

		[Ordinal(1)] 
		[RED("itemObject")] 
		public CWeakHandle<gameItemObject> ItemObject
		{
			get => GetProperty(ref _itemObject);
			set => SetProperty(ref _itemObject, value);
		}
	}
}
