using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RagdollToggleDelayEvent : redEvent
	{
		private wCHandle<gameObject> _target;
		private CBool _enable;
		private CBool _force;
		private CBool _leaveRagdollEnabled;

		[Ordinal(0)] 
		[RED("target")] 
		public wCHandle<gameObject> Target
		{
			get => GetProperty(ref _target);
			set => SetProperty(ref _target, value);
		}

		[Ordinal(1)] 
		[RED("enable")] 
		public CBool Enable
		{
			get => GetProperty(ref _enable);
			set => SetProperty(ref _enable, value);
		}

		[Ordinal(2)] 
		[RED("force")] 
		public CBool Force
		{
			get => GetProperty(ref _force);
			set => SetProperty(ref _force, value);
		}

		[Ordinal(3)] 
		[RED("leaveRagdollEnabled")] 
		public CBool LeaveRagdollEnabled
		{
			get => GetProperty(ref _leaveRagdollEnabled);
			set => SetProperty(ref _leaveRagdollEnabled, value);
		}

		public RagdollToggleDelayEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
