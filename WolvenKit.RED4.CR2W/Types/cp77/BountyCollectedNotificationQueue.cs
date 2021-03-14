using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class BountyCollectedNotificationQueue : gameuiGenericNotificationGameController
	{
		private CFloat _duration;
		private CName _bountyNotification;

		[Ordinal(2)] 
		[RED("duration")] 
		public CFloat Duration
		{
			get
			{
				if (_duration == null)
				{
					_duration = (CFloat) CR2WTypeManager.Create("Float", "duration", cr2w, this);
				}
				return _duration;
			}
			set
			{
				if (_duration == value)
				{
					return;
				}
				_duration = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("bountyNotification")] 
		public CName BountyNotification
		{
			get
			{
				if (_bountyNotification == null)
				{
					_bountyNotification = (CName) CR2WTypeManager.Create("CName", "bountyNotification", cr2w, this);
				}
				return _bountyNotification;
			}
			set
			{
				if (_bountyNotification == value)
				{
					return;
				}
				_bountyNotification = value;
				PropertySet(this);
			}
		}

		public BountyCollectedNotificationQueue(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
