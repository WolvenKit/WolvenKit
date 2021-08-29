using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class moveMotionPlannerComponent : moveIMotionPlannerComponent
	{
		private CBool _snapToGround;

		[Ordinal(3)] 
		[RED("snapToGround")] 
		public CBool SnapToGround
		{
			get => GetProperty(ref _snapToGround);
			set => SetProperty(ref _snapToGround, value);
		}
	}
}
