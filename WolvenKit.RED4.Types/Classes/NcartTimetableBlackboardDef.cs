using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class NcartTimetableBlackboardDef : DeviceBaseBlackboardDef
	{
		[Ordinal(7)] 
		[RED("TimeToDepart")] 
		public gamebbScriptID_Int32 TimeToDepart
		{
			get => GetPropertyValue<gamebbScriptID_Int32>();
			set => SetPropertyValue<gamebbScriptID_Int32>(value);
		}

		public NcartTimetableBlackboardDef()
		{
			TimeToDepart = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
