using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PickUpEvents : CarriedObjectEvents
	{
		private gamestateMachineStateMachineInstanceData _stateMachineInstanceData;

		[Ordinal(9)] 
		[RED("stateMachineInstanceData")] 
		public gamestateMachineStateMachineInstanceData StateMachineInstanceData
		{
			get
			{
				if (_stateMachineInstanceData == null)
				{
					_stateMachineInstanceData = (gamestateMachineStateMachineInstanceData) CR2WTypeManager.Create("gamestateMachineStateMachineInstanceData", "stateMachineInstanceData", cr2w, this);
				}
				return _stateMachineInstanceData;
			}
			set
			{
				if (_stateMachineInstanceData == value)
				{
					return;
				}
				_stateMachineInstanceData = value;
				PropertySet(this);
			}
		}

		public PickUpEvents(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
