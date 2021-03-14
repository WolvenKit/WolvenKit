using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ChangeLoopCurveEvent : redEvent
	{
		private CFloat _loopTime;
		private CName _loopCurve;

		[Ordinal(0)] 
		[RED("loopTime")] 
		public CFloat LoopTime
		{
			get
			{
				if (_loopTime == null)
				{
					_loopTime = (CFloat) CR2WTypeManager.Create("Float", "loopTime", cr2w, this);
				}
				return _loopTime;
			}
			set
			{
				if (_loopTime == value)
				{
					return;
				}
				_loopTime = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("loopCurve")] 
		public CName LoopCurve
		{
			get
			{
				if (_loopCurve == null)
				{
					_loopCurve = (CName) CR2WTypeManager.Create("CName", "loopCurve", cr2w, this);
				}
				return _loopCurve;
			}
			set
			{
				if (_loopCurve == value)
				{
					return;
				}
				_loopCurve = value;
				PropertySet(this);
			}
		}

		public ChangeLoopCurveEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
