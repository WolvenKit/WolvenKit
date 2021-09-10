using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class VehicleQuestWindowDestructionEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("windowName")] 
		public CName WindowName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("window")] 
		public CEnum<vehicleQuestWindowDestruction> Window
		{
			get => GetPropertyValue<CEnum<vehicleQuestWindowDestruction>>();
			set => SetPropertyValue<CEnum<vehicleQuestWindowDestruction>>(value);
		}
	}
}
