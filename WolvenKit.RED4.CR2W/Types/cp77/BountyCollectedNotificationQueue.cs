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
			get => GetProperty(ref _duration);
			set => SetProperty(ref _duration, value);
		}

		[Ordinal(3)] 
		[RED("bountyNotification")] 
		public CName BountyNotification
		{
			get => GetProperty(ref _bountyNotification);
			set => SetProperty(ref _bountyNotification, value);
		}

		public BountyCollectedNotificationQueue(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
