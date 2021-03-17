using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class LiftStartDelayEvent : redEvent
	{
		private CInt32 _targetFloor;

		[Ordinal(0)] 
		[RED("targetFloor")] 
		public CInt32 TargetFloor
		{
			get => GetProperty(ref _targetFloor);
			set => SetProperty(ref _targetFloor, value);
		}

		public LiftStartDelayEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
