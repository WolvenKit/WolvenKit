using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class TakedownReleasePreyDecisions : LocomotionTakedownDecisions
	{
		private wCHandle<LocomotionTakedownInitData> _stateMachineInitData;

		[Ordinal(0)] 
		[RED("stateMachineInitData")] 
		public wCHandle<LocomotionTakedownInitData> StateMachineInitData
		{
			get => GetProperty(ref _stateMachineInitData);
			set => SetProperty(ref _stateMachineInitData, value);
		}

		public TakedownReleasePreyDecisions(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
