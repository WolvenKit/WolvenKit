using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameTransformAnimation_Movement_PredefinedFunction : gameTransformAnimation_Movement
	{
		private EasingFunction _function;

		[Ordinal(0)] 
		[RED("function")] 
		public EasingFunction Function
		{
			get => GetProperty(ref _function);
			set => SetProperty(ref _function, value);
		}
	}
}
