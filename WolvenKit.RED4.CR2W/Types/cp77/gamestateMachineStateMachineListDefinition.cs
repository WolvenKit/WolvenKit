using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gamestateMachineStateMachineListDefinition : IScriptable
	{
		private CArray<CHandle<gamestateMachineStateMachineDefinition>> _stateMachinesStorage;

		[Ordinal(0)] 
		[RED("stateMachinesStorage")] 
		public CArray<CHandle<gamestateMachineStateMachineDefinition>> StateMachinesStorage
		{
			get
			{
				if (_stateMachinesStorage == null)
				{
					_stateMachinesStorage = (CArray<CHandle<gamestateMachineStateMachineDefinition>>) CR2WTypeManager.Create("array:handle:gamestateMachineStateMachineDefinition", "stateMachinesStorage", cr2w, this);
				}
				return _stateMachinesStorage;
			}
			set
			{
				if (_stateMachinesStorage == value)
				{
					return;
				}
				_stateMachinesStorage = value;
				PropertySet(this);
			}
		}

		public gamestateMachineStateMachineListDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
