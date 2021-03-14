using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class GiveRewardEffector : gameEffector
	{
		private TweakDBID _reward;
		private entEntityID _target;

		[Ordinal(0)] 
		[RED("reward")] 
		public TweakDBID Reward
		{
			get
			{
				if (_reward == null)
				{
					_reward = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "reward", cr2w, this);
				}
				return _reward;
			}
			set
			{
				if (_reward == value)
				{
					return;
				}
				_reward = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("target")] 
		public entEntityID Target
		{
			get
			{
				if (_target == null)
				{
					_target = (entEntityID) CR2WTypeManager.Create("entEntityID", "target", cr2w, this);
				}
				return _target;
			}
			set
			{
				if (_target == value)
				{
					return;
				}
				_target = value;
				PropertySet(this);
			}
		}

		public GiveRewardEffector(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
