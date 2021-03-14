using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class VehicleTransition : DefaultTransition
	{
		private wCHandle<VehicleTransitionInitData> _stateMachineInitData;

		[Ordinal(0)] 
		[RED("stateMachineInitData")] 
		public wCHandle<VehicleTransitionInitData> StateMachineInitData
		{
			get
			{
				if (_stateMachineInitData == null)
				{
					_stateMachineInitData = (wCHandle<VehicleTransitionInitData>) CR2WTypeManager.Create("whandle:VehicleTransitionInitData", "stateMachineInitData", cr2w, this);
				}
				return _stateMachineInitData;
			}
			set
			{
				if (_stateMachineInitData == value)
				{
					return;
				}
				_stateMachineInitData = value;
				PropertySet(this);
			}
		}

		public VehicleTransition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
