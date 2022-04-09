using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ExitFromVehicle : AIVehicleTaskAbstract
	{
		[Ordinal(0)] 
		[RED("useFastExit")] 
		public CBool UseFastExit
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("tryBlendToWalk")] 
		public CBool TryBlendToWalk
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public ExitFromVehicle()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
