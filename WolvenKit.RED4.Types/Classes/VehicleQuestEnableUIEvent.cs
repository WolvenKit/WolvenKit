using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class VehicleQuestEnableUIEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("mode")] 
		public CEnum<vehicleQuestUIEnable> Mode
		{
			get => GetPropertyValue<CEnum<vehicleQuestUIEnable>>();
			set => SetPropertyValue<CEnum<vehicleQuestUIEnable>>(value);
		}
	}
}
