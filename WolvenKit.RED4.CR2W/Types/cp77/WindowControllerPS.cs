using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class WindowControllerPS : DoorControllerPS
	{
		private CHandle<EngDemoContainer> _windowSkillChecks;

		[Ordinal(114)] 
		[RED("windowSkillChecks")] 
		public CHandle<EngDemoContainer> WindowSkillChecks
		{
			get => GetProperty(ref _windowSkillChecks);
			set => SetProperty(ref _windowSkillChecks, value);
		}

		public WindowControllerPS(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
