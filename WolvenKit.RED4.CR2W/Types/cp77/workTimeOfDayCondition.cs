using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class workTimeOfDayCondition : workIWorkspotCondition
	{
		private GameTime _activeAfter;
		private GameTime _activeUntil;

		[Ordinal(2)] 
		[RED("activeAfter")] 
		public GameTime ActiveAfter
		{
			get => GetProperty(ref _activeAfter);
			set => SetProperty(ref _activeAfter, value);
		}

		[Ordinal(3)] 
		[RED("activeUntil")] 
		public GameTime ActiveUntil
		{
			get => GetProperty(ref _activeUntil);
			set => SetProperty(ref _activeUntil, value);
		}

		public workTimeOfDayCondition(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
