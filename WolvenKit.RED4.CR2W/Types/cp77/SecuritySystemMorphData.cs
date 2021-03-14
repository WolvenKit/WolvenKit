using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SecuritySystemMorphData : CVariable
	{
		private CHandle<State> _state;
		private CHandle<Reprimand> _reprimandData;
		private CHandle<Blacklist> _blacklist;
		private CHandle<ProtectedEntities> _protectedEntities;
		private CHandle<EntitiesAtGate> _entitiesAtGate;

		[Ordinal(0)] 
		[RED("state")] 
		public CHandle<State> State
		{
			get
			{
				if (_state == null)
				{
					_state = (CHandle<State>) CR2WTypeManager.Create("handle:State", "state", cr2w, this);
				}
				return _state;
			}
			set
			{
				if (_state == value)
				{
					return;
				}
				_state = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("reprimandData")] 
		public CHandle<Reprimand> ReprimandData
		{
			get
			{
				if (_reprimandData == null)
				{
					_reprimandData = (CHandle<Reprimand>) CR2WTypeManager.Create("handle:Reprimand", "reprimandData", cr2w, this);
				}
				return _reprimandData;
			}
			set
			{
				if (_reprimandData == value)
				{
					return;
				}
				_reprimandData = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("blacklist")] 
		public CHandle<Blacklist> Blacklist
		{
			get
			{
				if (_blacklist == null)
				{
					_blacklist = (CHandle<Blacklist>) CR2WTypeManager.Create("handle:Blacklist", "blacklist", cr2w, this);
				}
				return _blacklist;
			}
			set
			{
				if (_blacklist == value)
				{
					return;
				}
				_blacklist = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("protectedEntities")] 
		public CHandle<ProtectedEntities> ProtectedEntities
		{
			get
			{
				if (_protectedEntities == null)
				{
					_protectedEntities = (CHandle<ProtectedEntities>) CR2WTypeManager.Create("handle:ProtectedEntities", "protectedEntities", cr2w, this);
				}
				return _protectedEntities;
			}
			set
			{
				if (_protectedEntities == value)
				{
					return;
				}
				_protectedEntities = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("entitiesAtGate")] 
		public CHandle<EntitiesAtGate> EntitiesAtGate
		{
			get
			{
				if (_entitiesAtGate == null)
				{
					_entitiesAtGate = (CHandle<EntitiesAtGate>) CR2WTypeManager.Create("handle:EntitiesAtGate", "entitiesAtGate", cr2w, this);
				}
				return _entitiesAtGate;
			}
			set
			{
				if (_entitiesAtGate == value)
				{
					return;
				}
				_entitiesAtGate = value;
				PropertySet(this);
			}
		}

		public SecuritySystemMorphData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
