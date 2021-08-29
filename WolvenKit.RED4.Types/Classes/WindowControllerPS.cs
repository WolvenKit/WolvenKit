using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class WindowControllerPS : DoorControllerPS
	{
		private CHandle<EngDemoContainer> _windowSkillChecks;

		[Ordinal(114)] 
		[RED("windowSkillChecks")] 
		public CHandle<EngDemoContainer> WindowSkillChecks
		{
			get => GetProperty(ref _windowSkillChecks);
			set => SetProperty(ref _windowSkillChecks, value);
		}
	}
}
