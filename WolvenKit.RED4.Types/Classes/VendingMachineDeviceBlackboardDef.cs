using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class VendingMachineDeviceBlackboardDef : DeviceBaseBlackboardDef
	{
		private gamebbScriptID_Variant _actionStatus;
		private gamebbScriptID_Bool _soldOut;

		[Ordinal(7)] 
		[RED("ActionStatus")] 
		public gamebbScriptID_Variant ActionStatus
		{
			get => GetProperty(ref _actionStatus);
			set => SetProperty(ref _actionStatus, value);
		}

		[Ordinal(8)] 
		[RED("SoldOut")] 
		public gamebbScriptID_Bool SoldOut
		{
			get => GetProperty(ref _soldOut);
			set => SetProperty(ref _soldOut, value);
		}
	}
}
