using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class VehicleUIactivateEvent : redEvent
	{
		private CBool _activate;

		[Ordinal(0)] 
		[RED("activate")] 
		public CBool Activate
		{
			get => GetProperty(ref _activate);
			set => SetProperty(ref _activate, value);
		}
	}
}
