using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class UiRadialContextEvents : InputContextTransitionEvents
	{
		private Vector4 _mouse;

		[Ordinal(1)] 
		[RED("mouse")] 
		public Vector4 Mouse
		{
			get => GetProperty(ref _mouse);
			set => SetProperty(ref _mouse, value);
		}
	}
}
