using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameMuppetStateMachinesSnapshot : CVariable
	{
		private CArray<gameMuppetStateMachineSnapshot> _stateMachines;

		[Ordinal(0)] 
		[RED("stateMachines")] 
		public CArray<gameMuppetStateMachineSnapshot> StateMachines
		{
			get
			{
				if (_stateMachines == null)
				{
					_stateMachines = (CArray<gameMuppetStateMachineSnapshot>) CR2WTypeManager.Create("array:gameMuppetStateMachineSnapshot", "stateMachines", cr2w, this);
				}
				return _stateMachines;
			}
			set
			{
				if (_stateMachines == value)
				{
					return;
				}
				_stateMachines = value;
				PropertySet(this);
			}
		}

		public gameMuppetStateMachinesSnapshot(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
