using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SlideExitingEvents : ExitingEvents
	{
		[Ordinal(5)] 
		[RED("exitMomentum")] 
		public Vector4 ExitMomentum
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		public SlideExitingEvents()
		{
			ExitSlot = "combat";
			ExitMomentum = new Vector4();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
