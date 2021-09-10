using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class VehicleRadioLogicController : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("isSoundStopped")] 
		public CBool IsSoundStopped
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
	}
}
