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
			get
			{
				if (_target == null)
				{
					_target = (wCHandle<gameObject>) CR2WTypeManager.Create("whandle:gameObject", "target", cr2w, this);
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

		[Ordinal(1)] 
		[RED("isLethalTakedown")] 
		public CBool IsLethalTakedown
		{
			get
			{
				if (_isLethalTakedown == null)
				{
					_isLethalTakedown = (CBool) CR2WTypeManager.Create("Bool", "isLethalTakedown", cr2w, this);
				}
				return _isLethalTakedown;
			}
			set
			{
				if (_isLethalTakedown == value)
				{
					return;
				}
				_isLethalTakedown = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
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

		public NPCKillDelayEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
