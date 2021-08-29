using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class LcdScreenBlackBoardDef : DeviceBaseBlackboardDef
	{
		private gamebbScriptID_Variant _messegeData;

		[Ordinal(7)] 
		[RED("MessegeData")] 
		public gamebbScriptID_Variant MessegeData
		{
			get => GetProperty(ref _messegeData);
			set => SetProperty(ref _messegeData, value);
		}
	}
}
