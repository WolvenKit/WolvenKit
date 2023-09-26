using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class PersonnelSystem : DeviceSystemBase
	{
		[Ordinal(98)] 
		[RED("EnableE3QuickHacks")] 
		public CBool EnableE3QuickHacks
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public PersonnelSystem()
		{
			ControllerTypeName = "PersonnelSystemController";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
