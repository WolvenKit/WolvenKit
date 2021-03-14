using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class TrafficLightResaveData : CVariable
	{
		private CFloat _transitionDuration;
		private CBool _playNotificationSounds;
		private CBool _invertTrafficEvents;

		[Ordinal(0)] 
		[RED("transitionDuration")] 
		public CFloat TransitionDuration
		{
			get
			{
				if (_transitionDuration == null)
				{
					_transitionDuration = (CFloat) CR2WTypeManager.Create("Float", "transitionDuration", cr2w, this);
				}
				return _transitionDuration;
			}
			set
			{
				if (_transitionDuration == value)
				{
					return;
				}
				_transitionDuration = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("playNotificationSounds")] 
		public CBool PlayNotificationSounds
		{
			get
			{
				if (_playNotificationSounds == null)
				{
					_playNotificationSounds = (CBool) CR2WTypeManager.Create("Bool", "playNotificationSounds", cr2w, this);
				}
				return _playNotificationSounds;
			}
			set
			{
				if (_playNotificationSounds == value)
				{
					return;
				}
				_playNotificationSounds = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("invertTrafficEvents")] 
		public CBool InvertTrafficEvents
		{
			get
			{
				if (_invertTrafficEvents == null)
				{
					_invertTrafficEvents = (CBool) CR2WTypeManager.Create("Bool", "invertTrafficEvents", cr2w, this);
				}
				return _invertTrafficEvents;
			}
			set
			{
				if (_invertTrafficEvents == value)
				{
					return;
				}
				_invertTrafficEvents = value;
				PropertySet(this);
			}
		}

		public TrafficLightResaveData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
