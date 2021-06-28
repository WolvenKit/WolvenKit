using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SecurityGateForceUnlock : redEvent
	{
		private entEntityID _entranceAllowedFor;
		private CBool _shouldUnlock;

		[Ordinal(0)] 
		[RED("entranceAllowedFor")] 
		public entEntityID EntranceAllowedFor
		{
			get => GetProperty(ref _entranceAllowedFor);
			set => SetProperty(ref _entranceAllowedFor, value);
		}

		[Ordinal(1)] 
		[RED("shouldUnlock")] 
		public CBool ShouldUnlock
		{
			get => GetProperty(ref _shouldUnlock);
			set => SetProperty(ref _shouldUnlock, value);
		}

		public SecurityGateForceUnlock(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
