using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ReadyEvents : WeaponEventsTransition
	{
		private CFloat _timeStamp;

		[Ordinal(0)] 
		[RED("timeStamp")] 
		public CFloat TimeStamp
		{
			get
			{
				if (_timeStamp == null)
				{
					_timeStamp = (CFloat) CR2WTypeManager.Create("Float", "timeStamp", cr2w, this);
				}
				return _timeStamp;
			}
			set
			{
				if (_timeStamp == value)
				{
					return;
				}
				_timeStamp = value;
				PropertySet(this);
			}
		}

		public ReadyEvents(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
