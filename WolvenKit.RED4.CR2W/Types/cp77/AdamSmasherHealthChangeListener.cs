using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AdamSmasherHealthChangeListener : gameCustomValueStatPoolsListener
	{
		private wCHandle<NPCPuppet> _owner;
		private wCHandle<PlayerPuppet> _player;
		private CHandle<AdamSmasherComponent> _adamSmasherComponent;
		private CEnum<gamedataStatPoolType> _statPoolType;
		private CHandle<gameStatPoolsSystem> _statPoolSystem;

		[Ordinal(0)] 
		[RED("owner")] 
		public wCHandle<NPCPuppet> Owner
		{
			get
			{
				if (_owner == null)
				{
					_owner = (wCHandle<NPCPuppet>) CR2WTypeManager.Create("whandle:NPCPuppet", "owner", cr2w, this);
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

		[Ordinal(1)] 
		[RED("player")] 
		public wCHandle<PlayerPuppet> Player
		{
			get
			{
				if (_player == null)
				{
					_player = (wCHandle<PlayerPuppet>) CR2WTypeManager.Create("whandle:PlayerPuppet", "player", cr2w, this);
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

		[Ordinal(2)] 
		[RED("adamSmasherComponent")] 
		public CHandle<AdamSmasherComponent> AdamSmasherComponent
		{
			get
			{
				if (_adamSmasherComponent == null)
				{
					_adamSmasherComponent = (CHandle<AdamSmasherComponent>) CR2WTypeManager.Create("handle:AdamSmasherComponent", "adamSmasherComponent", cr2w, this);
				}
				return _adamSmasherComponent;
			}
			set
			{
				if (_adamSmasherComponent == value)
				{
					return;
				}
				_adamSmasherComponent = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("statPoolType")] 
		public CEnum<gamedataStatPoolType> StatPoolType
		{
			get
			{
				if (_statPoolType == null)
				{
					_statPoolType = (CEnum<gamedataStatPoolType>) CR2WTypeManager.Create("gamedataStatPoolType", "statPoolType", cr2w, this);
				}
				return _statPoolType;
			}
			set
			{
				if (_statPoolType == value)
				{
					return;
				}
				_statPoolType = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("statPoolSystem")] 
		public CHandle<gameStatPoolsSystem> StatPoolSystem
		{
			get
			{
				if (_statPoolSystem == null)
				{
					_statPoolSystem = (CHandle<gameStatPoolsSystem>) CR2WTypeManager.Create("handle:gameStatPoolsSystem", "statPoolSystem", cr2w, this);
				}
				return _statPoolSystem;
			}
			set
			{
				if (_statPoolSystem == value)
				{
					return;
				}
				_statPoolSystem = value;
				PropertySet(this);
			}
		}

		public AdamSmasherHealthChangeListener(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
