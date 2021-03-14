using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ModifyStatPoolModifierEffector : gameEffector
	{
		private wCHandle<gameObject> _owner;
		private gameStatPoolModifier _poolModifier;
		private CEnum<gamedataStatPoolType> _poolType;
		private CEnum<gameStatPoolModificationTypes> _modType;
		private gameStatPoolModifier _previousMod;

		[Ordinal(0)] 
		[RED("owner")] 
		public wCHandle<gameObject> Owner
		{
			get
			{
				if (_owner == null)
				{
					_owner = (wCHandle<gameObject>) CR2WTypeManager.Create("whandle:gameObject", "owner", cr2w, this);
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
		[RED("poolModifier")] 
		public gameStatPoolModifier PoolModifier
		{
			get
			{
				if (_poolModifier == null)
				{
					_poolModifier = (gameStatPoolModifier) CR2WTypeManager.Create("gameStatPoolModifier", "poolModifier", cr2w, this);
				}
				return _poolModifier;
			}
			set
			{
				if (_poolModifier == value)
				{
					return;
				}
				_poolModifier = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("poolType")] 
		public CEnum<gamedataStatPoolType> PoolType
		{
			get
			{
				if (_poolType == null)
				{
					_poolType = (CEnum<gamedataStatPoolType>) CR2WTypeManager.Create("gamedataStatPoolType", "poolType", cr2w, this);
				}
				return _poolType;
			}
			set
			{
				if (_poolType == value)
				{
					return;
				}
				_poolType = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("modType")] 
		public CEnum<gameStatPoolModificationTypes> ModType
		{
			get
			{
				if (_modType == null)
				{
					_modType = (CEnum<gameStatPoolModificationTypes>) CR2WTypeManager.Create("gameStatPoolModificationTypes", "modType", cr2w, this);
				}
				return _modType;
			}
			set
			{
				if (_modType == value)
				{
					return;
				}
				_modType = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("previousMod")] 
		public gameStatPoolModifier PreviousMod
		{
			get
			{
				if (_previousMod == null)
				{
					_previousMod = (gameStatPoolModifier) CR2WTypeManager.Create("gameStatPoolModifier", "previousMod", cr2w, this);
				}
				return _previousMod;
			}
			set
			{
				if (_previousMod == value)
				{
					return;
				}
				_previousMod = value;
				PropertySet(this);
			}
		}

		public ModifyStatPoolModifierEffector(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
