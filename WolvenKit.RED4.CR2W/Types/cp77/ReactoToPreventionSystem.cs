using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ReactoToPreventionSystem : redEvent
	{
		private CBool _wakeUp;

		[Ordinal(0)] 
		[RED("wakeUp")] 
		public CBool WakeUp
		{
			get => GetProperty(ref _wakeUp);
			set => SetProperty(ref _wakeUp, value);
		}

		public ReactoToPreventionSystem(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
