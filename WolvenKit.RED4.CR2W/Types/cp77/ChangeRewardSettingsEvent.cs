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
			get
			{
				if (_forceDefeatReward == null)
				{
					_forceDefeatReward = (CBool) CR2WTypeManager.Create("Bool", "forceDefeatReward", cr2w, this);
				}
				return _forceDefeatReward;
			}
			set
			{
				if (_forceDefeatReward == value)
				{
					return;
				}
				_forceDefeatReward = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("disableKillReward")] 
		public CBool DisableKillReward
		{
			get
			{
				if (_disableKillReward == null)
				{
					_disableKillReward = (CBool) CR2WTypeManager.Create("Bool", "disableKillReward", cr2w, this);
				}
				return _disableKillReward;
			}
			set
			{
				if (_disableKillReward == value)
				{
					return;
				}
				_disableKillReward = value;
				PropertySet(this);
			}
		}

		public ChangeRewardSettingsEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
