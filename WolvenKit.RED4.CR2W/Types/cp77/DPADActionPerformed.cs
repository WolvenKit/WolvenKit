using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DPADActionPerformed : redEvent
	{
		private entEntityID _ownerID;
		private CEnum<EUIActionState> _state;
		private CInt32 _stateInt;
		private CEnum<gameEHotkey> _action;
		private CBool _successful;

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
		[RED("state")] 
		public CEnum<EUIActionState> State
		{
			get
			{
				if (_state == null)
				{
					_state = (CEnum<EUIActionState>) CR2WTypeManager.Create("EUIActionState", "state", cr2w, this);
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

		[Ordinal(2)] 
		[RED("stateInt")] 
		public CInt32 StateInt
		{
			get
			{
				if (_stateInt == null)
				{
					_stateInt = (CInt32) CR2WTypeManager.Create("Int32", "stateInt", cr2w, this);
				}
				return _stateInt;
			}
			set
			{
				if (_stateInt == value)
				{
					return;
				}
				_stateInt = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("action")] 
		public CEnum<gameEHotkey> Action
		{
			get
			{
				if (_action == null)
				{
					_action = (CEnum<gameEHotkey>) CR2WTypeManager.Create("gameEHotkey", "action", cr2w, this);
				}
				return _action;
			}
			set
			{
				if (_action == value)
				{
					return;
				}
				_action = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("successful")] 
		public CBool Successful
		{
			get
			{
				if (_successful == null)
				{
					_successful = (CBool) CR2WTypeManager.Create("Bool", "successful", cr2w, this);
				}
				return _successful;
			}
			set
			{
				if (_successful == value)
				{
					return;
				}
				_successful = value;
				PropertySet(this);
			}
		}

		public DPADActionPerformed(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
