using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questRewardEvent : redEvent
	{
		private TweakDBID _rewardName;

		[Ordinal(0)] 
		[RED("rewardName")] 
		public TweakDBID RewardName
		{
			get => GetProperty(ref _rewardName);
			set => SetProperty(ref _rewardName, value);
		}

		public questRewardEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
