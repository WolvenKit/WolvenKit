using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class vehicleFlippedOverEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("isFlippedOver")] 
		public CBool IsFlippedOver
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
	}
}
