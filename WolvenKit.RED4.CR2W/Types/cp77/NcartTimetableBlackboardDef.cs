using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class NcartTimetableBlackboardDef : DeviceBaseBlackboardDef
	{
		private gamebbScriptID_Int32 _timeToDepart;

		[Ordinal(7)] 
		[RED("TimeToDepart")] 
		public gamebbScriptID_Int32 TimeToDepart
		{
			get => GetProperty(ref _timeToDepart);
			set => SetProperty(ref _timeToDepart, value);
		}

		public NcartTimetableBlackboardDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
