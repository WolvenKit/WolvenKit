using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RewireEvent : redEvent
	{
		private entEntityID _ownerID;
		private entEntityID _activatorID;
		private wCHandle<gameObject> _executor;
		private CEnum<EDrillMachineRewireState> _state;
		private CBool _sucess;

		[Ordinal(0)] 
		[RED("ownerID")] 
		public entEntityID OwnerID
		{
			get
			{
				if (_ownerID == null)
				{
					_ownerID = (entEntityID) CR2WTypeManager.Create("entEntityID", "ownerID", cr2w, this);
				}
				return _ownerID;
			}
			set
			{
				if (_ownerID == value)
				{
					return;
				}
				_ownerID = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("activatorID")] 
		public entEntityID ActivatorID
		{
			get
			{
				if (_activatorID == null)
				{
					_activatorID = (entEntityID) CR2WTypeManager.Create("entEntityID", "activatorID", cr2w, this);
				}
				return _activatorID;
			}
			set
			{
				if (_activatorID == value)
				{
					return;
				}
				_activatorID = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("executor")] 
		public wCHandle<gameObject> Executor
		{
			get
			{
				if (_executor == null)
				{
					_executor = (wCHandle<gameObject>) CR2WTypeManager.Create("whandle:gameObject", "executor", cr2w, this);
				}
				return _executor;
			}
			set
			{
				if (_executor == value)
				{
					return;
				}
				_executor = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("state")] 
		public CEnum<EDrillMachineRewireState> State
		{
			get
			{
				if (_state == null)
				{
					_state = (CEnum<EDrillMachineRewireState>) CR2WTypeManager.Create("EDrillMachineRewireState", "state", cr2w, this);
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

		[Ordinal(4)] 
		[RED("sucess")] 
		public CBool Sucess
		{
			get
			{
				if (_sucess == null)
				{
					_sucess = (CBool) CR2WTypeManager.Create("Bool", "sucess", cr2w, this);
				}
				return _sucess;
			}
			set
			{
				if (_sucess == value)
				{
					return;
				}
				_sucess = value;
				PropertySet(this);
			}
		}

		public RewireEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
