using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class NPCKillDelayEvent : redEvent
	{
		private CWeakHandle<gameObject> _target;
		private CBool _isLethalTakedown;
		private CBool _disableKillReward;

		[Ordinal(0)] 
		[RED("target")] 
		public CWeakHandle<gameObject> Target
		{
			get => GetProperty(ref _target);
			set => SetProperty(ref _target, value);
		}

		[Ordinal(1)] 
		[RED("isLethalTakedown")] 
		public CBool IsLethalTakedown
		{
			get => GetProperty(ref _isLethalTakedown);
			set => SetProperty(ref _isLethalTakedown, value);
		}

		[Ordinal(2)] 
		[RED("disableKillReward")] 
		public CBool DisableKillReward
		{
			get => GetProperty(ref _disableKillReward);
			set => SetProperty(ref _disableKillReward, value);
		}
	}
}
