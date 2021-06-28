using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIGenericAdvancedLookatTask : AIGenericLookatTask
	{
		private CHandle<entLookAtAddEvent> _lookAtEvent;
		private CFloat _activationTimeStamp;
		private wCHandle<entEntity> _lookatTarget;

		[Ordinal(0)] 
		[RED("lookAtEvent")] 
		public CHandle<entLookAtAddEvent> LookAtEvent
		{
			get => GetProperty(ref _lookAtEvent);
			set => SetProperty(ref _lookAtEvent, value);
		}

		[Ordinal(1)] 
		[RED("activationTimeStamp")] 
		public CFloat ActivationTimeStamp
		{
			get => GetProperty(ref _activationTimeStamp);
			set => SetProperty(ref _activationTimeStamp, value);
		}

		[Ordinal(2)] 
		[RED("lookatTarget")] 
		public wCHandle<entEntity> LookatTarget
		{
			get => GetProperty(ref _lookatTarget);
			set => SetProperty(ref _lookatTarget, value);
		}

		public AIGenericAdvancedLookatTask(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
