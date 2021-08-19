using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class MeleePublicSafeEvents : MeleeEventsTransition
	{
		private CFloat _unequipTime;

		[Ordinal(0)] 
		[RED("unequipTime")] 
		public CFloat UnequipTime
		{
			get => GetProperty(ref _unequipTime);
			set => SetProperty(ref _unequipTime, value);
		}

		public MeleePublicSafeEvents(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
