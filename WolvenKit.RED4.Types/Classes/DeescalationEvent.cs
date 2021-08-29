using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class DeescalationEvent : redEvent
	{
		private CHandle<SecuritySystemInput> _originalNotification;

		[Ordinal(0)] 
		[RED("originalNotification")] 
		public CHandle<SecuritySystemInput> OriginalNotification
		{
			get => GetProperty(ref _originalNotification);
			set => SetProperty(ref _originalNotification, value);
		}
	}
}
