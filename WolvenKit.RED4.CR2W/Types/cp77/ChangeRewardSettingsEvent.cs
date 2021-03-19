using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ChangeRewardSettingsEvent : redEvent
	{
		private CBool _forceDefeatReward;
		private CBool _disableKillReward;

		[Ordinal(0)] 
		[RED("forceDefeatReward")] 
		public CBool ForceDefeatReward
		{
			get => GetProperty(ref _forceDefeatReward);
			set => SetProperty(ref _forceDefeatReward, value);
		}

		[Ordinal(1)] 
		[RED("disableKillReward")] 
		public CBool DisableKillReward
		{
			get => GetProperty(ref _disableKillReward);
			set => SetProperty(ref _disableKillReward, value);
		}

		public ChangeRewardSettingsEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
