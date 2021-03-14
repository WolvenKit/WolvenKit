using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ModuleInstance : IScriptable
	{
		private CBool _isLookedAt;
		private CBool _isRevealed;
		private CBool _wasProcessed;
		private entEntityID _entityID;
		private CEnum<InstanceState> _state;
		private CHandle<ModuleInstance> _previousInstance;

		[Ordinal(0)] 
		[RED("isLookedAt")] 
		public CBool IsLookedAt
		{
			get
			{
				if (_isLookedAt == null)
				{
					_isLookedAt = (CBool) CR2WTypeManager.Create("Bool", "isLookedAt", cr2w, this);
				}
				return _isLookedAt;
			}
			set
			{
				if (_isLookedAt == value)
				{
					return;
				}
				_isLookedAt = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("isRevealed")] 
		public CBool IsRevealed
		{
			get
			{
				if (_isRevealed == null)
				{
					_isRevealed = (CBool) CR2WTypeManager.Create("Bool", "isRevealed", cr2w, this);
				}
				return _isRevealed;
			}
			set
			{
				if (_isRevealed == value)
				{
					return;
				}
				_isRevealed = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("wasProcessed")] 
		public CBool WasProcessed
		{
			get
			{
				if (_wasProcessed == null)
				{
					_wasProcessed = (CBool) CR2WTypeManager.Create("Bool", "wasProcessed", cr2w, this);
				}
				return _wasProcessed;
			}
			set
			{
				if (_wasProcessed == value)
				{
					return;
				}
				_wasProcessed = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("entityID")] 
		public entEntityID EntityID
		{
			get
			{
				if (_entityID == null)
				{
					_entityID = (entEntityID) CR2WTypeManager.Create("entEntityID", "entityID", cr2w, this);
				}
				return _entityID;
			}
			set
			{
				if (_entityID == value)
				{
					return;
				}
				_entityID = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("state")] 
		public CEnum<InstanceState> State
		{
			get
			{
				if (_state == null)
				{
					_state = (CEnum<InstanceState>) CR2WTypeManager.Create("InstanceState", "state", cr2w, this);
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

		[Ordinal(5)] 
		[RED("previousInstance")] 
		public CHandle<ModuleInstance> PreviousInstance
		{
			get
			{
				if (_previousInstance == null)
				{
					_previousInstance = (CHandle<ModuleInstance>) CR2WTypeManager.Create("handle:ModuleInstance", "previousInstance", cr2w, this);
				}
				return _previousInstance;
			}
			set
			{
				if (_previousInstance == value)
				{
					return;
				}
				_previousInstance = value;
				PropertySet(this);
			}
		}

		public ModuleInstance(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
