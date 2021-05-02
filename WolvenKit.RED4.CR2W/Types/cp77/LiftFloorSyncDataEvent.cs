using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class LiftFloorSyncDataEvent : redEvent
	{
		private CBool _isHidden;
		private CBool _isInactive;

		[Ordinal(0)] 
		[RED("isHidden")] 
		public CBool IsHidden
		{
			get => GetProperty(ref _isHidden);
			set => SetProperty(ref _isHidden, value);
		}

		[Ordinal(1)] 
		[RED("isInactive")] 
		public CBool IsInactive
		{
			get => GetProperty(ref _isInactive);
			set => SetProperty(ref _isInactive, value);
		}

		public LiftFloorSyncDataEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
