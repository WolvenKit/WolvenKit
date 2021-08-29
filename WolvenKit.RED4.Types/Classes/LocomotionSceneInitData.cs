using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class LocomotionSceneInitData : IScriptable
	{
		private CInt32 _previousLocomotionState;

		[Ordinal(0)] 
		[RED("previousLocomotionState")] 
		public CInt32 PreviousLocomotionState
		{
			get => GetProperty(ref _previousLocomotionState);
			set => SetProperty(ref _previousLocomotionState, value);
		}
	}
}
