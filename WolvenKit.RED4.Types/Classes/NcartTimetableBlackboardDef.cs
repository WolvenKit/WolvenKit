using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class NcartTimetableBlackboardDef : DeviceBaseBlackboardDef
	{
		private gamebbScriptID_Int32 _timeToDepart;

		[Ordinal(7)] 
		[RED("TimeToDepart")] 
		public gamebbScriptID_Int32 TimeToDepart
		{
			get => GetProperty(ref _timeToDepart);
			set => SetProperty(ref _timeToDepart, value);
		}
	}
}
