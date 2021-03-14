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
			get
			{
				if (_rewardName == null)
				{
					_rewardName = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "rewardName", cr2w, this);
				}
				return _rewardName;
			}
			set
			{
				if (_rewardName == value)
				{
					return;
				}
				_rewardName = value;
				PropertySet(this);
			}
		}

		public questRewardEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
