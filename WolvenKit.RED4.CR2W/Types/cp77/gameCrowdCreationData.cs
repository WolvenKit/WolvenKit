using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameCrowdCreationData : CVariable
	{
		private CStatic<gameCrowdPhaseTimePeriod> _timePeriods;

		[Ordinal(0)] 
		[RED("timePeriods", 4)] 
		public CStatic<gameCrowdPhaseTimePeriod> TimePeriods
		{
			get
			{
				if (_timePeriods == null)
				{
					_timePeriods = (CStatic<gameCrowdPhaseTimePeriod>) CR2WTypeManager.Create("static:4,gameCrowdPhaseTimePeriod", "timePeriods", cr2w, this);
				}
				return _timePeriods;
			}
			set
			{
				if (_timePeriods == value)
				{
					return;
				}
				_timePeriods = value;
				PropertySet(this);
			}
		}

		public gameCrowdCreationData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
