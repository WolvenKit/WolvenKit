using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIRootMotionCommand : AIMoveCommand
	{
		[Ordinal(7)] 
		[RED("params")] 
		public CHandle<gameSceneAnimationMotionActionParams> Params
		{
			get => GetPropertyValue<CHandle<gameSceneAnimationMotionActionParams>>();
			set => SetPropertyValue<CHandle<gameSceneAnimationMotionActionParams>>(value);
		}
	}
}
