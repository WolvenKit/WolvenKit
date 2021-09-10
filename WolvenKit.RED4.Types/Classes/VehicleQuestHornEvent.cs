using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class VehicleQuestHornEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("honkTime")] 
		public CFloat HonkTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
	}
}
