using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class WeakFenceControllerPS : ScriptableDeviceComponentPS
	{
		private CHandle<EngDemoContainer> _weakfenceSkillChecks;
		private WeakFenceSetup _weakFenceSetup;

		[Ordinal(104)] 
		[RED("weakfenceSkillChecks")] 
		public CHandle<EngDemoContainer> WeakfenceSkillChecks
		{
			get => GetProperty(ref _weakfenceSkillChecks);
			set => SetProperty(ref _weakfenceSkillChecks, value);
		}

		[Ordinal(105)] 
		[RED("weakFenceSetup")] 
		public WeakFenceSetup WeakFenceSetup
		{
			get => GetProperty(ref _weakFenceSetup);
			set => SetProperty(ref _weakFenceSetup, value);
		}
	}
}
