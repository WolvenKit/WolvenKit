using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SpeedExitingEvents : ExitingEvents
	{
		[Ordinal(5)] 
		[RED("exitForce")] 
		public Vector4 ExitForce
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		public SpeedExitingEvents()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
