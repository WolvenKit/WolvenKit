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
			get => GetProperty(ref _transitionDuration);
			set => SetProperty(ref _transitionDuration, value);
		}

		[Ordinal(1)] 
		[RED("playNotificationSounds")] 
		public CBool PlayNotificationSounds
		{
			get => GetProperty(ref _playNotificationSounds);
			set => SetProperty(ref _playNotificationSounds, value);
		}

		[Ordinal(2)] 
		[RED("invertTrafficEvents")] 
		public CBool InvertTrafficEvents
		{
			get => GetProperty(ref _invertTrafficEvents);
			set => SetProperty(ref _invertTrafficEvents, value);
		}

		public TrafficLightResaveData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
