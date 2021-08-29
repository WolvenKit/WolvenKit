using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SecurityAlarm : InteractiveMasterDevice
	{
		private CHandle<entMeshComponent> _workingAlarm;
		private CHandle<entMeshComponent> _destroyedAlarm;
		private CBool _isGlitching;

		[Ordinal(97)] 
		[RED("workingAlarm")] 
		public CHandle<entMeshComponent> WorkingAlarm
		{
			get => GetProperty(ref _workingAlarm);
			set => SetProperty(ref _workingAlarm, value);
		}

		[Ordinal(98)] 
		[RED("destroyedAlarm")] 
		public CHandle<entMeshComponent> DestroyedAlarm
		{
			get => GetProperty(ref _destroyedAlarm);
			set => SetProperty(ref _destroyedAlarm, value);
		}

		[Ordinal(99)] 
		[RED("isGlitching")] 
		public CBool IsGlitching
		{
			get => GetProperty(ref _isGlitching);
			set => SetProperty(ref _isGlitching, value);
		}
	}
}
