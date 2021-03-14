using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questGiveReward_NodeType : questIRewardManagerNodeType
	{
		private CArray<TweakDBID> _rewards;

		[Ordinal(0)] 
		[RED("rewards")] 
		public CArray<TweakDBID> Rewards
		{
			get
			{
				if (_rewards == null)
				{
					_rewards = (CArray<TweakDBID>) CR2WTypeManager.Create("array:TweakDBID", "rewards", cr2w, this);
				}
				return _rewards;
			}
			set
			{
				if (_rewards == value)
				{
					return;
				}
				_rewards = value;
				PropertySet(this);
			}
		}

		public questGiveReward_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
