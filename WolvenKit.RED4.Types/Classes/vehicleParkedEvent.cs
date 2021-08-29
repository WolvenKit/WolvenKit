using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class vehicleParkedEvent : redEvent
	{
		private CBool _park;

		[Ordinal(0)] 
		[RED("park")] 
		public CBool Park
		{
			get => GetProperty(ref _park);
			set => SetProperty(ref _park, value);
		}
	}
}
