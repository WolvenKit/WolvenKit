using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class VehiclePurchaseDataDef : gamebbScriptDefinition
	{
		[Ordinal(0)] 
		[RED("PurchasedVehicleRecordID")] 
		public gamebbScriptID_Variant PurchasedVehicleRecordID
		{
			get => GetPropertyValue<gamebbScriptID_Variant>();
			set => SetPropertyValue<gamebbScriptID_Variant>(value);
		}

		public VehiclePurchaseDataDef()
		{
			PurchasedVehicleRecordID = new();
		}
	}
}
