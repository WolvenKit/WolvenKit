using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameTransformAnimation_Movement_PredefinedFunction : gameTransformAnimation_Movement
	{
		[Ordinal(0)] 
		[RED("function")] 
		public EasingFunction Function
		{
			get => GetPropertyValue<EasingFunction>();
			set => SetPropertyValue<EasingFunction>(value);
		}

		public gameTransformAnimation_Movement_PredefinedFunction()
		{
			Function = new();
		}
	}
}
