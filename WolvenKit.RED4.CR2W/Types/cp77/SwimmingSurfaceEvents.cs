using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SwimmingSurfaceEvents : LocomotionSwimmingEvents
	{
		private CFloat _lapsedTime;

		[Ordinal(3)] 
		[RED("lapsedTime")] 
		public CFloat LapsedTime
		{
			get => GetProperty(ref _lapsedTime);
			set => SetProperty(ref _lapsedTime, value);
		}

		public SwimmingSurfaceEvents(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
