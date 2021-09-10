using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class PersonnelSystem : DeviceSystemBase
	{
		[Ordinal(97)] 
		[RED("EnableE3QuickHacks")] 
		public CBool EnableE3QuickHacks
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public PersonnelSystem()
		{
			ControllerTypeName = "PersonnelSystemController";
		}
	}
}
