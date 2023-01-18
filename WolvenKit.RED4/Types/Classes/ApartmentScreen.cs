using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ApartmentScreen : LcdScreen
	{
		[Ordinal(96)] 
		[RED("timeSystemCallbackID")] 
		public CUInt32 TimeSystemCallbackID
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		public ApartmentScreen()
		{
			ControllerTypeName = "ApartmentScreenController";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
