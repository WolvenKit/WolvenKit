using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIBackgroundCombatCommand : AICommand
	{
		private CArray<AIBackgroundCombatStep> _steps;

		[Ordinal(4)] 
		[RED("steps")] 
		public CArray<AIBackgroundCombatStep> Steps
		{
			get => GetProperty(ref _steps);
			set => SetProperty(ref _steps, value);
		}

		public AIBackgroundCombatCommand(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
