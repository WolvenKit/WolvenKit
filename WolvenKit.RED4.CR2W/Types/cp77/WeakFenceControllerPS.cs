using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class WeakFenceControllerPS : ScriptableDeviceComponentPS
	{
		private CHandle<EngDemoContainer> _weakfenceSkillChecks;
		private WeakFenceSetup _weakFenceSetup;

		[Ordinal(103)] 
		[RED("weakfenceSkillChecks")] 
		public CHandle<EngDemoContainer> WeakfenceSkillChecks
		{
			get => GetProperty(ref _weakfenceSkillChecks);
			set => SetProperty(ref _weakfenceSkillChecks, value);
		}

		[Ordinal(104)] 
		[RED("weakFenceSetup")] 
		public WeakFenceSetup WeakFenceSetup
		{
			get => GetProperty(ref _weakFenceSetup);
			set => SetProperty(ref _weakFenceSetup, value);
		}

		public WeakFenceControllerPS(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
