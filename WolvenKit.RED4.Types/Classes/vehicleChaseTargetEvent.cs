using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class vehicleChaseTargetEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("inProgress")] 
		public CBool InProgress
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public vehicleChaseTargetEvent()
		{
			InProgress = true;
		}
	}
}
