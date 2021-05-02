using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class LocomotionSceneInitData : IScriptable
	{
		private CInt32 _previousLocomotionState;

		[Ordinal(0)] 
		[RED("previousLocomotionState")] 
		public CInt32 PreviousLocomotionState
		{
			get => GetProperty(ref _previousLocomotionState);
			set => SetProperty(ref _previousLocomotionState, value);
		}

		public LocomotionSceneInitData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
