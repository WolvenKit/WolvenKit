using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class RagdollToggleDelayEvent : redEvent
	{
		private CWeakHandle<gameObject> _target;
		private CBool _enable;
		private CBool _force;
		private CBool _leaveRagdollEnabled;

		[Ordinal(0)] 
		[RED("target")] 
		public CWeakHandle<gameObject> Target
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
	}
}
