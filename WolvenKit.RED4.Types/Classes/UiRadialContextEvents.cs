using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class UiRadialContextEvents : InputContextTransitionEvents
	{
		[Ordinal(1)] 
		[RED("mouse")] 
		public Vector4 Mouse
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		public UiRadialContextEvents()
		{
			Mouse = new();
		}
	}
}
