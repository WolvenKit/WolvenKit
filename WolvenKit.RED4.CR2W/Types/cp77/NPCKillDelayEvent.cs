using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class NPCKillDelayEvent : redEvent
	{
		private wCHandle<gameObject> _target;
		private CBool _isLethalTakedown;
		private CBool _disableKillReward;

		[Ordinal(0)] 
		[RED("target")] 
		public wCHandle<gameObject> Target
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

		public NPCKillDelayEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
