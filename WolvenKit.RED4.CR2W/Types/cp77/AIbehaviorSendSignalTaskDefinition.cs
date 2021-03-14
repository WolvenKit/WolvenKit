using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorSendSignalTaskDefinition : AIbehaviorTaskDefinition
	{
		private CName _signalName;
		private CEnum<gameBoolSignalAction> _startAction;
		private CHandle<gameSignalUserDataDefinition> _startActionUserData;
		private CEnum<gameBoolSignalAction> _endAction;
		private CHandle<gameSignalUserDataDefinition> _endActionUserData;

		[Ordinal(1)] 
		[RED("signalName")] 
		public CName SignalName
		{
			get
			{
				if (_signalName == null)
				{
					_signalName = (CName) CR2WTypeManager.Create("CName", "signalName", cr2w, this);
				}
				return _signalName;
			}
			set
			{
				if (_signalName == value)
				{
					return;
				}
				_signalName = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("startAction")] 
		public CEnum<gameBoolSignalAction> StartAction
		{
			get
			{
				if (_startAction == null)
				{
					_startAction = (CEnum<gameBoolSignalAction>) CR2WTypeManager.Create("gameBoolSignalAction", "startAction", cr2w, this);
				}
				return _startAction;
			}
			set
			{
				if (_startAction == value)
				{
					return;
				}
				_startAction = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("startActionUserData")] 
		public CHandle<gameSignalUserDataDefinition> StartActionUserData
		{
			get
			{
				if (_startActionUserData == null)
				{
					_startActionUserData = (CHandle<gameSignalUserDataDefinition>) CR2WTypeManager.Create("handle:gameSignalUserDataDefinition", "startActionUserData", cr2w, this);
				}
				return _startActionUserData;
			}
			set
			{
				if (_startActionUserData == value)
				{
					return;
				}
				_startActionUserData = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("endAction")] 
		public CEnum<gameBoolSignalAction> EndAction
		{
			get
			{
				if (_endAction == null)
				{
					_endAction = (CEnum<gameBoolSignalAction>) CR2WTypeManager.Create("gameBoolSignalAction", "endAction", cr2w, this);
				}
				return _endAction;
			}
			set
			{
				if (_endAction == value)
				{
					return;
				}
				_endAction = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("endActionUserData")] 
		public CHandle<gameSignalUserDataDefinition> EndActionUserData
		{
			get
			{
				if (_endActionUserData == null)
				{
					_endActionUserData = (CHandle<gameSignalUserDataDefinition>) CR2WTypeManager.Create("handle:gameSignalUserDataDefinition", "endActionUserData", cr2w, this);
				}
				return _endActionUserData;
			}
			set
			{
				if (_endActionUserData == value)
				{
					return;
				}
				_endActionUserData = value;
				PropertySet(this);
			}
		}

		public AIbehaviorSendSignalTaskDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
