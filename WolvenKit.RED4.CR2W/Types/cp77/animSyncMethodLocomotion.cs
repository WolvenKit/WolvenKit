using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animSyncMethodLocomotion : animISyncMethod
	{
		private CName _locomotionFeatureName;
		private CName _accelStopTimeEvent;

		[Ordinal(0)] 
		[RED("locomotionFeatureName")] 
		public CName LocomotionFeatureName
		{
			get
			{
				if (_locomotionFeatureName == null)
				{
					_locomotionFeatureName = (CName) CR2WTypeManager.Create("CName", "locomotionFeatureName", cr2w, this);
				}
				return _locomotionFeatureName;
			}
			set
			{
				if (_locomotionFeatureName == value)
				{
					return;
				}
				_locomotionFeatureName = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("accelStopTimeEvent")] 
		public CName AccelStopTimeEvent
		{
			get
			{
				if (_accelStopTimeEvent == null)
				{
					_accelStopTimeEvent = (CName) CR2WTypeManager.Create("CName", "accelStopTimeEvent", cr2w, this);
				}
				return _accelStopTimeEvent;
			}
			set
			{
				if (_accelStopTimeEvent == value)
				{
					return;
				}
				_accelStopTimeEvent = value;
				PropertySet(this);
			}
		}

		public animSyncMethodLocomotion(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
