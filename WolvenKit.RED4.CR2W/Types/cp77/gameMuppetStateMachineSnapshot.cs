using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameMuppetStateMachineSnapshot : CVariable
	{
		private CName _stateMachineId;
		private CName _stateId;

		[Ordinal(0)] 
		[RED("stateMachineId")] 
		public CName StateMachineId
		{
			get
			{
				if (_stateMachineId == null)
				{
					_stateMachineId = (CName) CR2WTypeManager.Create("CName", "stateMachineId", cr2w, this);
				}
				return _stateMachineId;
			}
			set
			{
				if (_stateMachineId == value)
				{
					return;
				}
				_stateMachineId = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("stateId")] 
		public CName StateId
		{
			get
			{
				if (_stateId == null)
				{
					_stateId = (CName) CR2WTypeManager.Create("CName", "stateId", cr2w, this);
				}
				return _stateId;
			}
			set
			{
				if (_stateId == value)
				{
					return;
				}
				_stateId = value;
				PropertySet(this);
			}
		}

		public gameMuppetStateMachineSnapshot(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
