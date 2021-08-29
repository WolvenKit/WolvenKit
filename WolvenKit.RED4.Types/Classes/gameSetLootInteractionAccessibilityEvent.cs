using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameSetLootInteractionAccessibilityEvent : redEvent
	{
		private CBool _accessible;

		[Ordinal(0)] 
		[RED("accessible")] 
		public CBool Accessible
		{
			get => GetProperty(ref _accessible);
			set => SetProperty(ref _accessible, value);
		}
	}
}
