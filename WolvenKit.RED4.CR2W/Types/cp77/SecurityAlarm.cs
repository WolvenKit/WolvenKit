using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SecurityAlarm : InteractiveMasterDevice
	{
		private CHandle<entMeshComponent> _workingAlarm;
		private CHandle<entMeshComponent> _destroyedAlarm;
		private CBool _isGlitching;

		[Ordinal(96)] 
		[RED("workingAlarm")] 
		public CHandle<entMeshComponent> WorkingAlarm
		{
			get => GetProperty(ref _workingAlarm);
			set => SetProperty(ref _workingAlarm, value);
		}

		[Ordinal(97)] 
		[RED("destroyedAlarm")] 
		public CHandle<entMeshComponent> DestroyedAlarm
		{
			get => GetProperty(ref _destroyedAlarm);
			set => SetProperty(ref _destroyedAlarm, value);
		}

		[Ordinal(98)] 
		[RED("isGlitching")] 
		public CBool IsGlitching
		{
			get => GetProperty(ref _isGlitching);
			set => SetProperty(ref _isGlitching, value);
		}

		public SecurityAlarm(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
