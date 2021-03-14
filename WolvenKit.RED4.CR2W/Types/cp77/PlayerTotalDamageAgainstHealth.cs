using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PlayerTotalDamageAgainstHealth : CVariable
	{
		private wCHandle<gameObject> _player;
		private CFloat _totalDamage;
		private CFloat _targetHealth;

		[Ordinal(0)] 
		[RED("player")] 
		public wCHandle<gameObject> Player
		{
			get
			{
				if (_player == null)
				{
					_player = (wCHandle<gameObject>) CR2WTypeManager.Create("whandle:gameObject", "player", cr2w, this);
				}
				return _player;
			}
			set
			{
				if (_player == value)
				{
					return;
				}
				_player = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("totalDamage")] 
		public CFloat TotalDamage
		{
			get
			{
				if (_totalDamage == null)
				{
					_totalDamage = (CFloat) CR2WTypeManager.Create("Float", "totalDamage", cr2w, this);
				}
				return _totalDamage;
			}
			set
			{
				if (_totalDamage == value)
				{
					return;
				}
				_totalDamage = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("targetHealth")] 
		public CFloat TargetHealth
		{
			get
			{
				if (_targetHealth == null)
				{
					_targetHealth = (CFloat) CR2WTypeManager.Create("Float", "targetHealth", cr2w, this);
				}
				return _targetHealth;
			}
			set
			{
				if (_targetHealth == value)
				{
					return;
				}
				_targetHealth = value;
				PropertySet(this);
			}
		}

		public PlayerTotalDamageAgainstHealth(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
