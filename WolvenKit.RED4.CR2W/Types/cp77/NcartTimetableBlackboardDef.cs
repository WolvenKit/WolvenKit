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
			get
			{
				if (_timeToDepart == null)
				{
					_timeToDepart = (gamebbScriptID_Int32) CR2WTypeManager.Create("gamebbScriptID_Int32", "TimeToDepart", cr2w, this);
				}
				return _timeToDepart;
			}
			set
			{
				if (_timeToDepart == value)
				{
					return;
				}
				_timeToDepart = value;
				PropertySet(this);
			}
		}

		public NcartTimetableBlackboardDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
