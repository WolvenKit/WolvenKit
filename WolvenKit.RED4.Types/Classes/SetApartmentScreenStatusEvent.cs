using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SetApartmentScreenStatusEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("rentStatus")] 
		public CEnum<ERentStatus> RentStatus
		{
			get => GetPropertyValue<CEnum<ERentStatus>>();
			set => SetPropertyValue<CEnum<ERentStatus>>(value);
		}
	}
}
