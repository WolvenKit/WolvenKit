using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CallElevator : ActionBool
	{
		[Ordinal(38)] 
		[RED("destination")] 
		public CInt32 Destination
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public CallElevator()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
