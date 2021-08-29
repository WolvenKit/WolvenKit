using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIRootMotionCommand : AIMoveCommand
	{
		private CHandle<gameSceneAnimationMotionActionParams> _params;

		[Ordinal(7)] 
		[RED("params")] 
		public CHandle<gameSceneAnimationMotionActionParams> Params
		{
			get => GetProperty(ref _params);
			set => SetProperty(ref _params, value);
		}
	}
}
