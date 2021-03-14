using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIThreatValid : AIAIEvent
	{
		private wCHandle<entEntity> _owner;
		private wCHandle<entEntity> _threat;
		private CBool _isEnemy;
		private CBool _isHostile;

		[Ordinal(2)] 
		[RED("owner")] 
		public wCHandle<entEntity> Owner
		{
			get
			{
				if (_owner == null)
				{
					_owner = (wCHandle<entEntity>) CR2WTypeManager.Create("whandle:entEntity", "owner", cr2w, this);
				}
				return _owner;
			}
			set
			{
				if (_owner == value)
				{
					return;
				}
				_owner = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("threat")] 
		public wCHandle<entEntity> Threat
		{
			get
			{
				if (_threat == null)
				{
					_threat = (wCHandle<entEntity>) CR2WTypeManager.Create("whandle:entEntity", "threat", cr2w, this);
				}
				return _threat;
			}
			set
			{
				if (_threat == value)
				{
					return;
				}
				_threat = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("isEnemy")] 
		public CBool IsEnemy
		{
			get
			{
				if (_isEnemy == null)
				{
					_isEnemy = (CBool) CR2WTypeManager.Create("Bool", "isEnemy", cr2w, this);
				}
				return _isEnemy;
			}
			set
			{
				if (_isEnemy == value)
				{
					return;
				}
				_isEnemy = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("isHostile")] 
		public CBool IsHostile
		{
			get
			{
				if (_isHostile == null)
				{
					_isHostile = (CBool) CR2WTypeManager.Create("Bool", "isHostile", cr2w, this);
				}
				return _isHostile;
			}
			set
			{
				if (_isHostile == value)
				{
					return;
				}
				_isHostile = value;
				PropertySet(this);
			}
		}

		public AIThreatValid(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
